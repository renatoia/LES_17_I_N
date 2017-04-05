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
    public partial class frmpais : Form
    {
        public frmpais()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO PAIS"
                                + " VALUES("
                                + txtpaicodi.Text + ", '"
                                + txtpainome.Text + "' "
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtpaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE PAIS"
                                + " SET PAICODI = " + txtpaicodi.Text + ", "
                                + " PAINOME = '" + txtpainome.Text + "' "
                                + " WHERE PAICODI = '" + txtpaicodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtpaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM PAIS WHERE PAICODI = " + txtpaicodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtpaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void limpar()
        {
            txtpaicodi.Clear();
            txtpainome.Clear();
            txtpaicodi.Focus();
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
        }

        private void ConsultaPais(FbDataReader dr)
        {
            txtpaicodi.Text = dr["PAICODI"].ToString();
            txtpainome.Text = dr["PAINOME"].ToString();
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtpaicodi.Text != "")
            {
                string strConsulta = "SELECT PAICODI, PAINOME FROM PAIS WHERE PAICODI = " + txtpaicodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaPais(dr);
                        txtpainome.Focus();
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
                            txtpainome.Text = "";
                            txtpainome.Focus();
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

        private void frmpais_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void DgvDados()
        { 
            Conexao.Active(true);
            try
            {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM PAIS", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvpais.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }


        private void dgvpais_DoubleClick(object sender, EventArgs e)
        {
            { 
                if (dgvpais.RowCount > 0 && dgvpais.SelectedRows.Count == 1)
                {
                    int paiCodigo = Convert.ToInt32(dgvpais.SelectedRows[0].Cells[Codigo.Name].Value);
                    string sql = "SELECT * FROM PAIS "
                               + "WHERE PAICODI = " + paiCodigo;
                    try
                    {
                        Conexao.Active(true);
                        FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                        FbDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtpaicodi.Text = dr["PAICODI"].ToString();
                            txtpainome.Text = dr["PAINOME"].ToString();
                            tbcpais.SelectedIndex = 1;
                            txtpainome.Focus();
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
        }

        private void tbclistagempais_Selected(object sender, TabControlEventArgs e)
        { 
            if (tbcpais.SelectedIndex == 0)
            { 
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void frmpais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
