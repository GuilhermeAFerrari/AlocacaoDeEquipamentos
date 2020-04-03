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
    public partial class frmRelatoriosServidores : Form
    {
        public frmRelatoriosServidores()
        {
            InitializeComponent();
        }

        private void frmRelatoriosServidores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet.servidor' table. You can move, or remove it, as needed.
            this.servidorTableAdapter.Fill(this.gjmBancoDataSet.servidor);

            this.reportViewer1.RefreshReport();
        }
    }
}
