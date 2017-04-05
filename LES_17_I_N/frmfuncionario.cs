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
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO FUNCIONARIO"
                               + " VALUES ("
                               + txtfuncodi.Text + ", '"
                               + txtfunnome.Text + "', "
                               + txtfunsala.Text.Replace(',' , '.') + ", '"
                               + dtpdtna.Value.Date.ToString("dd/MM/yyyy").Replace('/', '.') + "', '"
                               + txtfuncpf.Text + "', '"
                               + txtfunrg.Text + "', '"
                               + txtfunfone.Text + "', '"
                               + txtfuncelu.Text + "', '"
                               + txtfuncel1.Text + "', "
                               + txtfunnume.Text + ", "
                               + txtendcep.Text + ", "

                               + "(SELECT F.FUCCODI FROM FUNCAO F WHERE F.FUCNOME = '"
                               + cmbfucnome.SelectedItem.ToString() + "'), "

                               + "(SELECT H.HORCODI FROM HORARIO H WHERE H.HORNOME = '"
                               + cmbhornome.SelectedItem.ToString() + "'), "

                               + "(SELECT D.DEPCODI FROM DEPTO D WHERE D.DEPNOME = '"
                               + cmbdepnome.SelectedItem.ToString() + "') "

                               + ")";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtfuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE FUNCIONARIO SET "
                               + " FUNCODI = " + txtfuncodi.Text + ","
                               + " FUNNOME = '" + txtfunnome.Text + "' ,"
                               + " FUNSALA = " + txtfunsala.Text.Replace(',', '.') + ","
                               + " FUNDTNA = '" + dtpdtna.Value.Date.ToString("dd/MM/yyyy").Replace('/', '.') + "',"
                               + " FUNCPF = '" + txtfuncpf.Text + "',"
                               + " FUNRG = '" + txtfunrg.Text + "',"
                               + " FUNFONE = '" + txtfunfone.Text + "',"
                               + " FUNCELU = '" + txtfuncelu.Text + "',"
                               + " FUNCEL1 = '" + txtfuncel1.Text + "',"
                               + " ENDCEP = " + txtendcep.Text + ","
                               + " FUNNUME = " + txtfunnume.Text + ","

                               + " FUCCODI = (SELECT F.FUCCODI FROM FUNCAO F WHERE F.FUCNOME = '"
                               + cmbfucnome.SelectedItem.ToString() + "'), "

                               + " HORCODI = (SELECT H.HORCODI FROM HORARIO H WHERE H.HORNOME = '"
                               + cmbhornome.SelectedItem.ToString() + "'), "

                               + " DEPCODI = (SELECT D.DEPCODI FROM DEPTO D WHERE D.DEPNOME = '"
                               + cmbdepnome.SelectedItem.ToString() + "') "

                               + " WHERE FUNCODI = " + txtfuncodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtfuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM FUNCIONARIO WHERE FUNCODI = " + txtfuncodi.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtfuncodi.Focus();
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
            txtfuncodi.Clear();
            txtfunnome.Clear();
            txtfunsala.Clear();
            dtpdtna.Value = DateTime.Today;
            txtfuncpf.Clear();
            txtfunrg.Clear();
            txtfunfone.Clear();
            txtfuncelu.Clear();
            txtfuncel1.Clear();
            txtendcep.Clear();
            txtfunnume.Clear();
            cmbfucnome.SelectedIndex = -1;
            cmbhornome.SelectedIndex = -1;
            cmbdepnome.SelectedIndex = -1;

            txtfuncodi.Focus();
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {
            carregaFuncao();
            carregaHorario();
            carregaDepto();
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

        private void carregaHorario()
        {
            string strHorario = "SELECT HORNOME FROM HORARIO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strHorario, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbhornome.Items.Add(dr["HORNOME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void carregaDepto()
        {
            string strDepto = "SELECT DEPNOME FROM DEPTO";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDepto, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbdepnome.Items.Add(dr["DEPNOME"].ToString());
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

        private void selecionaHorario(string HorNome)
        {
            cmbhornome.SelectedIndex = 0;
            while (!cmbhornome.SelectedItem.ToString().Equals(HorNome))
                cmbhornome.SelectedIndex++;
        }

        private void selecionaDepto(string DepNome)
        {
            cmbdepnome.SelectedIndex = 0;
            while (!cmbdepnome.SelectedItem.ToString().Equals(DepNome))
                cmbdepnome.SelectedIndex++;
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                string dadosFuncionario = "SELECT F.FUNCODI, F.FUNNOME, F.FUNCPF, F.FUNRG, F.FUNDTNA,"
                                      + " F.FUNSALA, D.DEPNOME, FU.FUCNOME, H.HORNOME,"
                                      + " E.ENDENDE, F.FUNNUME, F.ENDCEP, B.BAINOME,"
                                      + " M.MUNNOME, ES.ESTUF, P.PAINOME,"
                                      + " F.FUNFONE, F.FUNCELU, F.FUNCEL1"
                                      + " FROM FUNCIONARIO F "
                                      + " INNER JOIN HORARIO H ON H.HORCODI = F.HORCODI"
                                      + " INNER JOIN DEPTO D ON D.DEPCODI = F.DEPCODI"
                                      + " INNER JOIN FUNCAO FU ON FU.FUCCODI = F.FUCCODI"
                                      + " INNER JOIN ENDERECO E ON E.ENDCEP = F.ENDCEP"
                                      + " INNER JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " INNER JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " INNER JOIN ESTADO ES ON ES.ESTCODI = M.ESTCODI"
                                      + " INNER JOIN PAIS P ON P.PAICODI = ES.PAICODI"
                                      + " ORDER BY F.FUNCODI";

                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(dadosFuncionario, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvfuncionario.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void txtfuncodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtfuncodi.Text != "")
            {

                string strConsulta = "SELECT F.FUNCODI, F.FUNNOME, F.FUNCPF, F.FUNRG, F.FUNDTNA,"
                                      + " F.FUNSALA, D.DEPNOME, FU.FUCNOME, H.HORNOME,"
                                      + " E.ENDENDE, F.FUNNUME, F.ENDCEP, B.BAINOME,"
                                      + " M.MUNNOME, ES.ESTUF, P.PAINOME,"
                                      + " F.FUNFONE, F.FUNCELU, F.FUNCEL1"
                                      + " FROM FUNCIONARIO F "
                                      + " INNER JOIN HORARIO H ON H.HORCODI = F.HORCODI"
                                      + " INNER JOIN DEPTO D ON D.DEPCODI = F.DEPCODI"
                                      + " INNER JOIN FUNCAO FU ON FU.FUCCODI = F.FUNCODI"
                                      + " INNER JOIN ENDERECO E ON E.ENDCEP = F.ENDCEP"
                                      + " INNER JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " INNER JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " INNER JOIN ESTADO ES ON ES.ESTCODI = M.ESTCODI"
                                      + " INNER JOIN PAIS P ON P.PAICODI = ES.PAICODI"
                                      + " WHERE F.FUNCODI = " + txtfuncodi.Text 
                                      + " ORDER BY F.FUNCODI";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaFuncionario(dr);
                        txtfunnome.Focus();
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
                            txtfunnome.Text = "";
                            txtfunnome.Focus();
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

        private void txtendcep_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtendcep.Text != "")
            {

                string strConsulta = "SELECT E.ENDENDE, B.BAINOME,"
                                      + " M.MUNNOME, ES.ESTUF, P.PAINOME"
                                      + " FROM ENDERECO E"
                                      + " INNER JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " INNER JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " INNER JOIN ESTADO ES ON ES.ESTCODI = M.ESTCODI"
                                      + " INNER JOIN PAIS P ON P.PAICODI = ES.PAICODI"
                                      + " WHERE E.ENDCEP = " + txtendcep.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //ConsultaFuncionario(dr);
                        lblendereco.Text = dr["ENDENDE"].ToString();
                        lblbairro.Text = dr["BAINOME"].ToString();
                        lblmunicipio.Text = dr["MUNNOME"].ToString();
                        lbluf.Text = dr["ESTUF"].ToString();
                        lblpais.Text = dr["PAINOME"].ToString();

                        txtfunnume.Focus();
                        btnincluir.Enabled = false;
                    }
                    else
                    {
                        if ((MessageBox.Show("Registro não encontrado. \n Deseja cadastrar?", "Cadastrar de CEP", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                        {
                            
                            lblendereco.Text = " ";
                            lblbairro.Text = " ";
                            lblmunicipio.Text = " ";
                            lbluf.Text = " ";
                            lblpais.Text = " ";
                            txtendcep.Text = " ";
                            frmendereco end = new frmendereco();
                            end.ShowDialog();
                            //limpar();
                        }
                        /*else
                        {
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            txtfunnome.Text = "";
                            txtfunnome.Focus();
                        }*/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void dgvfuncionario_DoubleClick(object sender, EventArgs e)
        { //para alterar um registro do dgv
            /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
            if (dgvfuncionario.RowCount > 0 && dgvfuncionario.SelectedRows.Count == 1)
            {
                int funCodigo = Convert.ToInt32(dgvfuncionario.SelectedRows[0].Cells[FUNCODI.Name].Value);
                string sql = "SELECT F.FUNCODI, F.FUNNOME, F.FUNCPF, F.FUNRG, F.FUNDTNA,"
                                      + " F.FUNSALA, D.DEPNOME, FU.FUCNOME, H.HORNOME,"
                                      + " E.ENDENDE, F.FUNNUME, F.ENDCEP, B.BAINOME,"
                                      + " M.MUNNOME, ES.ESTUF, P.PAINOME,"
                                      + " F.FUNFONE, F.FUNCELU, F.FUNCEL1"
                                      + " FROM FUNCIONARIO F "
                                      + " INNER JOIN HORARIO H ON H.HORCODI = F.HORCODI"
                                      + " INNER JOIN DEPTO D ON D.DEPCODI = F.DEPCODI"
                                      + " INNER JOIN FUNCAO FU ON FU.FUCCODI = F.FUCCODI"
                                      + " INNER JOIN ENDERECO E ON E.ENDCEP = F.ENDCEP"
                                      + " INNER JOIN BAIRRO B ON B.BAICODI = E.BAICODI"
                                      + " INNER JOIN MUNICIPIO M ON M.MUNCODI = B.MUNCODI"
                                      + " INNER JOIN ESTADO ES ON ES.ESTCODI = M.ESTCODI"
                                      + " INNER JOIN PAIS P ON P.PAICODI = ES.PAICODI"
                                      + " WHERE F.FUNCODI = " + funCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaFuncionario(dr);

                        tbcfuncionario.SelectedIndex = 1;
                        txtfunnome.Focus();
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

        private void ConsultaFuncionario(FbDataReader dr)
        {
            txtfuncodi.Text = dr["FUNCODI"].ToString();
            txtfunnome.Text = dr["FUNNOME"].ToString();
            txtfunrg.Text = dr["FUNRG"].ToString();
            txtfuncpf.Text = dr["FUNCPF"].ToString();
            txtdtns.Text = dr["FUNDTNA"].ToString();
            dtpdtna.Value = Convert.ToDateTime(dr["FUNDTNA"].ToString().Replace('.', '/'));
            txtfunsala.Text = dr["FUNSALA"].ToString();
            lblendereco.Text = dr["ENDENDE"].ToString();
            txtfunnume.Text = dr["FUNNUME"].ToString();
            txtendcep.Text = dr["ENDCEP"].ToString();
            lblbairro.Text = dr["BAINOME"].ToString();
            lblmunicipio.Text = dr["MUNNOME"].ToString();
            lbluf.Text = dr["ESTUF"].ToString();
            lblpais.Text = dr["PAINOME"].ToString();
            txtfunfone.Text = dr["FUNFONE"].ToString();
            txtfuncelu.Text = dr["FUNCELU"].ToString();
            txtfuncel1.Text = dr["FUNCEL1"].ToString();


            cmbdepnome.SelectedIndex = 0;
            while (!cmbdepnome.SelectedItem.ToString().Equals(dr["DEPNOME"].ToString()))
                cmbdepnome.SelectedIndex++;

            cmbfucnome.SelectedIndex = 0;
            while (!cmbfucnome.SelectedItem.ToString().Equals(dr["FUCNOME"].ToString()))
                cmbfucnome.SelectedIndex++;

            cmbhornome.SelectedIndex = 0;
            while (!cmbhornome.SelectedItem.ToString().Equals(dr["HORNOME"].ToString()))
                cmbhornome.SelectedIndex++;
        }

        private void tbclistagemfuncionario_Selected(object sender, TabControlEventArgs e)
        { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcfuncionario.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmfuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
