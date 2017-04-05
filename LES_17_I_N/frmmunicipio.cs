using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmmunicipio : Form
    {
        public frmmunicipio()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO MUNICIPIO"
                       + " VALUES ("
                       + txtmuncodi.Text + ", '"
                       + txtmunnome.Text + "' ,"
                       + "(SELECT ESTCODI FROM ESTADO WHERE ESTNOME = '"
                       + cmbestnome.SelectedItem.ToString() + "')"
                       + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtmuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE MUNICIPIO"
                                + " SET MUNCODI = " + txtmuncodi.Text + ", "
                                + " MUNNOME = '" + txtmunnome.Text + "', "
                                + " ESTCODI = (SELECT E.ESTCODI FROM ESTADO E WHERE E.ESTNOME = '"
                                              + cmbestnome.SelectedItem.ToString() + "')"
                                + " WHERE MUNCODI = '" + txtmuncodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtmunnome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM MUNICIPIO WHERE MUNCODI = " + txtmuncodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtmuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void limpar()
        {
            txtmuncodi.Clear();
            txtmunnome.Clear();
            cmbestnome.SelectedIndex = -1;
            txtmuncodi.Focus();
        }

        private void frmmunicipio_Load(object sender, EventArgs e)
        {
            DgvDados();

            string strEstado = "SELECT E.ESTNOME, P.PAINOME"
                            + " FROM ESTADO E"
                            + " INNER JOIN PAIS P ON P.PAICODI = E.PAICODI";

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strEstado, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbestnome.Items.Add(dr["ESTNOME"].ToString());
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
                string dadosmunicipio = "SELECT M.MUNCODI, M.MUNNOME, E.ESTNOME, P.PAINOME"
                                      + " FROM MUNICIPIO M "
                                      + " INNER JOIN ESTADO E ON E.ESTCODI = M.ESTCODI"
                                      + " INNER JOIN PAIS P ON P.PAICODI = E.PAICODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosmunicipio, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvmunicipio.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvmunicipio_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvmunicipio.RowCount > 0 && dgvmunicipio.SelectedRows.Count == 1)
            {
                int munCodigo = Convert.ToInt32(dgvmunicipio.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT M.MUNCODI, M.MUNNOME, E.ESTNOME, P.PAINOME"
                           + " FROM MUNICIPIO M "
                           + " INNER JOIN ESTADO E ON E.ESTCODI = M.ESTCODI"
                           + " INNER JOIN PAIS P ON P.PAICODI = E.PAICODI"
                           + " WHERE M.MUNCODI = " + munCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtmuncodi.Text = dr["MUNCODI"].ToString();
                        txtmunnome.Text = dr["MUNNOME"].ToString();

                        cmbestnome.SelectedIndex = 0;
                        while (!cmbestnome.SelectedItem.ToString().Equals(dr["ESTNOME"].ToString()))
                            cmbestnome.SelectedIndex++;

                        lblpais.Text = dr["PAINOME"].ToString();
                        tbcmunicipio.SelectedIndex = 1;
                        txtmunnome.Focus();
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


        private void txtmuncodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtmuncodi.Text != "")
            {
                string strConsulta = "SELECT M.MUNCODI, M.MUNNOME, E.ESTNOME"
                                      + " FROM MUNICIPIO M "
                                      + " LEFT JOIN ESTADO E ON E.ESTCODI = M.ESTCODI"
                                      + " WHERE M.MUNCODI = " + txtmuncodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaMunicipio(dr);
                        txtmunnome.Focus();
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
                            txtmunnome.Text = "";
                            txtmunnome.Focus();
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
        private void ConsultaMunicipio(FbDataReader dr)
        {
            txtmuncodi.Text = dr["MUNCODI"].ToString();
            txtmunnome.Text = dr["MUNNOME"].ToString();
            cmbestnome.SelectedIndex = 0;
            while (!cmbestnome.SelectedItem.ToString().Equals(dr["ESTNOME"].ToString()))
                cmbestnome.SelectedIndex++;
            lblpais.Text = dr["PAINOME"].ToString();
        }

        private void tbclistagemmunicipio_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcmunicipio.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void frmmunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
