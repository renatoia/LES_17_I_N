using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_N
{
    public partial class frmbairro : Form
    {
        public frmbairro()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO BAIRRO"
                       + " VALUES ("
                       + txtbaicodi.Text + ", '"
                       + txtbainome.Text + "' ,"
                       + "(SELECT MUNCODI FROM MUNICIPIO WHERE MUNNOME = '"
                       + cmbmunnome.SelectedItem.ToString() + "')"
                       + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE BAIRRO"
                                + " SET BAICODI = " + txtbaicodi.Text + ", "
                                + " BAINOME = '" + txtbainome.Text + "', "
                                + " MUNCODI = (SELECT M.MUNCODI FROM MUNICIPIO M WHERE M.MUNNOME = '"
                                              + cmbmunnome.SelectedItem.ToString() + "')"
                                + " WHERE BAICODI = '" + txtbaicodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtbainome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM BAIRRO WHERE BAICODI = " + txtbaicodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void limpar()
        {
            txtbaicodi.Clear();
            txtbainome.Clear();
            cmbmunnome.SelectedIndex = -1;
            txtbaicodi.Focus();
        }

        private void frmbairro_Load(object sender, EventArgs e)
        {
            DgvDados();

            string strMunicipio = "SELECT MUNNOME FROM MUNICIPIO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strMunicipio, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbmunnome.Items.Add(dr["MUNNOME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadosbairro = "SELECT B.BAICODI, B.BAINOME, M.MUNNOME"
                                      + " FROM BAIRRO B "
                                      + " LEFT JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosbairro, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvbairro.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvbairro_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvbairro.RowCount > 0 && dgvbairro.SelectedRows.Count == 1)
            {
                int baiCodigo = Convert.ToInt32(dgvbairro.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT B.BAICODI, B.BAINOME, M.MUNNOME"
                                      + " FROM BAIRRO B "
                                      + " LEFT JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " WHERE B.BAICODI = " + baiCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtbaicodi.Text = dr["BAICODI"].ToString();
                        txtbainome.Text = dr["BAINOME"].ToString();

                        cmbmunnome.SelectedIndex = 0;
                        while (!cmbmunnome.SelectedItem.ToString().Equals(dr["MUNNOME"].ToString()))
                            cmbmunnome.SelectedIndex++;

                        tbcbairro.SelectedIndex = 1;
                        txtbainome.Focus();
                        btnincluir.Enabled = false;
                    }
                }
                finally
                {
                    Conexao.Active(false);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void txtbaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtbaicodi.Text != "")
            {
                string strConsulta = "SELECT B.BAICODI, B.BAINOME, M.MUNNOME"
                                      + " FROM BAIRRO B"
                                      + " LEFT JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " WHERE B.BAICODI = " + txtbaicodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaBairro(dr);
                        txtbainome.Focus();
                        btnincluir.Enabled = false;
                    }
                    else
                    {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            txtbainome.Text = "";
                            txtbainome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }
        private void ConsultaBairro(FbDataReader dr)
        {
            txtbaicodi.Text = dr["BAICODI"].ToString();
            txtbainome.Text = dr["BAINOME"].ToString();
            cmbmunnome.SelectedIndex = 0;
            while (!cmbmunnome.SelectedItem.ToString().Equals(dr["MUNNOME"].ToString()))
                cmbmunnome.SelectedIndex++;
        }

        private void tbclistagembairro_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcbairro.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void frmbairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}