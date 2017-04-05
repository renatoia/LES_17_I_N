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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsobre sobre = new frmsobre();
            sobre.ShowDialog();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpais pais = new frmpais();
            pais.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestado estado = new frmestado();
            estado.ShowDialog();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmendereco endereco = new frmendereco();
            endereco.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbairro bairro = new frmbairro();
            bairro.ShowDialog();
        }

        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmunicipio municipio = new frmmunicipio();
            municipio.ShowDialog();
        }

        private void tipoHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipohorario tipo = new frmtipohorario();
            tipo.ShowDialog();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhorario horario = new frmhorario();
            horario.ShowDialog();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdepto depto = new frmdepto();
            depto.ShowDialog();
        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcbo cbo = new frmcbo();
            cbo.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncao funcao = new frmfuncao();
            funcao.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncionario func = new frmfuncionario();
            func.ShowDialog();
        }
    }
}
