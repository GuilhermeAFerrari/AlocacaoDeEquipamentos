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
    public partial class frmRelatorioEquipamentos : Form
    {
        public frmRelatorioEquipamentos()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet.equipamento' table. You can move, or remove it, as needed.
            this.equipamentoTableAdapter.Fill(this.gjmBancoDataSet.equipamento);
            // TODO: This line of code loads data into the 'gjmBancoDataSet.alocacaoEquipamentoAluno' table. You can move, or remove it, as needed.
            this.alocacaoEquipamentoAlunoTableAdapter.Fill(this.gjmBancoDataSet.alocacaoEquipamentoAluno);
            // TODO: This line of code loads data into the 'gjmBanco.Relatorios' table. You can move, or remove it, as needed.
            this.RelatoriosTableAdapter.Fill(this.gjmBanco.Relatorios);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
