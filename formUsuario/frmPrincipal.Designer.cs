namespace formUsuario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentossCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alocaçõesAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidoresCadastradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastosToolStripMenuItem,
            this.alocaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.logoffToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastosToolStripMenuItem
            // 
            this.cadastosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.equipamentoToolStripMenuItem,
            this.servidorToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastosToolStripMenuItem.Image")));
            this.cadastosToolStripMenuItem.Name = "cadastosToolStripMenuItem";
            this.cadastosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastosToolStripMenuItem.Text = "&Cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alunoToolStripMenuItem.Text = "&Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // equipamentoToolStripMenuItem
            // 
            this.equipamentoToolStripMenuItem.Name = "equipamentoToolStripMenuItem";
            this.equipamentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equipamentoToolStripMenuItem.Text = "&Equipamento";
            this.equipamentoToolStripMenuItem.Click += new System.EventHandler(this.equipamentoToolStripMenuItem_Click);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.servidorToolStripMenuItem.Text = "&Servidor";
            this.servidorToolStripMenuItem.Click += new System.EventHandler(this.servidorToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "&Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // alocaçõesToolStripMenuItem
            // 
            this.alocaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipamentosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.alocaçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alocaçõesToolStripMenuItem.Image")));
            this.alocaçõesToolStripMenuItem.Name = "alocaçõesToolStripMenuItem";
            this.alocaçõesToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.alocaçõesToolStripMenuItem.Text = "&Alocações - Devoluções";
            this.alocaçõesToolStripMenuItem.Click += new System.EventHandler(this.alocaçõesToolStripMenuItem_Click);
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.equipamentosToolStripMenuItem.Text = "&Aluno - Equipamento";
            this.equipamentosToolStripMenuItem.Click += new System.EventHandler(this.equipamentosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.consultaToolStripMenuItem.Text = "&Servidor - Equipamento";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipamentossCadastradosToolStripMenuItem,
            this.alocaçõesAlunosToolStripMenuItem,
            this.equipamentosCadastradosToolStripMenuItem,
            this.servidoresCadastradorToolStripMenuItem,
            this.usuáriosCadastradosToolStripMenuItem,
            this.alunosCadastradosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // equipamentossCadastradosToolStripMenuItem
            // 
            this.equipamentossCadastradosToolStripMenuItem.Name = "equipamentossCadastradosToolStripMenuItem";
            this.equipamentossCadastradosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.equipamentossCadastradosToolStripMenuItem.Text = "Alocações Servidores";
            this.equipamentossCadastradosToolStripMenuItem.Click += new System.EventHandler(this.equipamentossCadastradosToolStripMenuItem_Click);
            // 
            // alocaçõesAlunosToolStripMenuItem
            // 
            this.alocaçõesAlunosToolStripMenuItem.Name = "alocaçõesAlunosToolStripMenuItem";
            this.alocaçõesAlunosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.alocaçõesAlunosToolStripMenuItem.Text = "Alocações Alunos";
            this.alocaçõesAlunosToolStripMenuItem.Click += new System.EventHandler(this.alocaçõesAlunosToolStripMenuItem_Click);
            // 
            // equipamentosCadastradosToolStripMenuItem
            // 
            this.equipamentosCadastradosToolStripMenuItem.Name = "equipamentosCadastradosToolStripMenuItem";
            this.equipamentosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.equipamentosCadastradosToolStripMenuItem.Text = "Equipamentos Cadastrados";
            this.equipamentosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.equipamentosCadastradosToolStripMenuItem_Click);
            // 
            // servidoresCadastradorToolStripMenuItem
            // 
            this.servidoresCadastradorToolStripMenuItem.Name = "servidoresCadastradorToolStripMenuItem";
            this.servidoresCadastradorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.servidoresCadastradorToolStripMenuItem.Text = "Servidores Cadastrados";
            this.servidoresCadastradorToolStripMenuItem.Click += new System.EventHandler(this.servidoresCadastradorToolStripMenuItem_Click);
            // 
            // usuáriosCadastradosToolStripMenuItem
            // 
            this.usuáriosCadastradosToolStripMenuItem.Name = "usuáriosCadastradosToolStripMenuItem";
            this.usuáriosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.usuáriosCadastradosToolStripMenuItem.Text = "Usuários Cadastrados";
            this.usuáriosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosCadastradosToolStripMenuItem_Click);
            // 
            // alunosCadastradosToolStripMenuItem
            // 
            this.alunosCadastradosToolStripMenuItem.Name = "alunosCadastradosToolStripMenuItem";
            this.alunosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.alunosCadastradosToolStripMenuItem.Text = "Alunos Cadastrados";
            this.alunosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.alunosCadastradosToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoffToolStripMenuItem.Image")));
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.logoffToolStripMenuItem.Text = "&Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GJM Sistemas - Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alocaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentossCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidoresCadastradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alocaçõesAlunosToolStripMenuItem;
    }
}