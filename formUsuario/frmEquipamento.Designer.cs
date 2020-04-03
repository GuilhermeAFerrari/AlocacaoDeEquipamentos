namespace formUsuario
{
    partial class frmEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipamento));
            this.gbxOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.rdtInativo = new System.Windows.Forms.RadioButton();
            this.rdtAtivo = new System.Windows.Forms.RadioButton();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lstEquipamento = new System.Windows.Forms.ListBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtIdEquipamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.asdasda = new System.Windows.Forms.Label();
            this.txtNomeEquipamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.gbxOpcoes.SuspendLayout();
            this.gbxList.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcoes
            // 
            this.gbxOpcoes.Controls.Add(this.btnCancelar);
            this.gbxOpcoes.Controls.Add(this.btnSalvar);
            this.gbxOpcoes.Controls.Add(this.btnExcluir);
            this.gbxOpcoes.Controls.Add(this.btnEditar);
            this.gbxOpcoes.Controls.Add(this.btnIncluir);
            this.gbxOpcoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpcoes.Location = new System.Drawing.Point(261, 550);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(681, 119);
            this.gbxOpcoes.TabIndex = 11;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Opções para o Equipamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(564, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 78);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(436, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 78);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(301, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 78);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Inativar";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(161, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 78);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(22, 32);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 78);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.rdtInativo);
            this.gbxList.Controls.Add(this.rdtAtivo);
            this.gbxList.Controls.Add(this.txtProcurar);
            this.gbxList.Controls.Add(this.lstEquipamento);
            this.gbxList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxList.Location = new System.Drawing.Point(9, 7);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(236, 662);
            this.gbxList.TabIndex = 9;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "Equipamentos";
            this.gbxList.Enter += new System.EventHandler(this.gbxList_Enter);
            // 
            // rdtInativo
            // 
            this.rdtInativo.AutoSize = true;
            this.rdtInativo.Location = new System.Drawing.Point(70, 88);
            this.rdtInativo.Name = "rdtInativo";
            this.rdtInativo.Size = new System.Drawing.Size(105, 33);
            this.rdtInativo.TabIndex = 11;
            this.rdtInativo.TabStop = true;
            this.rdtInativo.Text = "Inativos";
            this.rdtInativo.UseVisualStyleBackColor = true;
            this.rdtInativo.CheckedChanged += new System.EventHandler(this.rdtInativo_CheckedChanged);
            // 
            // rdtAtivo
            // 
            this.rdtAtivo.AutoSize = true;
            this.rdtAtivo.Location = new System.Drawing.Point(70, 47);
            this.rdtAtivo.Name = "rdtAtivo";
            this.rdtAtivo.Size = new System.Drawing.Size(91, 33);
            this.rdtAtivo.TabIndex = 10;
            this.rdtAtivo.TabStop = true;
            this.rdtAtivo.Text = "Ativos";
            this.rdtAtivo.UseVisualStyleBackColor = true;
            this.rdtAtivo.CheckedChanged += new System.EventHandler(this.rdtAtivo_CheckedChanged);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(6, 598);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(215, 35);
            this.txtProcurar.TabIndex = 9;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // lstEquipamento
            // 
            this.lstEquipamento.FormattingEnabled = true;
            this.lstEquipamento.ItemHeight = 29;
            this.lstEquipamento.Location = new System.Drawing.Point(6, 139);
            this.lstEquipamento.Name = "lstEquipamento";
            this.lstEquipamento.Size = new System.Drawing.Size(215, 381);
            this.lstEquipamento.TabIndex = 0;
            this.lstEquipamento.SelectedIndexChanged += new System.EventHandler(this.lstEquipamento_SelectedIndexChanged);
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Controls.Add(this.cmbStatus);
            this.gbxDados.Controls.Add(this.txtIdEquipamento);
            this.gbxDados.Controls.Add(this.label5);
            this.gbxDados.Controls.Add(this.txtPatrimonio);
            this.gbxDados.Controls.Add(this.asdasda);
            this.gbxDados.Controls.Add(this.txtNomeEquipamento);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.txtDescricao);
            this.gbxDados.Controls.Add(this.label3);
            this.gbxDados.Controls.Add(this.txtStatus);
            this.gbxDados.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDados.Location = new System.Drawing.Point(261, 7);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(681, 525);
            this.gbxDados.TabIndex = 10;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados do Equipamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(237, 300);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(206, 37);
            this.cmbStatus.TabIndex = 4;
            // 
            // txtIdEquipamento
            // 
            this.txtIdEquipamento.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdEquipamento.Location = new System.Drawing.Point(237, 58);
            this.txtIdEquipamento.Name = "txtIdEquipamento";
            this.txtIdEquipamento.Size = new System.Drawing.Size(78, 35);
            this.txtIdEquipamento.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Equipamento";
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.BackColor = System.Drawing.SystemColors.Info;
            this.txtPatrimonio.Location = new System.Drawing.Point(237, 178);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(206, 35);
            this.txtPatrimonio.TabIndex = 2;
            this.txtPatrimonio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // asdasda
            // 
            this.asdasda.AutoSize = true;
            this.asdasda.Location = new System.Drawing.Point(94, 181);
            this.asdasda.Name = "asdasda";
            this.asdasda.Size = new System.Drawing.Size(116, 29);
            this.asdasda.TabIndex = 17;
            this.asdasda.Text = "Patrimônio";
            this.asdasda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNomeEquipamento
            // 
            this.txtNomeEquipamento.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeEquipamento.Location = new System.Drawing.Point(237, 118);
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.Size = new System.Drawing.Size(206, 35);
            this.txtNomeEquipamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescricao.Location = new System.Drawing.Point(237, 241);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(206, 35);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarTexto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(503, 458);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(161, 35);
            this.txtStatus.TabIndex = 10;
            // 
            // frmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.gbxOpcoes);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.gbxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Equipamentos";
            this.gbxOpcoes.ResumeLayout(false);
            this.gbxList.ResumeLayout(false);
            this.gbxList.PerformLayout();
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOpcoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.ListBox lstEquipamento;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtIdEquipamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label asdasda;
        private System.Windows.Forms.TextBox txtNomeEquipamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.RadioButton rdtInativo;
        private System.Windows.Forms.RadioButton rdtAtivo;
    }
}