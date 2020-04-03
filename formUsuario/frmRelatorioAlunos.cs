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
    public partial class frmRelatorioAlunos : Form
    {
        public frmRelatorioAlunos()
        {
            InitializeComponent();
        }

        private void frmRelatorioAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.gjmBancoDataSet.aluno);

            this.reportViewer1.RefreshReport();
        }
    }
}
