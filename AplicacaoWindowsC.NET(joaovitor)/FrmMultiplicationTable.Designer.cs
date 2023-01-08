namespace AplicacaoWindowsC.NET_joaovitor_
{
    partial class FrmMultiplicationTable
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnMultiTable = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxMultiTable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tabuada";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(397, 110);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(162, 24);
            this.labelNome.TabIndex = 17;
            this.labelNome.Text = "Digite um numero:";
            // 
            // btnMultiTable
            // 
            this.btnMultiTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiTable.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiTable.ForeColor = System.Drawing.Color.Black;
            this.btnMultiTable.Location = new System.Drawing.Point(930, 148);
            this.btnMultiTable.Name = "btnMultiTable";
            this.btnMultiTable.Size = new System.Drawing.Size(190, 57);
            this.btnMultiTable.TabIndex = 18;
            this.btnMultiTable.Text = "Multiplicar";
            this.btnMultiTable.UseVisualStyleBackColor = false;
            this.btnMultiTable.Click += new System.EventHandler(this.btnMultiTable_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(930, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(190, 57);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(930, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 57);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Voltar ao Menu";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(404, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 251);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxMultiTable
            // 
            this.textBoxMultiTable.Location = new System.Drawing.Point(565, 114);
            this.textBoxMultiTable.Name = "textBoxMultiTable";
            this.textBoxMultiTable.Size = new System.Drawing.Size(328, 20);
            this.textBoxMultiTable.TabIndex = 23;
            // 
            // FrmMultiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 718);
            this.Controls.Add(this.textBoxMultiTable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiTable);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label3);
            this.Name = "FrmMultiplicationTable";
            this.Text = "FrmMultiplicationTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnMultiTable;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxMultiTable;
    }
}