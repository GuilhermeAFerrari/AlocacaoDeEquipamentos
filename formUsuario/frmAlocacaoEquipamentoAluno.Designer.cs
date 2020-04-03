namespace formUsuario
{
    partial class frmAlocacaoEquipamentoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlocacaoEquipamentoAluno));
            this.gjmBanco = new formUsuario.gjmBanco();
            this.gjmBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNova = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxLocacao = new System.Windows.Forms.GroupBox();
            this.cmbEntrega = new System.Windows.Forms.ComboBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.cmbRecebimento = new System.Windows.Forms.ComboBox();
            this.txtResponsavelDevolucao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.lblValorLoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlocar = new System.Windows.Forms.Button();
            this.cbxEquipamento = new System.Windows.Forms.ComboBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.txtIdAlocacao = new System.Windows.Forms.TextBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.lstAlocacao = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoBindingSource)).BeginInit();
            this.gbxLocacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gjmBanco
            // 
            this.gjmBanco.DataSetName = "gjmBanco";
            this.gjmBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gjmBancoBindingSource
            // 
            this.gjmBancoBindingSource.DataSource = this.gjmBanco;
            this.gjmBancoBindingSource.Position = 0;
            // 
            // btnNova
            // 
            this.btnNova.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNova.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNova.Location = new System.Drawing.Point(353, 321);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(189, 47);
            this.btnNova.TabIndex = 11;
            this.btnNova.Text = "&Nova Locação";
            this.btnNova.UseVisualStyleBackColor = false;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(569, 321);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 46);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbxLocacao
            // 
            this.gbxLocacao.Controls.Add(this.cmbEntrega);
            this.gbxLocacao.Controls.Add(this.btnDevolver);
            this.gbxLocacao.Controls.Add(this.cmbRecebimento);
            this.gbxLocacao.Controls.Add(this.txtResponsavelDevolucao);
            this.gbxLocacao.Controls.Add(this.label8);
            this.gbxLocacao.Controls.Add(this.label7);
            this.gbxLocacao.Controls.Add(this.label6);
            this.gbxLocacao.Controls.Add(this.cbxAluno);
            this.gbxLocacao.Controls.Add(this.lblValorLoc);
            this.gbxLocacao.Controls.Add(this.label5);
            this.gbxLocacao.Controls.Add(this.label4);
            this.gbxLocacao.Controls.Add(this.label3);
            this.gbxLocacao.Controls.Add(this.label2);
            this.gbxLocacao.Controls.Add(this.label1);
            this.gbxLocacao.Controls.Add(this.btnAlocar);
            this.gbxLocacao.Controls.Add(this.cbxEquipamento);
            this.gbxLocacao.Controls.Add(this.dtpDevolucao);
            this.gbxLocacao.Controls.Add(this.dtpLocacao);
            this.gbxLocacao.Controls.Add(this.txtIdAlocacao);
            this.gbxLocacao.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLocacao.Location = new System.Drawing.Point(12, 12);
            this.gbxLocacao.Name = "gbxLocacao";
            this.gbxLocacao.Size = new System.Drawing.Size(930, 297);
            this.gbxLocacao.TabIndex = 10;
            this.gbxLocacao.TabStop = false;
            this.gbxLocacao.Text = "Dados da Locação";
            this.gbxLocacao.Enter += new System.EventHandler(this.gbxLocacao_Enter);
            // 
            // cmbEntrega
            // 
            this.cmbEntrega.FormattingEnabled = true;
            this.cmbEntrega.Location = new System.Drawing.Point(628, 169);
            this.cmbEntrega.Name = "cmbEntrega";
            this.cmbEntrega.Size = new System.Drawing.Size(283, 37);
            this.cmbEntrega.TabIndex = 5;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDevolver.Location = new System.Drawing.Point(15, 219);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(140, 50);
            this.btnDevolver.TabIndex = 7;
            this.btnDevolver.Text = "&Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // cmbRecebimento
            // 
            this.cmbRecebimento.FormattingEnabled = true;
            this.cmbRecebimento.Location = new System.Drawing.Point(628, 114);
            this.cmbRecebimento.Name = "cmbRecebimento";
            this.cmbRecebimento.Size = new System.Drawing.Size(283, 37);
            this.cmbRecebimento.TabIndex = 8;
            // 
            // txtResponsavelDevolucao
            // 
            this.txtResponsavelDevolucao.Location = new System.Drawing.Point(628, 219);
            this.txtResponsavelDevolucao.Name = "txtResponsavelDevolucao";
            this.txtResponsavelDevolucao.Size = new System.Drawing.Size(283, 35);
            this.txtResponsavelDevolucao.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Responsável Devolução";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Visto de Recebimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Visto de Entrega";
            // 
            // cbxAluno
            // 
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(168, 100);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(157, 37);
            this.cbxAluno.TabIndex = 3;
            this.cbxAluno.SelectedIndexChanged += new System.EventHandler(this.cbxAluno_SelectedIndexChanged);
            this.cbxAluno.Leave += new System.EventHandler(this.cbxAluno_Leave);
            // 
            // lblValorLoc
            // 
            this.lblValorLoc.AutoSize = true;
            this.lblValorLoc.Location = new System.Drawing.Point(107, 190);
            this.lblValorLoc.Name = "lblValorLoc";
            this.lblValorLoc.Size = new System.Drawing.Size(0, 29);
            this.lblValorLoc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Equipamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Devolução";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Locação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Locação";
            // 
            // btnAlocar
            // 
            this.btnAlocar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlocar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlocar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlocar.Location = new System.Drawing.Point(185, 219);
            this.btnAlocar.Name = "btnAlocar";
            this.btnAlocar.Size = new System.Drawing.Size(140, 50);
            this.btnAlocar.TabIndex = 6;
            this.btnAlocar.Text = "&Alocar";
            this.btnAlocar.UseVisualStyleBackColor = false;
            this.btnAlocar.Click += new System.EventHandler(this.btnAlocar_Click);
            // 
            // cbxEquipamento
            // 
            this.cbxEquipamento.FormattingEnabled = true;
            this.cbxEquipamento.Location = new System.Drawing.Point(168, 155);
            this.cbxEquipamento.Name = "cbxEquipamento";
            this.cbxEquipamento.Size = new System.Drawing.Size(157, 37);
            this.cbxEquipamento.TabIndex = 4;
            this.cbxEquipamento.SelectedIndexChanged += new System.EventHandler(this.cbxEquipamento_SelectedIndexChanged);
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(773, 47);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(139, 35);
            this.dtpDevolucao.TabIndex = 2;
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocacao.Location = new System.Drawing.Point(446, 47);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(130, 35);
            this.dtpLocacao.TabIndex = 1;
            // 
            // txtIdAlocacao
            // 
            this.txtIdAlocacao.Location = new System.Drawing.Point(168, 47);
            this.txtIdAlocacao.Name = "txtIdAlocacao";
            this.txtIdAlocacao.Size = new System.Drawing.Size(83, 35);
            this.txtIdAlocacao.TabIndex = 0;
            this.txtIdAlocacao.TextChanged += new System.EventHandler(this.txtIdAlocacao_TextChanged);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucao.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDevolucao.Location = new System.Drawing.Point(178, 321);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(150, 46);
            this.btnDevolucao.TabIndex = 10;
            this.btnDevolucao.Text = "&Devolução";
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // lstAlocacao
            // 
            this.lstAlocacao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlocacao.FormattingEnabled = true;
            this.lstAlocacao.ItemHeight = 23;
            this.lstAlocacao.Location = new System.Drawing.Point(23, 392);
            this.lstAlocacao.Name = "lstAlocacao";
            this.lstAlocacao.Size = new System.Drawing.Size(929, 234);
            this.lstAlocacao.TabIndex = 16;
            this.lstAlocacao.SelectedIndexChanged += new System.EventHandler(this.lstAlocacao_SelectedIndexChanged_1);
            // 
            // frmAlocacaoEquipamentoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.lstAlocacao);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbxLocacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlocacaoEquipamentoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno - Alocar Equipamento";
            ((System.ComponentModel.ISupportInitialize)(this.gjmBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gjmBancoBindingSource)).EndInit();
            this.gbxLocacao.ResumeLayout(false);
            this.gbxLocacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource gjmBancoBindingSource;
        private gjmBanco gjmBanco;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbxLocacao;
        private System.Windows.Forms.Label lblValorLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlocar;
        private System.Windows.Forms.ComboBox cbxEquipamento;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.TextBox txtIdAlocacao;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.TextBox txtResponsavelDevolucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ListBox lstAlocacao;
        private System.Windows.Forms.ComboBox cmbEntrega;
        private System.Windows.Forms.ComboBox cmbRecebimento;

    }
}