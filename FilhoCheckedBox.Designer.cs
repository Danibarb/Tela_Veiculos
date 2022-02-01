namespace Tela_Veiculos
{
    partial class FilhoCheckedBox
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
            this.cbox_onibus = new System.Windows.Forms.CheckBox();
            this.cbox_navio = new System.Windows.Forms.CheckBox();
            this.cbox_aviao = new System.Windows.Forms.CheckBox();
            this.cbox_carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbox_onibus
            // 
            this.cbox_onibus.AutoSize = true;
            this.cbox_onibus.Location = new System.Drawing.Point(12, 81);
            this.cbox_onibus.Name = "cbox_onibus";
            this.cbox_onibus.Size = new System.Drawing.Size(59, 17);
            this.cbox_onibus.TabIndex = 7;
            this.cbox_onibus.Text = "Onibus";
            this.cbox_onibus.UseVisualStyleBackColor = true;
            this.cbox_onibus.CheckedChanged += new System.EventHandler(this.cbox_onibus_CheckedChanged);
            // 
            // cbox_navio
            // 
            this.cbox_navio.AutoSize = true;
            this.cbox_navio.Location = new System.Drawing.Point(12, 58);
            this.cbox_navio.Name = "cbox_navio";
            this.cbox_navio.Size = new System.Drawing.Size(54, 17);
            this.cbox_navio.TabIndex = 6;
            this.cbox_navio.Text = "Navio";
            this.cbox_navio.UseVisualStyleBackColor = true;
            this.cbox_navio.CheckedChanged += new System.EventHandler(this.cbox_navio_CheckedChanged);
            // 
            // cbox_aviao
            // 
            this.cbox_aviao.AutoSize = true;
            this.cbox_aviao.Location = new System.Drawing.Point(12, 35);
            this.cbox_aviao.Name = "cbox_aviao";
            this.cbox_aviao.Size = new System.Drawing.Size(53, 17);
            this.cbox_aviao.TabIndex = 5;
            this.cbox_aviao.Text = "Avião";
            this.cbox_aviao.UseVisualStyleBackColor = true;
            this.cbox_aviao.CheckedChanged += new System.EventHandler(this.cbox_aviao_CheckedChanged);
            // 
            // cbox_carro
            // 
            this.cbox_carro.AutoSize = true;
            this.cbox_carro.Location = new System.Drawing.Point(12, 12);
            this.cbox_carro.Name = "cbox_carro";
            this.cbox_carro.Size = new System.Drawing.Size(51, 17);
            this.cbox_carro.TabIndex = 4;
            this.cbox_carro.Text = "Carro";
            this.cbox_carro.UseVisualStyleBackColor = true;
            this.cbox_carro.CheckedChanged += new System.EventHandler(this.cbox_carro_CheckedChanged);
            // 
            // FilhoCheckedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 196);
            this.Controls.Add(this.cbox_onibus);
            this.Controls.Add(this.cbox_navio);
            this.Controls.Add(this.cbox_aviao);
            this.Controls.Add(this.cbox_carro);
            this.MaximizeBox = false;
            this.Name = "FilhoCheckedBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilhoCheckedBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbox_onibus;
        private System.Windows.Forms.CheckBox cbox_navio;
        private System.Windows.Forms.CheckBox cbox_aviao;
        private System.Windows.Forms.CheckBox cbox_carro;
    }
}