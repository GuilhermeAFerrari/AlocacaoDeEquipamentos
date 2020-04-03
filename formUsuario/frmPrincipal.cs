using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formUsuario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
            
        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlocacaoEquipamentoAluno frmAEA = new frmAlocacaoEquipamentoAluno();
            frmAEA.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frmA = new frmAluno();
            frmA.Show();
            //this.Close();
        }

        private void equipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipamento frmE = new frmEquipamento();
            frmE.Show();
        }

        private void equipamentossCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioAlocacaoServidor frmRES = new frmRelatorioAlocacaoServidor();
            frmRES.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja realizar logoff? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formLogin frmLogin = new formLogin();
                frmLogin.Show();
            }
        }

        private void alocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equipamentosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioEquipamentos frmRequipamentos = new frmRelatorioEquipamentos();
            frmRequipamentos.Show();
        }

        private void usuáriosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuarios frmRU = new frmRelatorioUsuarios();
            frmRU.Show();
        }

        private void alocaçõesAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioAlocacaoAluno frmRAA = new frmRelatorioAlocacaoAluno();
            frmRAA.Show();
        }

        private void servidoresCadastradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatoriosServidores frmRS = new frmRelatoriosServidores();
            frmRS.Show();
        }

        private void alunosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioAlunos frmRA = new frmRelatorioAlunos();
            frmRA.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmU = new frmUsuario();
            frmU.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlocacaoEquipamentoServidor frmAES = new frmAlocacaoEquipamentoServidor();
            frmAES.Show();
        }

        private void servidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServidor frmS = new frmServidor();
            frmS.Show();
        }
    }
}
