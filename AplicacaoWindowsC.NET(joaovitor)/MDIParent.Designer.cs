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
            this.components = new System.ComponentModel.Container();
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
            this.importarArquivosComProgressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem,
            this.treeViewToolStripMenuItem,
            this.webBrowserToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1475, 27);
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
            this.projetosToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.projetosToolStripMenuItem.Text = "Inicio";
            // 
            // repositóriosGitHubToolStripMenuItem
            // 
            this.repositóriosGitHubToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.repositóriosGitHubToolStripMenuItem.Name = "repositóriosGitHubToolStripMenuItem";
            this.repositóriosGitHubToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
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
            this.dataEHoraToolStripMenuItem,
            this.importarArquivosComProgressBarToolStripMenuItem});
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            // 
            // salvarArquivosToolStripMenuItem
            // 
            this.salvarArquivosToolStripMenuItem.Name = "salvarArquivosToolStripMenuItem";
            this.salvarArquivosToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.salvarArquivosToolStripMenuItem.Text = "Salvar Arquivos";
            this.salvarArquivosToolStripMenuItem.Click += new System.EventHandler(this.salvarArquivosToolStripMenuItem_Click);
            // 
            // formulárioCadastroToolStripMenuItem
            // 
            this.formulárioCadastroToolStripMenuItem.Name = "formulárioCadastroToolStripMenuItem";
            this.formulárioCadastroToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.formulárioCadastroToolStripMenuItem.Text = "Formulário cadastro";
            this.formulárioCadastroToolStripMenuItem.Click += new System.EventHandler(this.formulárioCadastroToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.enviarEmailToolStripMenuItem.Text = "Enviar email";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // dataEHoraToolStripMenuItem
            // 
            this.dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            this.dataEHoraToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.dataEHoraToolStripMenuItem.Text = "Data e Hora";
            this.dataEHoraToolStripMenuItem.Click += new System.EventHandler(this.dataEHoraToolStripMenuItem_Click);
            // 
            // importarArquivosComProgressBarToolStripMenuItem
            // 
            this.importarArquivosComProgressBarToolStripMenuItem.Name = "importarArquivosComProgressBarToolStripMenuItem";
            this.importarArquivosComProgressBarToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.importarArquivosComProgressBarToolStripMenuItem.Text = "Importar Arquivos com Progress Bar";
            this.importarArquivosComProgressBarToolStripMenuItem.Click += new System.EventHandler(this.importarArquivosComProgressBarToolStripMenuItem_Click);
            // 
            // sobreMimToolStripMenuItem
            // 
            this.sobreMimToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sobreMimToolStripMenuItem.Name = "sobreMimToolStripMenuItem";
            this.sobreMimToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.sobreMimToolStripMenuItem.Text = "Sobre mim";
            this.sobreMimToolStripMenuItem.Click += new System.EventHandler(this.sobreMimToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.treeViewToolStripMenuItem.Text = "Tree View";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1475, 23);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(241, 18);
            this.toolStripStatusLabel2.Text = "@ Aplicacão Windows C# - João Vitor";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 17);
            this.toolStripProgressBar1.Value = 50;
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.webBrowserToolStripMenuItem.Text = "WebBrowser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 731);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem importarArquivosComProgressBarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
    }
}



