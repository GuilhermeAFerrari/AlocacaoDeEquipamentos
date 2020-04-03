namespace formUsuario
{
    partial class frmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
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
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
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
            this.txtIdAluno = new System.Windows.Forms.TextBox();
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
            this.gbxOpcoes.Controls.Add(this.btnExcluir);
            this.gbxOpcoes.Controls.Add(this.btnEditar);
            this.gbxOpcoes.Controls.Add(this.btnIncluir);
            this.gbxOpcoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpcoes.Location = new System.Drawing.Point(253, 546);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(687, 123);
            this.gbxOpcoes.TabIndex = 11;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Opções para o Aluno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(569, 31);
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
            this.btnSalvar.Location = new System.Drawing.Point(430, 31);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 78);
            this.btnSalvar.TabIndex = 10;
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
            this.btnExcluir.Location = new System.Drawing.Point(294, 31);
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
            this.btnEditar.Location = new System.Drawing.Point(156, 31);
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
            this.btnIncluir.Location = new System.Drawing.Point(15, 31);
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
            this.gbxList.Controls.Add(this.lstNomes);
            this.gbxList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxList.Location = new System.Drawing.Point(3, 3);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(233, 666);
            this.gbxList.TabIndex = 9;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "Alunos";
            // 
            // rdtInativo
            // 
            this.rdtInativo.AutoSize = true;
            this.rdtInativo.Location = new System.Drawing.Point(64, 88);
            this.rdtInativo.Name = "rdtInativo";
            this.rdtInativo.Size = new System.Drawing.Size(105, 33);
            this.rdtInativo.TabIndex = 13;
            this.rdtInativo.TabStop = true;
            this.rdtInativo.Text = "Inativos";
            this.rdtInativo.UseVisualStyleBackColor = true;
            this.rdtInativo.CheckedChanged += new System.EventHandler(this.rdtInativo_CheckedChanged);
            // 
            // rdtAtivo
            // 
            this.rdtAtivo.AutoSize = true;
            this.rdtAtivo.Location = new System.Drawing.Point(64, 44);
            this.rdtAtivo.Name = "rdtAtivo";
            this.rdtAtivo.Size = new System.Drawing.Size(91, 33);
            this.rdtAtivo.TabIndex = 12;
            this.rdtAtivo.TabStop = true;
            this.rdtAtivo.Text = "Ativos";
            this.rdtAtivo.UseVisualStyleBackColor = true;
            this.rdtAtivo.CheckedChanged += new System.EventHandler(this.rdtAtivo_CheckedChanged);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(11, 595);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(215, 35);
            this.txtProcurar.TabIndex = 9;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.ItemHeight = 29;
            this.lstNomes.Location = new System.Drawing.Point(11, 143);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(215, 381);
            this.lstNomes.TabIndex = 0;
            this.lstNomes.SelectedIndexChanged += new System.EventHandler(this.lstNomes_SelectedIndexChanged);
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtCurso);
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
            this.gbxDados.Controls.Add(this.txtIdAluno);
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
            this.gbxDados.Location = new System.Drawing.Point(253, 3);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(687, 537);
            this.gbxDados.TabIndex = 10;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados do Aluno";
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.SystemColors.Info;
            this.txtCurso.Location = new System.Drawing.Point(170, 201);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(186, 35);
            this.txtCurso.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Curso";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdPessoa.Location = new System.Drawing.Point(541, 44);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(86, 35);
            this.txtIdPessoa.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID Pessoa";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefone.Location = new System.Drawing.Point(170, 416);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 35);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(170, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 35);
            this.txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 101);
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
            this.cmbStatus.Location = new System.Drawing.Point(541, 98);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 37);
            this.cmbStatus.TabIndex = 9;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNascimento.Location = new System.Drawing.Point(186, 470);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(170, 35);
            this.txtNascimento.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dt. Nascimento";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdAluno.Location = new System.Drawing.Point(170, 47);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(86, 35);
            this.txtIdAluno.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Aluno";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.Info;
            this.txtRg.Location = new System.Drawing.Point(170, 255);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(186, 35);
            this.txtRg.TabIndex = 4;
            // 
            // asdasda
            // 
            this.asdasda.AutoSize = true;
            this.asdasda.Location = new System.Drawing.Point(108, 258);
            this.asdasda.Name = "asdasda";
            this.asdasda.Size = new System.Drawing.Size(42, 29);
            this.asdasda.TabIndex = 17;
            this.asdasda.Text = "RG";
            this.asdasda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(170, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 35);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarTexto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Info;
            this.txtCpf.Location = new System.Drawing.Point(170, 309);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(186, 35);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF";
            // 
            // txtProntuario
            // 
            this.txtProntuario.BackColor = System.Drawing.SystemColors.Info;
            this.txtProntuario.Location = new System.Drawing.Point(170, 147);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(186, 35);
            this.txtProntuario.TabIndex = 2;
            this.txtProntuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prontuário";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(508, 470);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(161, 35);
            this.txtStatus.TabIndex = 10;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.gbxOpcoes);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.gbxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Alunos";
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
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker txtNascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdAluno;
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
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdtInativo;
        private System.Windows.Forms.RadioButton rdtAtivo;
    }
}