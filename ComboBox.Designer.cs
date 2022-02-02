namespace Tela_Veiculos
{
    partial class ComboBox
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
            this.cbx_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparComboBox = new System.Windows.Forms.Button();
            this.btn_ResetarComboBox = new System.Windows.Forms.Button();
            this.btn_NovoTransporte = new System.Windows.Forms.Button();
            this.txt_Transporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbx_transportes
            // 
            this.cbx_transportes.FormattingEnabled = true;
            this.cbx_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Onibus",
            "Navio",
            "Trem"});
            this.cbx_transportes.Location = new System.Drawing.Point(14, 12);
            this.cbx_transportes.Name = "cbx_transportes";
            this.cbx_transportes.Size = new System.Drawing.Size(249, 21);
            this.cbx_transportes.TabIndex = 0;
            this.cbx_transportes.SelectedIndexChanged += new System.EventHandler(this.cbx_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(300, 14);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(191, 31);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_LimparComboBox
            // 
            this.btn_LimparComboBox.Location = new System.Drawing.Point(300, 51);
            this.btn_LimparComboBox.Name = "btn_LimparComboBox";
            this.btn_LimparComboBox.Size = new System.Drawing.Size(191, 31);
            this.btn_LimparComboBox.TabIndex = 2;
            this.btn_LimparComboBox.Text = "Limpar";
            this.btn_LimparComboBox.UseVisualStyleBackColor = true;
            this.btn_LimparComboBox.Click += new System.EventHandler(this.btn_LimparComboBox_Click);
            // 
            // btn_ResetarComboBox
            // 
            this.btn_ResetarComboBox.Location = new System.Drawing.Point(300, 88);
            this.btn_ResetarComboBox.Name = "btn_ResetarComboBox";
            this.btn_ResetarComboBox.Size = new System.Drawing.Size(191, 31);
            this.btn_ResetarComboBox.TabIndex = 3;
            this.btn_ResetarComboBox.Text = "Resetar";
            this.btn_ResetarComboBox.UseVisualStyleBackColor = true;
            this.btn_ResetarComboBox.Click += new System.EventHandler(this.btn_ResetarComboBox_Click);
            // 
            // btn_NovoTransporte
            // 
            this.btn_NovoTransporte.Location = new System.Drawing.Point(300, 200);
            this.btn_NovoTransporte.Name = "btn_NovoTransporte";
            this.btn_NovoTransporte.Size = new System.Drawing.Size(191, 31);
            this.btn_NovoTransporte.TabIndex = 4;
            this.btn_NovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_NovoTransporte.UseVisualStyleBackColor = true;
            this.btn_NovoTransporte.Click += new System.EventHandler(this.btn_NovoTransporte_Click);
            // 
            // txt_Transporte
            // 
            this.txt_Transporte.Location = new System.Drawing.Point(300, 171);
            this.txt_Transporte.Name = "txt_Transporte";
            this.txt_Transporte.Size = new System.Drawing.Size(190, 20);
            this.txt_Transporte.TabIndex = 5;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.txt_Transporte);
            this.Controls.Add(this.btn_NovoTransporte);
            this.Controls.Add(this.btn_ResetarComboBox);
            this.Controls.Add(this.btn_LimparComboBox);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cbx_transportes);
            this.MaximizeBox = false;
            this.Name = "ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparComboBox;
        private System.Windows.Forms.Button btn_ResetarComboBox;
        private System.Windows.Forms.Button btn_NovoTransporte;
        private System.Windows.Forms.TextBox txt_Transporte;
    }
}