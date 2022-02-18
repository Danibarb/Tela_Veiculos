namespace Tela_Veiculos
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.lbl_countBar = new System.Windows.Forms.Label();
            this.txt_valorBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 18);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(12, 73);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(119, 30);
            this.btn_definirValor.TabIndex = 1;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(12, 130);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(119, 30);
            this.btn_preencher.TabIndex = 2;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // lbl_countBar
            // 
            this.lbl_countBar.AutoSize = true;
            this.lbl_countBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countBar.Location = new System.Drawing.Point(197, 38);
            this.lbl_countBar.Name = "lbl_countBar";
            this.lbl_countBar.Size = new System.Drawing.Size(18, 20);
            this.lbl_countBar.TabIndex = 3;
            this.lbl_countBar.Text = "0";
            // 
            // txt_valorBar
            // 
            this.txt_valorBar.Location = new System.Drawing.Point(9, 31);
            this.txt_valorBar.Name = "txt_valorBar";
            this.txt_valorBar.Size = new System.Drawing.Size(130, 20);
            this.txt_valorBar.TabIndex = 4;
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 253);
            this.Controls.Add(this.txt_valorBar);
            this.Controls.Add(this.lbl_countBar);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.Label lbl_countBar;
        private System.Windows.Forms.TextBox txt_valorBar;
    }
}