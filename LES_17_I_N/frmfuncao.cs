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
    public partial class frmfuncao : Form
    {
        public frmfuncao()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO FUNCAO"
                                + " VALUES ("
                                + txtfuccodi.Text + ", '"
                                + txtfucnome.Text + "' ,"
                                + "(SELECT CBOCODI FROM CBO WHERE CBONOME = '"
                                + cmbcbonome.SelectedItem.ToString() + "'))";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE FUNCAO"
                    + " SET FUCCODI = " + txtfuccodi.Text + ", "
                    + " FUCNOME = '" + txtfucnome.Text + "', "
                    + " CBOCODI = (SELECT C.CBOCODI FROM CBO C WHERE C.CBONOME = '"
                                  + cmbcbonome.SelectedItem.ToString() + "')"
                    + " WHERE FUCCODI = '" + txtfuccodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM FUNCAO WHERE FUCCODI = " + txtfuccodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
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

        private void limpar()
        {
            txtfuccodi.Clear();
            txtfucnome.Clear();
            cmbcbonome.SelectedIndex = -1;
            txtfuccodi.Focus();
        }

        private void frmcbo_Load(object sender, EventArgs e)
        {
            carregaCBO();
            DgvDados();
        }

        private void carregaCBO()
        {
            string strFuncao = "SELECT CBONOME FROM CBO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strFuncao, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbcbonome.Items.Add(dr["CBONOME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void selecionaFuncao(string FucNome)
        {
            cmbcbonome.SelectedIndex = 0;
            while (!cmbcbonome.SelectedItem.ToString().Equals(FucNome))
                cmbcbonome.SelectedIndex++;
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadoscbo = "SELECT F.FUCCODI, F.FUCNOME, C.CBONOME"
                                      + " FROM FUNCAO F "
                                      + " LEFT JOIN CBO C ON F.CBOCODI = C.CBOCODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadoscbo, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvfuncao.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void txtfuccodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtfuccodi.Text != "")
            {

                string strConsulta = "SELECT F.FUCCODI, F.FUCNOME, C.CBONOME"
                                      + " FROM FUNCAO F "
                                      + " LEFT JOIN CBO C ON F.CBOCODI = C.CBOCODI"
                                      + " WHERE F.FUCCODI = " + txtfuccodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaCBO(dr);
                        txtfucnome.Focus();
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
                            txtfucnome.Text = "";
                            txtfucnome.Focus();
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

        private void dgvfuncao_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvfuncao.RowCount > 0 && dgvfuncao.SelectedRows.Count == 1)
            {
                int funCodigo = Convert.ToInt32(dgvfuncao.SelectedRows[0].Cells[CODIGO.Name].Value);
                string sql = "SELECT F.FUCCODI, F.FUCNOME, C.CBONOME"
                                      + " FROM FUNCAO F "
                                      + " LEFT JOIN CBO C ON F.CBOCODI = C.CBOCODI"
                                      + " WHERE F.FUCCODI = " + funCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtfuccodi.Text = dr["FUCCODI"].ToString();
                        txtfucnome.Text = dr["FUCNOME"].ToString();
                        selecionaFuncao(dr["CBONOME"].ToString()); //para a minha implementação

                        tbcfuncao.SelectedIndex = 1;
                        txtfuccodi.Focus();
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

        private void ConsultaCBO(FbDataReader dr)
        {
            txtfuccodi.Text = dr["FUCCODI"].ToString();
            txtfucnome.Text = dr["FUCNOME"].ToString();
            cmbcbonome.SelectedIndex = 0;
            while (!cmbcbonome.SelectedItem.ToString().Equals(dr["CBONOME"].ToString()))
                cmbcbonome.SelectedIndex++;
        }

        private void tbclistagemcbo_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcfuncao.SelectedIndex == 0)//tbclistagemFuncao.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmcbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
