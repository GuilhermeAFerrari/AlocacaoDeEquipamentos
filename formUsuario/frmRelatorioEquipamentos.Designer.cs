namespace formUsuario
{
    partial class frmRelatorioEquipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioEquipamentos));
            this.equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gjmBancoDataSet = new formUsuario.gjmBancoDataSet();
            this.alocacaoEquipamentoAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gjmBanco = new formUsuario.gjmBanco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatoriosTableAdapter = new formUsuario.gjmBancoTableAdapters.RelatoriosTableAdapter();
            this.alocacaoEquipamentoAlunoTableAdapter = new formUsuario.gjmBancoDataSetTableAdapters.alocacaoEquipamentoAlunoTableAdapter();
            this.equipamentoTableAdapter = new formUsuario.gjmBancoDataSetTableAdapters.equipamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocacaoEquipamentoAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // equipamentoBindingSource
            // 
            this.equipamentoBindingSource.DataMember = "equipamento";
            this.equipamentoBindingSource.DataSource = this.gjmBancoDataSet;
            // 
            // gjmBancoDataSet
            // 
            this.gjmBancoDataSet.DataSetName = "gjmBancoDataSet";
            this.gjmBancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alocacaoEquipamentoAlunoBindingSource
            // 
            this.alocacaoEquipamentoAlunoBindingSource.DataMember = "alocacaoEquipamentoAluno";
            this.alocacaoEquipamentoAlunoBindingSource.DataSource = this.gjmBancoDataSet;
            // 
            // RelatoriosBindingSource
            // 
            this.RelatoriosBindingSource.DataMember = "Relatorios";
            this.RelatoriosBindingSource.DataSource = this.gjmBanco;
            // 
            // gjmBanco
            // 
            this.gjmBanco.DataSetName = "gjmBanco";
            this.gjmBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.equipamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "formUsuario.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 681);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // RelatoriosTableAdapter
            // 
            this.RelatoriosTableAdapter.ClearBeforeFill = true;
            // 
            // alocacaoEquipamentoAlunoTableAdapter
            // 
            this.alocacaoEquipamentoAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // equipamentoTableAdapter
            // 
            this.equipamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioEquipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Equipamentos Cadastrados";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocacaoEquipamentoAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RelatoriosBindingSource;
        private gjmBanco gjmBanco;
        private gjmBancoTableAdapters.RelatoriosTableAdapter RelatoriosTableAdapter;
        private System.Windows.Forms.BindingSource alocacaoEquipamentoAlunoBindingSource;
        private gjmBancoDataSet gjmBancoDataSet;
        private gjmBancoDataSetTableAdapters.alocacaoEquipamentoAlunoTableAdapter alocacaoEquipamentoAlunoTableAdapter;
        private System.Windows.Forms.BindingSource equipamentoBindingSource;
        private gjmBancoDataSetTableAdapters.equipamentoTableAdapter equipamentoTableAdapter;
    }
}