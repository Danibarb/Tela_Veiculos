namespace Tela_Veiculos
{
    partial class F_MaskedTextBox
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
            this.maskTxt_senha = new System.Windows.Forms.MaskedTextBox();
            this.lbl_maskSenha = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.maskTxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.maskTxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.maskTxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btnMasks = new System.Windows.Forms.Button();
            this.cbox_visualizarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // maskTxt_senha
            // 
            this.maskTxt_senha.Location = new System.Drawing.Point(12, 27);
            this.maskTxt_senha.Name = "maskTxt_senha";
            this.maskTxt_senha.PasswordChar = '*';
            this.maskTxt_senha.Size = new System.Drawing.Size(220, 20);
            this.maskTxt_senha.TabIndex = 0;
            this.maskTxt_senha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskTxt_senha_MaskInputRejected);
            // 
            // lbl_maskSenha
            // 
            this.lbl_maskSenha.AutoSize = true;
            this.lbl_maskSenha.Location = new System.Drawing.Point(10, 11);
            this.lbl_maskSenha.Name = "lbl_maskSenha";
            this.lbl_maskSenha.Size = new System.Drawing.Size(38, 13);
            this.lbl_maskSenha.TabIndex = 1;
            this.lbl_maskSenha.Text = "Senha";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(9, 67);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 3;
            this.lbl_cep.Text = "CEP";
            // 
            // maskTxt_cep
            // 
            this.maskTxt_cep.Location = new System.Drawing.Point(11, 83);
            this.maskTxt_cep.Mask = "00000-000";
            this.maskTxt_cep.Name = "maskTxt_cep";
            this.maskTxt_cep.Size = new System.Drawing.Size(221, 20);
            this.maskTxt_cep.TabIndex = 2;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(12, 118);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 5;
            this.lbl_telefone.Text = "Telefone";
            // 
            // maskTxt_telefone
            // 
            this.maskTxt_telefone.Location = new System.Drawing.Point(14, 134);
            this.maskTxt_telefone.Mask = "(00)0000-0000";
            this.maskTxt_telefone.Name = "maskTxt_telefone";
            this.maskTxt_telefone.Size = new System.Drawing.Size(221, 20);
            this.maskTxt_telefone.TabIndex = 4;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(12, 166);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 7;
            this.lbl_cpf.Text = "CPF";
            // 
            // maskTxt_cpf
            // 
            this.maskTxt_cpf.Location = new System.Drawing.Point(14, 182);
            this.maskTxt_cpf.Mask = "000.000.000-00";
            this.maskTxt_cpf.Name = "maskTxt_cpf";
            this.maskTxt_cpf.Size = new System.Drawing.Size(221, 20);
            this.maskTxt_cpf.TabIndex = 6;
            this.maskTxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnMasks
            // 
            this.btnMasks.Location = new System.Drawing.Point(272, 181);
            this.btnMasks.Name = "btnMasks";
            this.btnMasks.Size = new System.Drawing.Size(93, 21);
            this.btnMasks.TabIndex = 8;
            this.btnMasks.Text = "Máscaras";
            this.btnMasks.UseVisualStyleBackColor = true;
            this.btnMasks.Click += new System.EventHandler(this.btnMasks_Click);
            // 
            // cbox_visualizarSenha
            // 
            this.cbox_visualizarSenha.AutoSize = true;
            this.cbox_visualizarSenha.Location = new System.Drawing.Point(239, 29);
            this.cbox_visualizarSenha.Name = "cbox_visualizarSenha";
            this.cbox_visualizarSenha.Size = new System.Drawing.Size(104, 17);
            this.cbox_visualizarSenha.TabIndex = 9;
            this.cbox_visualizarSenha.Text = "Visualizar Senha";
            this.cbox_visualizarSenha.UseVisualStyleBackColor = true;
            this.cbox_visualizarSenha.CheckedChanged += new System.EventHandler(this.cbox_visualizarSenha_CheckedChanged);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.cbox_visualizarSenha);
            this.Controls.Add(this.btnMasks);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.maskTxt_cpf);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.maskTxt_telefone);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.maskTxt_cep);
            this.Controls.Add(this.lbl_maskSenha);
            this.Controls.Add(this.maskTxt_senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskTxt_senha;
        private System.Windows.Forms.Label lbl_maskSenha;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.MaskedTextBox maskTxt_cep;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.MaskedTextBox maskTxt_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox maskTxt_cpf;
        private System.Windows.Forms.Button btnMasks;
        private System.Windows.Forms.CheckBox cbox_visualizarSenha;
    }
}