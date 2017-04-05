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
    public partial class frmhorario : Form
    {
        public frmhorario()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO HORARIO"
                              + " VALUES ("
                              + txthorcodi.Text + ", '"
                              + txthornome.Text + "', '"
                              + txthormane.Text + "', '"
                              + txthormans.Text + "', '"
                              + txthortare.Text + "', '"
                              + txthortars.Text + "', "
                              + "(SELECT THOCODI FROM TIPOHORARIO WHERE THONOME = '"
                              + cmbthonome.SelectedItem.ToString() + "')"
                              + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txthorcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE HORARIO"
                                + " SET HORCODI = " + txthorcodi.Text + ", "
                                + " HORNOME = '" + txthornome.Text + "', "
                                + " HORMANE = '" + txthormane.Text + "', '"
                                + " HORMANS = '" + txthormans.Text + "', '"
                                + " HORTARE = '" + txthortare.Text + "', '"
                                + " HORTARS = '" + txthortars.Text + "', '"
                                + " THOCODI = (SELECT T.THOCODI FROM TIPOHORARIO T WHERE T.THONOME = '"
                                + cmbthonome.SelectedItem.ToString() + "')"
                                + " WHERE HORCODI = " + txthorcodi.Text + " ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txthorcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM HORARIO WHERE HORCODI = " + txthorcodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txthorcodi.Focus();
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
            txthorcodi.Clear();
            txthornome.Clear();
            txthormane.Clear();
            txthormans.Clear();
            txthortare.Clear();
            txthortars.Clear();
            cmbthonome.SelectedIndex = -1;
            txthorcodi.Focus();
        }

        private void frmhorario_Load(object sender, EventArgs e)
        {
            carregaTipoHorario();
            DgvDados();
        }

        private void carregaTipoHorario()
        {
            string strHorario = "SELECT THONOME FROM TIPOHORARIO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strHorario, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbthonome.Items.Add(dr["THONOME"].ToString());
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
                string dadoshorario = "SELECT H.HORCODI, H.HORNOME, H.HORMANE, H.HORMANS,"
                                      + " H.HORTARE, H.HORTARS, T.THONOME"
                                      + " FROM HORARIO H "
                                      + " LEFT JOIN TIPOHORARIO T ON T.THOCODI = H.THOCODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadoshorario, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvhorario.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void tbclistagemhorario1_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbchorario1.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void txthorcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txthorcodi.Text != "")
            {

                string strConsulta = "SELECT H.HORCODI, H.HORNOME, H.HORMANE, H.HORMANS,"
                                      + " H.HORTARE, H.HORTARS, T.THONOME"
                                      + " FROM HORARIO H "
                                      + " LEFT JOIN TIPOHORARIO T ON T.THOCODI = H.THOCODI"
                                      + " WHERE H.HORCODI = " + txthorcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaHorario(dr);
                        txthornome.Focus();
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
                            txthornome.Text = "";
                            txthornome.Focus();
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
        private void ConsultaHorario(FbDataReader dr)
        {
            txthorcodi.Text = dr["HORCODI"].ToString();
            txthornome.Text = dr["HORNOME"].ToString();
            txthormane.Text = dr["HORMANE"].ToString();
            txthormans.Text = dr["HORMANS"].ToString();
            txthortare.Text = dr["HORTARE"].ToString();
            txthortars.Text = dr["HORTARS"].ToString();
            cmbthonome.SelectedIndex = 0;
            while (!cmbthonome.SelectedItem.ToString().Equals(dr["THONOME"].ToString()))
                cmbthonome.SelectedIndex++;
        }

        private void dgvestado_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvhorario.RowCount > 0 && dgvhorario.SelectedRows.Count == 1)
            {
                int horCodigo = Convert.ToInt32(dgvhorario.SelectedRows[0].Cells[horcodi.Name].Value);
                string sql = "SELECT H.HORCODI, H.HORNOME, H.HORMANE, H.HORMANS,  H.HORTARE, H.HORTARS, T.THONOME"
                                      + " FROM HORARIO H "
                                      + " LEFT JOIN TIPOHORARIO T ON T.THOCODI = H.THOCODI"
                                      + " WHERE H.HORCODI = " + horCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txthorcodi.Text = dr["HORCODI"].ToString();
                        txthornome.Text = dr["HORNOME"].ToString();
                        txthormane.Text = dr["HORMANE"].ToString();
                        txthormans.Text = dr["HORMANS"].ToString();
                        txthortare.Text = dr["HORTARE"].ToString();
                        txthortars.Text = dr["HORTARS"].ToString();
                        selecionaTipoHorario(dr["THONOME"].ToString());


                        tbchorario1.SelectedIndex = 1;
                        txthorcodi.Focus();
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

        private void selecionaTipoHorario(string ThoNome)
        {
            cmbthonome.SelectedIndex = 0;
            while (!cmbthonome.SelectedItem.ToString().Equals(ThoNome))
                cmbthonome.SelectedIndex++;
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
