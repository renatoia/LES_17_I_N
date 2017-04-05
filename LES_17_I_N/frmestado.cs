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
    public partial class frmestado : Form
    {
        public frmestado()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO ESTADO"
                       + " VALUES ("
                       + txtestcodi.Text + ", '"
                       + txtestuf.Text + "', '"
                       + txtestnome.Text + "' ,"
                       + txtesticms.Text + ", "
                       + "(SELECT PAICODI FROM PAIS WHERE PAINOME = '" + cmbpainome.SelectedItem.ToString() + "')"
                       + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click_1(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE ESTADO"
                                + " SET ESTCODI = " + txtestcodi.Text + ", "
                                + " ESTUF = '" + txtestuf.Text + "', "
                                + " ESTNOME = '" + txtestnome.Text + "', "
                                + " ESTICMS = " + txtesticms.Text + ", "
                                + " PAICODI = (SELECT P.PAICODI FROM PAIS P WHERE P.PAINOME = '"
                                              + cmbpainome.SelectedItem.ToString() + "')"
                                + " WHERE ESTCODI = '" + txtestcodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM ESTADO WHERE ESTCODI = " + txtestcodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();//tabPage1.Show();
        }
        private void limpar()
        {
            txtestcodi.Clear();
            txtestnome.Clear();
            txtestuf.Clear();
            cmbpainome.SelectedIndex = -1;
            txtestcodi.Focus();
        }

        private void frmestado_Load(object sender, EventArgs e)
        {
            carregaPaises();
            DgvDados();
        }

        private void carregaPaises()
        {
            string strPais = "SELECT PAINOME FROM PAIS";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strPais, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbpainome.Items.Add(dr["PAINOME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void selecionaPais(string PaiNome)
        {
            cmbpainome.SelectedIndex = 0;
            while (!cmbpainome.SelectedItem.ToString().Equals(PaiNome))
                cmbpainome.SelectedIndex++;
        }

        private void selecionarPais(string PaiNome)
        {
            int i = 0;
            for (i = 0; i < this.cmbpainome.Items.Count; i++)
            {
                this.cmbpainome.SelectedIndex = i;
                if (this.cmbpainome.SelectedItem.ToString().Contains(PaiNome))
                {
                    return;
                }
            }
        }

        //Procedimento informado pelo professor, como utiliza o dicionario, se for utiliza-lo terá 
        // que alterar a forma como preenche o combobox no double_click
        private void carregarPaises()
        {
            this.cmbpainome.Items.Clear();

            string s = "Select * from Pais";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["painome"].ToString(), Convert.ToInt32(r["paicodi"]));
            }
            this.cmbpainome.DataSource = new BindingSource(p, null);
            this.cmbpainome.DisplayMember = "key";
            this.cmbpainome.ValueMember = "value";
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadosestado = "SELECT E.ESTCODI, E.ESTUF, E.ESTNOME, E.ESTICMS, P.PAINOME"
                                      + " FROM ESTADO E "
                                      + " LEFT JOIN PAIS P ON P.PAICODI = E.PAICODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosestado, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvestado.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void txtestcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtestcodi.Text != "")
            {

                string strConsulta = "SELECT E.ESTCODI, E.ESTUF, E.ESTNOME, E.ESTICMS, P.PAINOME"
                                      + " FROM ESTADO E "
                                      + " LEFT JOIN PAIS P ON P.PAICODI = E.PAICODI"
                                      + " WHERE E.ESTCODI = " + txtestcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaEstado(dr);
                        //ConsultarEstado(dr);//código do professor
                        txtestnome.Focus();
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
                            txtestnome.Text = "";
                            txtestnome.Focus();
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

        private void dgvestado_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvestado.RowCount > 0 && dgvestado.SelectedRows.Count == 1)
            {
                int estCodigo = Convert.ToInt32(dgvestado.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT E.ESTCODI, E.ESTUF, E.ESTNOME, E.ESTICMS, P.PAINOME"
                                      + " FROM ESTADO E "
                                      + " LEFT JOIN PAIS P ON P.PAICODI = E.PAICODI"
                                      + " WHERE E.ESTCODI = " + estCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtestcodi.Text = dr["ESTCODI"].ToString();
                        txtestuf.Text = dr["ESTUF"].ToString();
                        txtestnome.Text = dr["ESTNOME"].ToString();
                        txtesticms.Text = dr["ESTICMS"].ToString();

                        /*//Alterado para funcionar com o código do Professor
                        cmbpainome.SelectedIndex = 0;
                        while (!cmbpainome.SelectedItem.ToString().Equals(dr["PAINOME"].ToString()))
                            cmbpainome.SelectedIndex++;
                        */

                        //selecionarPais(dr["PAINOME"].ToString());//código professor
                        selecionaPais(dr["PAINOME"].ToString()); //para a minha implementação

                        tbcestado.SelectedIndex = 1;
                        txtestcodi.Focus();
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


        private void ConsultaEstado(FbDataReader dr)
        {
            txtestcodi.Text = dr["ESTCODI"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();
            txtesticms.Text = dr["ESTICMS"].ToString();
            cmbpainome.SelectedIndex = 0;
            while (!cmbpainome.SelectedItem.ToString().Equals(dr["PAINOME"].ToString()))
                cmbpainome.SelectedIndex++;
        }

        private void ConsultarEstado(FbDataReader dr)
        {
            txtestcodi.Text = dr["ESTCODI"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();
            txtesticms.Text = dr["ESTICMS"].ToString();
            cmbpainome.SelectedIndex = 0;
            selecionarPais(dr["PAINOME"].ToString());
        }

        private void tbclistagemestado_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcestado.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
