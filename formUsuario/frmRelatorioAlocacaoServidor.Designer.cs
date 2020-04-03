namespace formUsuario
{
    partial class frmRelatorioAlocacaoServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioAlocacaoServidor));
            this.AlocacaoServidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gjmBancoDataSet1 = new formUsuario.gjmBancoDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlocacaoServidorTableAdapter = new formUsuario.gjmBancoDataSet1TableAdapters.AlocacaoServidorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AlocacaoServidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AlocacaoServidorBindingSource
            // 
            this.AlocacaoServidorBindingSource.DataMember = "AlocacaoServidor";
            this.AlocacaoServidorBindingSource.DataSource = this.gjmBancoDataSet1;
            // 
            // gjmBancoDataSet1
            // 
            this.gjmBancoDataSet1.DataSetName = "gjmBancoDataSet1";
            this.gjmBancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlocacaoServidorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "formUsuario.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlocacaoServidorTableAdapter
            // 
            this.AlocacaoServidorTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioAlocacaoServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioAlocacaoServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Alocações de Servidor";
            this.Load += new System.EventHandler(this.frmRelatorioAlocacaoServidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlocacaoServidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlocacaoServidorBindingSource;
        private gjmBancoDataSet1 gjmBancoDataSet1;
        private gjmBancoDataSet1TableAdapters.AlocacaoServidorTableAdapter AlocacaoServidorTableAdapter;
    }
}