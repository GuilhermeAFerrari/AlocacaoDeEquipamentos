namespace formUsuario
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.gbxOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.asdasda = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SENHA = new System.Windows.Forms.Label();
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
            this.gbxOpcoes.Location = new System.Drawing.Point(263, 560);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(689, 109);
            this.gbxOpcoes.TabIndex = 8;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Opções para o Usuario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(569, 25);
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
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(436, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 78);
            this.btnSalvar.TabIndex = 8;
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
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(300, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 78);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
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
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(166, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 78);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&ZerarSenha";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(24, 25);
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
            this.gbxList.Controls.Add(this.txtProcurar);
            this.gbxList.Controls.Add(this.lstNomes);
            this.gbxList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxList.Location = new System.Drawing.Point(9, 6);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(236, 663);
            this.gbxList.TabIndex = 6;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "Usuários";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(11, 608);
            this.txtProcurar.Multiline = true;
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(215, 40);
            this.txtProcurar.TabIndex = 9;
            // 
            // lstNomes
            // 
            this.lstNomes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.ItemHeight = 29;
            this.lstNomes.Location = new System.Drawing.Point(11, 63);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(215, 526);
            this.lstNomes.TabIndex = 0;
            this.lstNomes.SelectedIndexChanged += new System.EventHandler(this.lstNomes_SelectedIndexChanged);
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Controls.Add(this.cmbStatus);
            this.gbxDados.Controls.Add(this.txtNascimento);
            this.gbxDados.Controls.Add(this.label10);
            this.gbxDados.Controls.Add(this.txtId);
            this.gbxDados.Controls.Add(this.label5);
            this.gbxDados.Controls.Add(this.txtRg);
            this.gbxDados.Controls.Add(this.asdasda);
            this.gbxDados.Controls.Add(this.txtNome);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.txtCpf);
            this.gbxDados.Controls.Add(this.label3);
            this.gbxDados.Controls.Add(this.txtProntuario);
            this.gbxDados.Controls.Add(this.label1);
            this.gbxDados.Controls.Add(this.txtStatus);
            this.gbxDados.Controls.Add(this.txtSenha);
            this.gbxDados.Controls.Add(this.SENHA);
            this.gbxDados.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDados.Location = new System.Drawing.Point(263, 12);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(689, 542);
            this.gbxDados.TabIndex = 7;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados do Usuário";
            this.gbxDados.Enter += new System.EventHandler(this.gbxDados_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(529, 54);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 37);
            this.cmbStatus.TabIndex = 7;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNascimento.Location = new System.Drawing.Point(232, 417);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(140, 35);
            this.txtNascimento.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dt. Nascimento";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Info;
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(186, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 35);
            this.txtId.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Usuário";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.Info;
            this.txtRg.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(186, 177);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(186, 35);
            this.txtRg.TabIndex = 2;
            // 
            // asdasda
            // 
            this.asdasda.AutoSize = true;
            this.asdasda.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdasda.Location = new System.Drawing.Point(112, 180);
            this.asdasda.Name = "asdasda";
            this.asdasda.Size = new System.Drawing.Size(42, 29);
            this.asdasda.TabIndex = 17;
            this.asdasda.Text = "RG";
            this.asdasda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(186, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 35);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Info;
            this.txtCpf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(186, 238);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(186, 35);
            this.txtCpf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF";
            // 
            // txtProntuario
            // 
            this.txtProntuario.BackColor = System.Drawing.SystemColors.Info;
            this.txtProntuario.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(186, 298);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(186, 35);
            this.txtProntuario.TabIndex = 4;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            this.txtProntuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prontuário";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(508, 476);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(161, 35);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Info;
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(186, 357);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(186, 35);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // SENHA
            // 
            this.SENHA.AutoSize = true;
            this.SENHA.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SENHA.Location = new System.Drawing.Point(87, 360);
            this.SENHA.Name = "SENHA";
            this.SENHA.Size = new System.Drawing.Size(72, 29);
            this.SENHA.TabIndex = 2;
            this.SENHA.Text = "Senha";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.gbxOpcoes);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.gbxDados);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciameto de Usuários";
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
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label SENHA;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label asdasda;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker txtNascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcurar;
    }
}

