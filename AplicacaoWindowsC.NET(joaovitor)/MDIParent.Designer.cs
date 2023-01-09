namespace AplicacaoWindowsC.NET_joaovitor_
{
    partial class MDIParent
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositóriosGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1475, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositóriosGitHubToolStripMenuItem,
            this.funcionalidadesToolStripMenuItem,
            this.sobreMimToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.projetosToolStripMenuItem.Text = "Inicio";
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreMimToolStripMenuItem
            // 
            this.sobreMimToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sobreMimToolStripMenuItem.Name = "sobreMimToolStripMenuItem";
            this.sobreMimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreMimToolStripMenuItem.Text = "Sobre mim";
            this.sobreMimToolStripMenuItem.Click += new System.EventHandler(this.sobreMimToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 731);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositóriosGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarArquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreMimToolStripMenuItem;
    }
}



