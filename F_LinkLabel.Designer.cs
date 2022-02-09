namespace Tela_Veiculos
{
    partial class F_LinkLabel
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.linkL_Youtube = new System.Windows.Forms.LinkLabel();
            this.linkL_Excel = new System.Windows.Forms.LinkLabel();
            this.linkL_Calculadora = new System.Windows.Forms.LinkLabel();
            this.multiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(5, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(88, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Digite um Nome: ";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(2, 28);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(183, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // linkL_Youtube
            // 
            this.linkL_Youtube.AutoSize = true;
            this.linkL_Youtube.Location = new System.Drawing.Point(6, 78);
            this.linkL_Youtube.Name = "linkL_Youtube";
            this.linkL_Youtube.Size = new System.Drawing.Size(47, 13);
            this.linkL_Youtube.TabIndex = 2;
            this.linkL_Youtube.TabStop = true;
            this.linkL_Youtube.Text = "Youtube";
            this.linkL_Youtube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL_Youtube_LinkClicked);
            // 
            // linkL_Excel
            // 
            this.linkL_Excel.AutoSize = true;
            this.linkL_Excel.Location = new System.Drawing.Point(82, 78);
            this.linkL_Excel.Name = "linkL_Excel";
            this.linkL_Excel.Size = new System.Drawing.Size(33, 13);
            this.linkL_Excel.TabIndex = 3;
            this.linkL_Excel.TabStop = true;
            this.linkL_Excel.Text = "Excel";
            this.linkL_Excel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL_Excel_LinkClicked);
            // 
            // linkL_Calculadora
            // 
            this.linkL_Calculadora.AutoSize = true;
            this.linkL_Calculadora.Location = new System.Drawing.Point(143, 78);
            this.linkL_Calculadora.Name = "linkL_Calculadora";
            this.linkL_Calculadora.Size = new System.Drawing.Size(63, 13);
            this.linkL_Calculadora.TabIndex = 4;
            this.linkL_Calculadora.TabStop = true;
            this.linkL_Calculadora.Text = "Calculadora";
            this.linkL_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL_Calculadora_LinkClicked);
            // 
            // multiplosLinks
            // 
            this.multiplosLinks.AutoSize = true;
            this.multiplosLinks.Location = new System.Drawing.Point(6, 140);
            this.multiplosLinks.Name = "multiplosLinks";
            this.multiplosLinks.Size = new System.Drawing.Size(127, 13);
            this.multiplosLinks.TabIndex = 5;
            this.multiplosLinks.TabStop = true;
            this.multiplosLinks.Text = "Google - Youtube - Globo";
            this.multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.multiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 391);
            this.Controls.Add(this.multiplosLinks);
            this.Controls.Add(this.linkL_Calculadora);
            this.Controls.Add(this.linkL_Excel);
            this.Controls.Add(this.linkL_Youtube);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.LinkLabel linkL_Youtube;
        private System.Windows.Forms.LinkLabel linkL_Excel;
        private System.Windows.Forms.LinkLabel linkL_Calculadora;
        private System.Windows.Forms.LinkLabel multiplosLinks;
    }
}