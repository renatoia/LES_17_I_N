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
    public partial class frmcbo : Form
    {
        public frmcbo()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO CBO"
           + " VALUES ("
           + txtcbocodi.Text + ", '"
           + txtcbonome.Text + "' ,"
           + "(SELECT FUCCODI FROM FUNCAO WHERE FUCNOME = '" + cmbfucnome.SelectedItem.ToString() + "')"
           + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE CBO"
                    + " SET CBOCODI = " + txtcbocodi.Text + ", "
                    + " CBONOME = '" + txtcbonome.Text + "', "
                    + " FUCCODI = (SELECT F.FUCCODI FROM FUNCAO F WHERE F.FUCNOME = '"
                                  + cmbfucnome.SelectedItem.ToString() + "')"
                    + " WHERE CBOCODI = '" + txtcbocodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM CBO WHERE CBOCODI = " + txtcbocodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
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
            txtcbocodi.Clear();
            txtcbonome.Clear();
            cmbfucnome.SelectedIndex = -1;
            txtcbocodi.Focus();
        }

        private void frmcbo_Load(object sender, EventArgs e)
        {
            carregaFuncao();
            DgvDados();
        }

        private void carregaFuncao()
        {
            string strFuncao = "SELECT FUCNOME FROM FUNCAO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strFuncao, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbfucnome.Items.Add(dr["FUCNOME"].ToString());
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
            cmbfucnome.SelectedIndex = 0;
            while (!cmbfucnome.SelectedItem.ToString().Equals(FucNome))
                cmbfucnome.SelectedIndex++;
        }

        //Procedimento informado pelo professor, como utiliza o dicionario, se for utiliza-lo terá 
        // que alterar a forma como preenche o combobox no double_click
        private void carregarFuncao()
        {
            this.cmbfucnome.Items.Clear();

            string s = "Select * from FUNCAO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["fucnome"].ToString(), Convert.ToInt32(r["fuccodi"]));
            }
            this.cmbfucnome.DataSource = new BindingSource(p, null);
            this.cmbfucnome.DisplayMember = "key";
            this.cmbfucnome.ValueMember = "value";
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadoscbo = "SELECT C.CBOCODI, C.CBONOME, F.FUCNOME"
                                      + " FROM CBO C "
                                      + " LEFT JOIN FUNCAO F ON F.FUCCODI = C.FUCCODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadoscbo, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvcbo.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void txtcbocodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtcbocodi.Text != "")
            {

                string strConsulta = "SELECT C.CBOCODI, C.CBONOME, F.FUCNOME"
                                      + " FROM CBO C "
                                      + " LEFT JOIN FUNCAO F ON F.FUCCODI = C.FUCCODI"
                                      + " WHERE C.CBOCODI = " + txtcbocodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaCBO(dr);
                        txtcbonome.Focus();
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
                            txtcbonome.Text = "";
                            txtcbonome.Focus();
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

        private void dgvcbo_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvcbo.RowCount > 0 && dgvcbo.SelectedRows.Count == 1)
            {
                int estCodigo = Convert.ToInt32(dgvcbo.SelectedRows[0].Cells[CBOCODI.Name].Value);
                string sql = "SELECT C.CBOCODI, C.CBONOME, F.FUCNOME"
                                      + " FROM CBO C "
                                      + " LEFT JOIN FUNCAO F ON F.FUCCODI = C.FUCCODI"
                                      + " WHERE C.CBOCODI = " + estCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcbocodi.Text = dr["CBOCODI"].ToString();
                        txtcbonome.Text = dr["CBONOME"].ToString();
                        selecionaFuncao(dr["FUCNOME"].ToString()); //para a minha implementação

                        tbccbo.SelectedIndex = 1;
                        txtcbocodi.Focus();
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
            txtcbocodi.Text = dr["CBOCODI"].ToString();
            txtcbonome.Text = dr["CBONOME"].ToString();
            cmbfucnome.SelectedIndex = 0;
            while (!cmbfucnome.SelectedItem.ToString().Equals(dr["FUCNOME"].ToString()))
                cmbfucnome.SelectedIndex++;
        }

        private void tbclistagemcbo_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbccbo.SelectedIndex == 0)//tbclistagemFuncao.SelectedTab == tbplistagem
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
