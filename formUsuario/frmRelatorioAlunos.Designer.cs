namespace formUsuario
{
    partial class frmRelatorioAlunos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioAlunos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gjmBancoDataSet = new formUsuario.gjmBancoDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new formUsuario.gjmBancoDataSetTableAdapters.alunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.alunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "formUsuario.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // gjmBancoDataSet
            // 
            this.gjmBancoDataSet.DataSetName = "gjmBancoDataSet";
            this.gjmBancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.gjmBancoDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Alunos Cadastrados";
            this.Load += new System.EventHandler(this.frmRelatorioAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private gjmBancoDataSet gjmBancoDataSet;
        private gjmBancoDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
    }
}