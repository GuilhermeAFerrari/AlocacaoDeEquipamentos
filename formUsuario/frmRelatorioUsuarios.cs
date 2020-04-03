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
    public partial class frmRelatorioUsuarios : Form
    {
        public frmRelatorioUsuarios()
        {
            InitializeComponent();
        }

        private void frmRelatorioUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.gjmBancoDataSet.usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
