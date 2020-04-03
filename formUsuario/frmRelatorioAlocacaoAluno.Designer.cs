namespace formUsuario
{
    partial class frmRelatorioAlocacaoAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioAlocacaoAluno));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlocacaoAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gjmBancoDataSet1 = new formUsuario.gjmBancoDataSet1();
            this.AlocacaoAlunoTableAdapter = new formUsuario.gjmBancoDataSet1TableAdapters.AlocacaoAlunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AlocacaoAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlocacaoAlunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "formUsuario.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlocacaoAlunoBindingSource
            // 
            this.AlocacaoAlunoBindingSource.DataMember = "AlocacaoAluno";
            this.AlocacaoAlunoBindingSource.DataSource = this.gjmBancoDataSet1;
            // 
            // gjmBancoDataSet1
            // 
            this.gjmBancoDataSet1.DataSetName = "gjmBancoDataSet1";
            this.gjmBancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlocacaoAlunoTableAdapter
            // 
            this.AlocacaoAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioAlocacaoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioAlocacaoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Alocações de Aluno";
            this.Load += new System.EventHandler(this.frmRelatorioAlocacaoAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlocacaoAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlocacaoAlunoBindingSource;
        private gjmBancoDataSet1 gjmBancoDataSet1;
        private gjmBancoDataSet1TableAdapters.AlocacaoAlunoTableAdapter AlocacaoAlunoTableAdapter;
    }
}