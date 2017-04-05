using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmdepto : Form
    {
        public frmdepto()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO DEPTO"
           + " VALUES ("
           + txtdepcodi.Text + ", '"
           + txtdepnome.Text + "')";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE DEPTO"
        + " SET DEPCODI = " + txtdepcodi.Text + ", "
        + " DEPNOME = '" + txtdepnome.Text + "' "
        + " WHERE DEPCODI = " + txtdepcodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void limpar()
        {
            txtdepcodi.Clear();
            txtdepnome.Clear();
            txtdepcodi.Focus();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM DEPTO WHERE DEPCODI = " + txtdepcodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdepcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtdepcodi.Text != "")
            {

                string strConsulta = "SELECT DEPCODI, DEPNOME"
                                      + " FROM DEPTO "
                                      + " WHERE DEPCODI = " + txtdepcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultarDepto(dr);
                        txtdepnome.Focus();
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
                            txtdepnome.Text = "";
                            txtdepnome.Focus();
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

        private void ConsultarDepto(FbDataReader dr)
        {
            txtdepcodi.Text = dr["DEPCODI"].ToString();
            txtdepnome.Text = dr["DEPNOME"].ToString();
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmdepto_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadosdepto = "SELECT DEPCODI, DEPNOME"
                                      + " FROM DEPTO ";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosdepto, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvdepto.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvdepto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvdepto.RowCount > 0 && dgvdepto.SelectedRows.Count == 1)
            {
                int depcodigo = Convert.ToInt32(dgvdepto.SelectedRows[0].Cells[CODIGO.Name].Value);
                string sql = "SELECT DEPCODI, DEPNOME"
                                      + " FROM DEPTO "
                                      + " WHERE DEPCODI = " + depcodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtdepcodi.Text = dr["DEPCODI"].ToString();
                        txtdepnome.Text = dr["DEPNOME"].ToString();

                        tbcdepto.SelectedIndex = 1;
                        txtdepcodi.Focus();
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

        private void tbclistagemdepto_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcdepto.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

    }
}
