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
    public partial class frmendereco : Form
    {
        public frmendereco()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO ENDERECO"
                       + " VALUES ("
                       + txtendcep.Text + ", '"
                       + txtendende.Text + "' ,"
                       + "(SELECT BAICODI FROM BAIRRO WHERE BAINOME = '"
                       + cmbbainome.SelectedItem.ToString() + "')"
                       + " )";

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE ENDERECO"
                                + " SET ENDCEP = " + txtendcep.Text + ", "
                                + " ENDENDE = '" + txtendende.Text + "', "
                                + " BAICODI = (SELECT B.BAICODI FROM BAIRRO B WHERE B.BAINOME = '"
                                              + cmbbainome.SelectedItem.ToString() + "')"
                                + " WHERE ENDECEP = '" + txtendcep.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtendende.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM ENDERECO WHERE ENDCEP = " + txtendcep.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void limpar()
        {
            txtendcep.Clear();
            txtendende.Clear();
            cmbbainome.SelectedIndex = -1;
            txtendcep.Focus();
        }



        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void frmendereco_Load(object sender, EventArgs e)
        {
            DgvDados();

            string strEndereco = "SELECT BAINOME FROM BAIRRO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strEndereco, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbbainome.Items.Add(dr["BAINOME"].ToString());
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
                string dadosendereco = "SELECT E.ENDCEP, E.ENDENDE, B.BAINOME"
                                      + " FROM ENDERECO E"
                                      + " LEFT JOIN BAIRRO B ON B.BAICODI = E.BAICODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosendereco, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvendereco.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvendereco_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvendereco.RowCount > 0 && dgvendereco.SelectedRows.Count == 1)
            {
                int endCodigo = Convert.ToInt32(dgvendereco.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT E.ENDCEP, E.ENDENDE, B.BAINOME"
                                      + " FROM ENDERECO E "
                                      + " LEFT JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " WHERE E.ENDCEP = " + endCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtendcep.Text = dr["ENDCEP"].ToString();
                        txtendende.Text = dr["ENDENDE"].ToString();

                        cmbbainome.SelectedIndex = 0;
                        while (!cmbbainome.SelectedItem.ToString().Equals(dr["BAINOME"].ToString()))
                            cmbbainome.SelectedIndex++;

                        tbcendereco.SelectedIndex = 1;
                        txtendende.Focus();
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

        private void txtendcep_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtendcep.Text != "")
            {
                string strConsulta = "SELECT E.ENDCEP, E.ENDENDE, B.BAINOME"
                                      + " FROM ENDERECO E "
                                      + " LEFT JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " WHERE E.ENDCEP = " + txtendcep.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaEndereco(dr);
                        txtendende.Focus();
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
                            txtendende.Text = "";
                            txtendende.Focus();
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

        private void ConsultaEndereco(FbDataReader dr)
        {
            txtendcep.Text = dr["ENDCEP"].ToString();
            txtendende.Text = dr["ENDENDE"].ToString();
            cmbbainome.SelectedIndex = 0;
            while (!cmbbainome.SelectedItem.ToString().Equals(dr["BAINOME"].ToString()))
                cmbbainome.SelectedIndex++;
        }

        private void tbclistagemendereco_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcendereco.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmendereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
