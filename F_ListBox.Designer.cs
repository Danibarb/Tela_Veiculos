namespace Tela_Veiculos
{
    partial class F_ListBox
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
            this.listB_Carros = new System.Windows.Forms.ListBox();
            this.lb_Carros = new System.Windows.Forms.Label();
            this.txt_Carros = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listB_Carros
            // 
            this.listB_Carros.FormattingEnabled = true;
            this.listB_Carros.Location = new System.Drawing.Point(5, 12);
            this.listB_Carros.Name = "listB_Carros";
            this.listB_Carros.Size = new System.Drawing.Size(149, 173);
            this.listB_Carros.TabIndex = 0;
            this.listB_Carros.SelectedIndexChanged += new System.EventHandler(this.listB_Carros_SelectedIndexChanged);
            // 
            // lb_Carros
            // 
            this.lb_Carros.AutoSize = true;
            this.lb_Carros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Carros.Location = new System.Drawing.Point(168, 21);
            this.lb_Carros.Name = "lb_Carros";
            this.lb_Carros.Size = new System.Drawing.Size(130, 16);
            this.lb_Carros.TabIndex = 1;
            this.lb_Carros.Text = "Digite um Automóvel";
            // 
            // txt_Carros
            // 
            this.txt_Carros.Location = new System.Drawing.Point(171, 40);
            this.txt_Carros.Name = "txt_Carros";
            this.txt_Carros.Size = new System.Drawing.Size(123, 20);
            this.txt_Carros.TabIndex = 2;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(171, 75);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(123, 21);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(171, 102);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(123, 21);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(171, 129);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(123, 21);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 226);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_Carros);
            this.Controls.Add(this.lb_Carros);
            this.Controls.Add(this.listB_Carros);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.Load += new System.EventHandler(this.F_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listB_Carros;
        private System.Windows.Forms.Label lb_Carros;
        private System.Windows.Forms.TextBox txt_Carros;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}