namespace formUsuario
{
    partial class frmServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServidor));
            this.gbxOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.rdtInativo = new System.Windows.Forms.RadioButton();
            this.rdtAtivo = new System.Windows.Forms.RadioButton();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdServidor = new System.Windows.Forms.TextBox();
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
            this.gbxOpcoes.SuspendLayout();
            this.gbxList.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcoes
            // 
            this.gbxOpcoes.Controls.Add(this.btnCancelar);
            this.gbxOpcoes.Controls.Add(this.btnSalvar);
            this.gbxOpcoes.Controls.Add(this.btnInativar);
            this.gbxOpcoes.Controls.Add(this.btnEditar);
            this.gbxOpcoes.Controls.Add(this.btnIncluir);
            this.gbxOpcoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpcoes.Location = new System.Drawing.Point(265, 556);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(687, 113);
            this.gbxOpcoes.TabIndex = 17;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Opções para o Servidor";
            this.gbxOpcoes.Enter += new System.EventHandler(this.gbxOpcoes_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(574, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 78);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(435, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 78);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInativar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInativar.BackgroundImage")));
            this.btnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInativar.Location = new System.Drawing.Point(298, 26);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(100, 78);
            this.btnInativar.TabIndex = 2;
            this.btnInativar.Text = "&Inativar";
            this.btnInativar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(159, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 78);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(24, 25);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 78);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.rdtInativo);
            this.gbxList.Controls.Add(this.rdtAtivo);
            this.gbxList.Controls.Add(this.txtProcurar);
            this.gbxList.Controls.Add(this.lstNomes);
            this.gbxList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxList.Location = new System.Drawing.Point(3, 3);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(244, 666);
            this.gbxList.TabIndex = 15;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "Servidores";
            // 
            // rdtInativo
            // 
            this.rdtInativo.AutoSize = true;
            this.rdtInativo.Location = new System.Drawing.Point(75, 81);
            this.rdtInativo.Name = "rdtInativo";
            this.rdtInativo.Size = new System.Drawing.Size(105, 33);
            this.rdtInativo.TabIndex = 15;
            this.rdtInativo.TabStop = true;
            this.rdtInativo.Text = "Inativos";
            this.rdtInativo.UseVisualStyleBackColor = true;
            this.rdtInativo.CheckedChanged += new System.EventHandler(this.rdtInativo_CheckedChanged_1);
            // 
            // rdtAtivo
            // 
            this.rdtAtivo.AutoSize = true;
            this.rdtAtivo.Location = new System.Drawing.Point(75, 40);
            this.rdtAtivo.Name = "rdtAtivo";
            this.rdtAtivo.Size = new System.Drawing.Size(91, 33);
            this.rdtAtivo.TabIndex = 14;
            this.rdtAtivo.TabStop = true;
            this.rdtAtivo.Text = "Ativos";
            this.rdtAtivo.UseVisualStyleBackColor = true;
            this.rdtAtivo.CheckedChanged += new System.EventHandler(this.rdtAtivo_CheckedChanged_1);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(11, 613);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(215, 35);
            this.txtProcurar.TabIndex = 9;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged_1);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.ItemHeight = 29;
            this.lstNomes.Location = new System.Drawing.Point(11, 143);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(215, 410);
            this.lstNomes.TabIndex = 0;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtCargo);
            this.gbxDados.Controls.Add(this.label9);
            this.gbxDados.Controls.Add(this.txtIdPessoa);
            this.gbxDados.Controls.Add(this.label8);
            this.gbxDados.Controls.Add(this.txtTelefone);
            this.gbxDados.Controls.Add(this.label7);
            this.gbxDados.Controls.Add(this.txtEmail);
            this.gbxDados.Controls.Add(this.label6);
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Controls.Add(this.cmbStatus);
            this.gbxDados.Controls.Add(this.txtNascimento);
            this.gbxDados.Controls.Add(this.label10);
            this.gbxDados.Controls.Add(this.txtIdServidor);
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
            this.gbxDados.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDados.Location = new System.Drawing.Point(265, 3);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(687, 551);
            this.gbxDados.TabIndex = 16;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados do Servidor";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCargo.Location = new System.Drawing.Point(178, 215);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(186, 35);
            this.txtCargo.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Curso";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdPessoa.Location = new System.Drawing.Point(541, 55);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(78, 35);
            this.txtIdPessoa.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID Pessoa";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefone.Location = new System.Drawing.Point(178, 440);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 35);
            this.txtTelefone.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(178, 380);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 35);
            this.txtEmail.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 113);
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
            this.cmbStatus.Location = new System.Drawing.Point(541, 110);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(136, 37);
            this.cmbStatus.TabIndex = 23;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtNascimento
            // 
            this.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNascimento.Location = new System.Drawing.Point(198, 492);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(158, 35);
            this.txtNascimento.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dt. Nascimento";
            // 
            // txtIdServidor
            // 
            this.txtIdServidor.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdServidor.Location = new System.Drawing.Point(178, 55);
            this.txtIdServidor.Name = "txtIdServidor";
            this.txtIdServidor.Size = new System.Drawing.Size(81, 35);
            this.txtIdServidor.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Servidor";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.Info;
            this.txtRg.Location = new System.Drawing.Point(178, 272);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(186, 35);
            this.txtRg.TabIndex = 18;
            // 
            // asdasda
            // 
            this.asdasda.AutoSize = true;
            this.asdasda.Location = new System.Drawing.Point(115, 275);
            this.asdasda.Name = "asdasda";
            this.asdasda.Size = new System.Drawing.Size(42, 29);
            this.asdasda.TabIndex = 17;
            this.asdasda.Text = "RG";
            this.asdasda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(178, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 35);
            this.txtNome.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Info;
            this.txtCpf.Location = new System.Drawing.Point(178, 326);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(186, 35);
            this.txtCpf.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF";
            // 
            // txtProntuario
            // 
            this.txtProntuario.BackColor = System.Drawing.SystemColors.Info;
            this.txtProntuario.Location = new System.Drawing.Point(178, 163);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(186, 35);
            this.txtProntuario.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prontuário";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(520, 491);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(161, 35);
            this.txtStatus.TabIndex = 10;
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.gbxOpcoes);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.gbxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Servidores";
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
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker txtNascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label asdasda;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.RadioButton rdtInativo;
        private System.Windows.Forms.RadioButton rdtAtivo;
    }
}