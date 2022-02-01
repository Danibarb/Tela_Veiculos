namespace Tela_Veiculos
{
    partial class CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostraSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_adicionarNovoTransporte = new System.Windows.Forms.Button();
            this.txt_AdicionarNovoTransporte = new System.Windows.Forms.TextBox();
            this.lbl_NovoTrasporte = new System.Windows.Forms.Label();
            this.btn_desmarcarItens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Onibus",
            "Avião",
            "Navio",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(7, 14);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(136, 334);
            this.clb_transportes.TabIndex = 0;
            this.clb_transportes.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_mostraSelecionados
            // 
            this.btn_mostraSelecionados.Location = new System.Drawing.Point(149, 14);
            this.btn_mostraSelecionados.Name = "btn_mostraSelecionados";
            this.btn_mostraSelecionados.Size = new System.Drawing.Size(119, 24);
            this.btn_mostraSelecionados.TabIndex = 1;
            this.btn_mostraSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostraSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostraSelecionados.Click += new System.EventHandler(this.btn_mostraSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(149, 46);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(119, 24);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(148, 106);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(119, 24);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_adicionarNovoTransporte
            // 
            this.btn_adicionarNovoTransporte.Location = new System.Drawing.Point(6, 416);
            this.btn_adicionarNovoTransporte.Name = "btn_adicionarNovoTransporte";
            this.btn_adicionarNovoTransporte.Size = new System.Drawing.Size(262, 24);
            this.btn_adicionarNovoTransporte.TabIndex = 4;
            this.btn_adicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarNovoTransporte.Click += new System.EventHandler(this.btn_adicionarNovoTransporte_Click);
            // 
            // txt_AdicionarNovoTransporte
            // 
            this.txt_AdicionarNovoTransporte.Location = new System.Drawing.Point(6, 390);
            this.txt_AdicionarNovoTransporte.Name = "txt_AdicionarNovoTransporte";
            this.txt_AdicionarNovoTransporte.Size = new System.Drawing.Size(261, 20);
            this.txt_AdicionarNovoTransporte.TabIndex = 5;
            // 
            // lbl_NovoTrasporte
            // 
            this.lbl_NovoTrasporte.AutoSize = true;
            this.lbl_NovoTrasporte.Location = new System.Drawing.Point(7, 374);
            this.lbl_NovoTrasporte.Name = "lbl_NovoTrasporte";
            this.lbl_NovoTrasporte.Size = new System.Drawing.Size(134, 13);
            this.lbl_NovoTrasporte.TabIndex = 6;
            this.lbl_NovoTrasporte.Text = "Digite um Novo Transporte";
            // 
            // btn_desmarcarItens
            // 
            this.btn_desmarcarItens.Location = new System.Drawing.Point(148, 76);
            this.btn_desmarcarItens.Name = "btn_desmarcarItens";
            this.btn_desmarcarItens.Size = new System.Drawing.Size(119, 24);
            this.btn_desmarcarItens.TabIndex = 7;
            this.btn_desmarcarItens.Text = "Desmarcar Itens Selecionados";
            this.btn_desmarcarItens.UseVisualStyleBackColor = true;
            this.btn_desmarcarItens.Click += new System.EventHandler(this.btn_desmarcarItens_Click);
            // 
            // CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.btn_desmarcarItens);
            this.Controls.Add(this.lbl_NovoTrasporte);
            this.Controls.Add(this.txt_AdicionarNovoTransporte);
            this.Controls.Add(this.btn_adicionarNovoTransporte);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostraSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.Name = "CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostraSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_adicionarNovoTransporte;
        private System.Windows.Forms.TextBox txt_AdicionarNovoTransporte;
        private System.Windows.Forms.Label lbl_NovoTrasporte;
        private System.Windows.Forms.Button btn_desmarcarItens;
    }
}