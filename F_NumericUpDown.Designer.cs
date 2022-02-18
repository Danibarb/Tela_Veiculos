namespace Tela_Veiculos
{
    partial class F_NumericUpDown
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
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_definirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown
            // 
            this.numUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown.Location = new System.Drawing.Point(15, 18);
            this.numUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(135, 20);
            this.numUpDown.TabIndex = 0;
            this.numUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(185, 18);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(300, 14);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(91, 26);
            this.btn_definirValor.TabIndex = 3;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 319);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.numUpDown);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            this.Load += new System.EventHandler(this.F_NumericUpDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_definirValor;
    }
}