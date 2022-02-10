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
            this.bt_novaTela = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // bt_novaTela
            // 
            this.bt_novaTela.Location = new System.Drawing.Point(5, 319);
            this.bt_novaTela.Name = "bt_novaTela";
            this.bt_novaTela.Size = new System.Drawing.Size(224, 23);
            this.bt_novaTela.TabIndex = 5;
            this.bt_novaTela.Text = "Nova Tela Veiculos";
            this.bt_novaTela.UseVisualStyleBackColor = true;
            this.bt_novaTela.Click += new System.EventHandler(this.bt_novaTela_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkedBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.ComboBox,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkedBoxToolStripMenuItem
            // 
            this.checkedBoxToolStripMenuItem.Name = "checkedBoxToolStripMenuItem";
            this.checkedBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedBoxToolStripMenuItem.Text = "CheckedBox";
            this.checkedBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "Checked List Box";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(180, 22);
            this.ComboBox.Text = "Combo Box";
            this.ComboBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // CheckdListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 378);
            this.Controls.Add(this.bt_novaTela);
            this.Controls.Add(this.txt_listaVeiculos);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.txt_veiculos);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CheckdListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedBox";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.TextBox txt_veiculos;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.TextBox txt_listaVeiculos;
        private System.Windows.Forms.Button bt_novaTela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComboBox;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
    }
}

