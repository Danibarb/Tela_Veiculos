namespace Tela_Veiculos
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "100",
            "29,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "60",
            "49,50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "70",
            "589,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("3");
            this.listV_Produtos = new System.Windows.Forms.ListView();
            this.Col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listV_Produtos
            // 
            this.listV_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_id,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
            this.listV_Produtos.FullRowSelect = true;
            this.listV_Produtos.GridLines = true;
            this.listV_Produtos.HideSelection = false;
            this.listV_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listV_Produtos.Location = new System.Drawing.Point(4, 7);
            this.listV_Produtos.MultiSelect = false;
            this.listV_Produtos.Name = "listV_Produtos";
            this.listV_Produtos.Size = new System.Drawing.Size(424, 194);
            this.listV_Produtos.TabIndex = 0;
            this.listV_Produtos.UseCompatibleStateImageBehavior = false;
            this.listV_Produtos.View = System.Windows.Forms.View.Details;
            // 
            // Col_id
            // 
            this.Col_id.Text = "ID";
            this.Col_id.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 200;
            // 
            // col_quantidade
            // 
            this.col_quantidade.Text = "Quantidade";
            this.col_quantidade.Width = 90;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 90;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(15, 241);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "ID";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(73, 241);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(44, 13);
            this.lb_produto.TabIndex = 2;
            this.lb_produto.Text = "Produto";
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Location = new System.Drawing.Point(295, 241);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lb_quantidade.TabIndex = 3;
            this.lb_quantidade.Text = "Quantidade";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(363, 241);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(35, 13);
            this.lb_preco.TabIndex = 4;
            this.lb_preco.Text = "Preço";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(10, 257);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(44, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(68, 257);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(224, 20);
            this.txt_produto.TabIndex = 6;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(298, 257);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(55, 20);
            this.txt_quantidade.TabIndex = 7;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(359, 257);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(69, 20);
            this.txt_preco.TabIndex = 8;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(4, 305);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(101, 35);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(327, 305);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(101, 35);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 361);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_quantidade);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.listV_Produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listV_Produtos;
        private System.Windows.Forms.ColumnHeader Col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_quantidade;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
    }
}