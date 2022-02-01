namespace Tela_Veiculos
{
    partial class CheckedBox
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
            this.cbox_carro = new System.Windows.Forms.CheckBox();
            this.cbox_aviao = new System.Windows.Forms.CheckBox();
            this.cbox_navio = new System.Windows.Forms.CheckBox();
            this.cbox_onibus = new System.Windows.Forms.CheckBox();
            this.btn_trasportesMarcados = new System.Windows.Forms.Button();
            this.btn_forFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_carro
            // 
            this.cbox_carro.AutoSize = true;
            this.cbox_carro.Location = new System.Drawing.Point(12, 8);
            this.cbox_carro.Name = "cbox_carro";
            this.cbox_carro.Size = new System.Drawing.Size(51, 17);
            this.cbox_carro.TabIndex = 0;
            this.cbox_carro.Text = "Carro";
            this.cbox_carro.UseVisualStyleBackColor = true;
            // 
            // cbox_aviao
            // 
            this.cbox_aviao.AutoSize = true;
            this.cbox_aviao.Location = new System.Drawing.Point(12, 31);
            this.cbox_aviao.Name = "cbox_aviao";
            this.cbox_aviao.Size = new System.Drawing.Size(53, 17);
            this.cbox_aviao.TabIndex = 1;
            this.cbox_aviao.Text = "Avião";
            this.cbox_aviao.UseVisualStyleBackColor = true;
            // 
            // cbox_navio
            // 
            this.cbox_navio.AutoSize = true;
            this.cbox_navio.Location = new System.Drawing.Point(12, 54);
            this.cbox_navio.Name = "cbox_navio";
            this.cbox_navio.Size = new System.Drawing.Size(54, 17);
            this.cbox_navio.TabIndex = 2;
            this.cbox_navio.Text = "Navio";
            this.cbox_navio.UseVisualStyleBackColor = true;
            // 
            // cbox_onibus
            // 
            this.cbox_onibus.AutoSize = true;
            this.cbox_onibus.Location = new System.Drawing.Point(12, 77);
            this.cbox_onibus.Name = "cbox_onibus";
            this.cbox_onibus.Size = new System.Drawing.Size(59, 17);
            this.cbox_onibus.TabIndex = 3;
            this.cbox_onibus.Text = "Onibus";
            this.cbox_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_trasportesMarcados
            // 
            this.btn_trasportesMarcados.Location = new System.Drawing.Point(120, 8);
            this.btn_trasportesMarcados.Name = "btn_trasportesMarcados";
            this.btn_trasportesMarcados.Size = new System.Drawing.Size(158, 25);
            this.btn_trasportesMarcados.TabIndex = 4;
            this.btn_trasportesMarcados.Text = "Transportes Marcados";
            this.btn_trasportesMarcados.UseVisualStyleBackColor = true;
            this.btn_trasportesMarcados.Click += new System.EventHandler(this.btn_trasportesMarcados_Click);
            // 
            // btn_forFilho
            // 
            this.btn_forFilho.Location = new System.Drawing.Point(120, 49);
            this.btn_forFilho.Name = "btn_forFilho";
            this.btn_forFilho.Size = new System.Drawing.Size(158, 25);
            this.btn_forFilho.TabIndex = 5;
            this.btn_forFilho.Text = "Abrir Form Filho";
            this.btn_forFilho.UseVisualStyleBackColor = true;
            this.btn_forFilho.Click += new System.EventHandler(this.btn_forFilho_Click);
            // 
            // CheckedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 155);
            this.Controls.Add(this.btn_forFilho);
            this.Controls.Add(this.btn_trasportesMarcados);
            this.Controls.Add(this.cbox_onibus);
            this.Controls.Add(this.cbox_navio);
            this.Controls.Add(this.cbox_aviao);
            this.Controls.Add(this.cbox_carro);
            this.Name = "CheckedBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_trasportesMarcados;
        private System.Windows.Forms.Button btn_forFilho;
        public System.Windows.Forms.CheckBox cbox_carro;
        public System.Windows.Forms.CheckBox cbox_aviao;
        public System.Windows.Forms.CheckBox cbox_navio;
        public System.Windows.Forms.CheckBox cbox_onibus;
    }
}