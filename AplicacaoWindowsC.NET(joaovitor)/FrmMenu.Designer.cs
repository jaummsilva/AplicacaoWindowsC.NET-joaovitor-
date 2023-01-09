namespace AplicacaoWindowsC.NET_joaovitor_
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositóriosGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositóriosGitHubToolStripMenuItem,
            this.funcionalidadesToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projetosToolStripMenuItem.Text = "Projetos";
            // 
            // repositóriosGitHubToolStripMenuItem
            // 
            this.repositóriosGitHubToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.repositóriosGitHubToolStripMenuItem.Name = "repositóriosGitHubToolStripMenuItem";
            this.repositóriosGitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repositóriosGitHubToolStripMenuItem.Text = "Repositórios GitHub";
            this.repositóriosGitHubToolStripMenuItem.Click += new System.EventHandler(this.repositóriosGitHubToolStripMenuItem_Click);
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.funcionalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarArquivosToolStripMenuItem,
            this.formulárioCadastroToolStripMenuItem,
            this.tabuadaToolStripMenuItem,
            this.enviarEmailToolStripMenuItem,
            this.dataEHoraToolStripMenuItem});
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            // 
            // salvarArquivosToolStripMenuItem
            // 
            this.salvarArquivosToolStripMenuItem.Name = "salvarArquivosToolStripMenuItem";
            this.salvarArquivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarArquivosToolStripMenuItem.Text = "Salvar Arquivos";
            this.salvarArquivosToolStripMenuItem.Click += new System.EventHandler(this.salvarArquivosToolStripMenuItem_Click);
            // 
            // formulárioCadastroToolStripMenuItem
            // 
            this.formulárioCadastroToolStripMenuItem.Name = "formulárioCadastroToolStripMenuItem";
            this.formulárioCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formulárioCadastroToolStripMenuItem.Text = "Formulário cadastro";
            this.formulárioCadastroToolStripMenuItem.Click += new System.EventHandler(this.formulárioCadastroToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enviarEmailToolStripMenuItem.Text = "Enviar email";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // dataEHoraToolStripMenuItem
            // 
            this.dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            this.dataEHoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataEHoraToolStripMenuItem.Text = "Data e Hora";
            this.dataEHoraToolStripMenuItem.Click += new System.EventHandler(this.dataEHoraToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositóriosGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarArquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEHoraToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}