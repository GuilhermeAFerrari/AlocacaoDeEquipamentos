namespace formUsuario
{
    partial class frmRelatoriosServidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatoriosServidores));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gjmBancoDataSet = new formUsuario.gjmBancoDataSet();
            this.servidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servidorTableAdapter = new formUsuario.gjmBancoDataSetTableAdapters.servidorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.servidorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "formUsuario.Report4.rdlc";
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
            // servidorBindingSource
            // 
            this.servidorBindingSource.DataMember = "servidor";
            this.servidorBindingSource.DataSource = this.gjmBancoDataSet;
            // 
            // servidorTableAdapter
            // 
            this.servidorTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatoriosServidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatoriosServidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Servidores Cadastrados";
            this.Load += new System.EventHandler(this.frmRelatoriosServidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource servidorBindingSource;
        private gjmBancoDataSet gjmBancoDataSet;
        private gjmBancoDataSetTableAdapters.servidorTableAdapter servidorTableAdapter;
    }
}