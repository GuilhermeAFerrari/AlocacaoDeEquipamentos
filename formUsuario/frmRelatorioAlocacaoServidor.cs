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
    public partial class frmRelatorioAlocacaoServidor : Form
    {
        public frmRelatorioAlocacaoServidor()
        {
            InitializeComponent();
        }

        private void frmRelatorioAlocacaoServidor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet1.AlocacaoServidor' table. You can move, or remove it, as needed.
            this.AlocacaoServidorTableAdapter.Fill(this.gjmBancoDataSet1.AlocacaoServidor);

            this.reportViewer1.RefreshReport();
        }
    }
}
