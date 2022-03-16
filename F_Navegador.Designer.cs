namespace Tela_Veiculos
{
    partial class F_Navegador
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_perquisar = new System.Windows.Forms.Button();
            this.btn_definirhome = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(2, 18);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(174, 20);
            this.txt_url.TabIndex = 0;
            this.txt_url.TextChanged += new System.EventHandler(this.txt_url_TextChanged);
            this.txt_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_url_KeyDown);
            // 
            // btn_ir
            // 
            this.btn_ir.Location = new System.Drawing.Point(182, 14);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(92, 27);
            this.btn_ir.TabIndex = 1;
            this.btn_ir.Text = "Ir";
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_ir_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(280, 14);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(92, 27);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(378, 14);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(92, 27);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(476, 14);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(92, 27);
            this.btn_proximo.TabIndex = 4;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(574, 14);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(92, 27);
            this.btn_parar.TabIndex = 5;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(672, 14);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(92, 27);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_perquisar
            // 
            this.btn_perquisar.Location = new System.Drawing.Point(770, 14);
            this.btn_perquisar.Name = "btn_perquisar";
            this.btn_perquisar.Size = new System.Drawing.Size(92, 27);
            this.btn_perquisar.TabIndex = 7;
            this.btn_perquisar.Text = "Pesquisar";
            this.btn_perquisar.UseVisualStyleBackColor = true;
            this.btn_perquisar.Click += new System.EventHandler(this.btn_perquisar_Click);
            // 
            // btn_definirhome
            // 
            this.btn_definirhome.Location = new System.Drawing.Point(868, 14);
            this.btn_definirhome.Name = "btn_definirhome";
            this.btn_definirhome.Size = new System.Drawing.Size(92, 27);
            this.btn_definirhome.TabIndex = 8;
            this.btn_definirhome.Text = "Definir Home";
            this.btn_definirhome.UseVisualStyleBackColor = true;
            this.btn_definirhome.Click += new System.EventHandler(this.btn_definirhome_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(969, 404);
            this.webBrowser1.TabIndex = 9;
            // 
            // F_Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_definirhome);
            this.Controls.Add(this.btn_perquisar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.txt_url);
            this.Name = "F_Navegador";
            this.Text = "F_Navegador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_perquisar;
        private System.Windows.Forms.Button btn_definirhome;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}