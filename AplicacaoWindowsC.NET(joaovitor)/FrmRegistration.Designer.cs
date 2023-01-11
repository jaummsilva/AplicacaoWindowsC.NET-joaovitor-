namespace AplicacaoWindowsC.NET_joaovitor_
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.label3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Formulario de Cadastro";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelNome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(399, 80);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(71, 27);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Turquoise;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpen.Location = new System.Drawing.Point(590, 394);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(190, 73);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Preencher Cadastro";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // textName2
            // 
            this.textName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName2.Location = new System.Drawing.Point(482, 90);
            this.textName2.Multiline = true;
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(467, 20);
            this.textName2.TabIndex = 14;
            // 
            // textAge
            // 
            this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAge.Location = new System.Drawing.Point(482, 152);
            this.textAge.Multiline = true;
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(467, 20);
            this.textAge.TabIndex = 15;
            // 
            // textCity
            // 
            this.textCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCity.Location = new System.Drawing.Point(482, 205);
            this.textCity.Multiline = true;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(467, 20);
            this.textCity.TabIndex = 16;
            // 
            // comboBoxState
            // 
            this.comboBoxState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(482, 257);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(467, 21);
            this.comboBoxState.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(482, 304);
            this.maskedTextBoxTelefone.Mask = "+00(00)00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(467, 13);
            this.maskedTextBoxTelefone.TabIndex = 19;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
   
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 710);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistration";
            this.Text = "FrmFormRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FrmRegistration_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox textName2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
    }
}