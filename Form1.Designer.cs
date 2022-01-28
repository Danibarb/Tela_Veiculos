namespace Tela_Veiculos
{
    partial class CheckdListBox
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
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.txt_veiculos = new System.Windows.Forms.TextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.txt_listaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(13, 45);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(91, 13);
            this.lb_veiculo.TabIndex = 0;
            this.lb_veiculo.Text = "Digite um Veículo";
            // 
            // txt_veiculos
            // 
            this.txt_veiculos.Location = new System.Drawing.Point(10, 67);
            this.txt_veiculos.Name = "txt_veiculos";
            this.txt_veiculos.Size = new System.Drawing.Size(114, 20);
            this.txt_veiculos.TabIndex = 1;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(130, 64);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(99, 23);
            this.bt_adicionar.TabIndex = 2;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(5, 290);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(224, 23);
            this.bt_limpar.TabIndex = 3;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // txt_listaVeiculos
            // 
            this.txt_listaVeiculos.Location = new System.Drawing.Point(10, 95);
            this.txt_listaVeiculos.Multiline = true;
            this.txt_listaVeiculos.Name = "txt_listaVeiculos";
            this.txt_listaVeiculos.ReadOnly = true;
            this.txt_listaVeiculos.Size = new System.Drawing.Size(219, 189);
            this.txt_listaVeiculos.TabIndex = 4;
            // 
            // CheckdListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 378);
            this.Controls.Add(this.txt_listaVeiculos);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.txt_veiculos);
            this.Controls.Add(this.lb_veiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckdListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.TextBox txt_veiculos;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.TextBox txt_listaVeiculos;
    }
}

