﻿using System;
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
    public partial class frmRelatorioAlocacaoAluno : Form
    {
        public frmRelatorioAlocacaoAluno()
        {
            InitializeComponent();
        }

        private void frmRelatorioAlocacaoAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gjmBancoDataSet1.AlocacaoAluno' table. You can move, or remove it, as needed.
            this.AlocacaoAlunoTableAdapter.Fill(this.gjmBancoDataSet1.AlocacaoAluno);

            this.reportViewer1.RefreshReport();
        }
    }
}
