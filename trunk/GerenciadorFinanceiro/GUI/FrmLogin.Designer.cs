namespace GerenciadorFinanceiro.GUI
{
    partial class FrmLogin
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
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.LnkEsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpEsqueciMinhaSenha = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelarEsqueciMinhaSenha = new System.Windows.Forms.Button();
            this.BtnEnviarEmail = new System.Windows.Forms.Button();
            this.PcbImagem = new System.Windows.Forms.PictureBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.GrpLogin.SuspendLayout();
            this.GrpEsqueciMinhaSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.LnkEsqueciMinhaSenha);
            this.GrpLogin.Controls.Add(this.BtnCancelar);
            this.GrpLogin.Controls.Add(this.TxtPassword);
            this.GrpLogin.Controls.Add(this.label2);
            this.GrpLogin.Controls.Add(this.BtnLogar);
            this.GrpLogin.Controls.Add(this.TxtUsername);
            this.GrpLogin.Controls.Add(this.label1);
            this.GrpLogin.Location = new System.Drawing.Point(153, 12);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(285, 130);
            this.GrpLogin.TabIndex = 0;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "Identificação ";
            // 
            // LnkEsqueciMinhaSenha
            // 
            this.LnkEsqueciMinhaSenha.AutoSize = true;
            this.LnkEsqueciMinhaSenha.Location = new System.Drawing.Point(162, 77);
            this.LnkEsqueciMinhaSenha.Name = "LnkEsqueciMinhaSenha";
            this.LnkEsqueciMinhaSenha.Size = new System.Drawing.Size(111, 13);
            this.LnkEsqueciMinhaSenha.TabIndex = 4;
            this.LnkEsqueciMinhaSenha.TabStop = true;
            this.LnkEsqueciMinhaSenha.Text = "Esqueci Minha Senha";
            this.LnkEsqueciMinhaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkEsqueciMinhaSenha_LinkClicked);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(198, 98);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 25);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "    Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(66, 50);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(207, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Text = "admin";
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha :";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(66, 22);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(207, 20);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário :";
            // 
            // GrpEsqueciMinhaSenha
            // 
            this.GrpEsqueciMinhaSenha.Controls.Add(this.BtnCancelarEsqueciMinhaSenha);
            this.GrpEsqueciMinhaSenha.Controls.Add(this.label3);
            this.GrpEsqueciMinhaSenha.Controls.Add(this.BtnEnviarEmail);
            this.GrpEsqueciMinhaSenha.Controls.Add(this.TxtEmail);
            this.GrpEsqueciMinhaSenha.Location = new System.Drawing.Point(153, 12);
            this.GrpEsqueciMinhaSenha.Name = "GrpEsqueciMinhaSenha";
            this.GrpEsqueciMinhaSenha.Size = new System.Drawing.Size(285, 130);
            this.GrpEsqueciMinhaSenha.TabIndex = 5;
            this.GrpEsqueciMinhaSenha.TabStop = false;
            this.GrpEsqueciMinhaSenha.Text = "Esqueci Minha Senha ";
            this.GrpEsqueciMinhaSenha.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(52, 42);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(221, 20);
            this.TxtEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email :";
            // 
            // BtnCancelarEsqueciMinhaSenha
            // 
            this.BtnCancelarEsqueciMinhaSenha.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelarEsqueciMinhaSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEsqueciMinhaSenha.Location = new System.Drawing.Point(165, 74);
            this.BtnCancelarEsqueciMinhaSenha.Name = "BtnCancelarEsqueciMinhaSenha";
            this.BtnCancelarEsqueciMinhaSenha.Size = new System.Drawing.Size(108, 25);
            this.BtnCancelarEsqueciMinhaSenha.TabIndex = 6;
            this.BtnCancelarEsqueciMinhaSenha.Text = "Cancelar";
            this.BtnCancelarEsqueciMinhaSenha.UseVisualStyleBackColor = true;
            this.BtnCancelarEsqueciMinhaSenha.Click += new System.EventHandler(this.BtnCancelarEsqueciMinhaSenha_Click);
            // 
            // BtnEnviarEmail
            // 
            this.BtnEnviarEmail.Image = global::GerenciadorFinanceiro.Properties.Resources.mail_send;
            this.BtnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnviarEmail.Location = new System.Drawing.Point(52, 74);
            this.BtnEnviarEmail.Name = "BtnEnviarEmail";
            this.BtnEnviarEmail.Size = new System.Drawing.Size(108, 25);
            this.BtnEnviarEmail.TabIndex = 4;
            this.BtnEnviarEmail.Text = "Enviar Email";
            this.BtnEnviarEmail.UseVisualStyleBackColor = true;
            this.BtnEnviarEmail.Click += new System.EventHandler(this.BtnEnviarEmail_Click);
            // 
            // PcbImagem
            // 
            this.PcbImagem.Image = global::GerenciadorFinanceiro.Properties.Resources.Login;
            this.PcbImagem.Location = new System.Drawing.Point(12, 12);
            this.PcbImagem.Name = "PcbImagem";
            this.PcbImagem.Size = new System.Drawing.Size(130, 130);
            this.PcbImagem.TabIndex = 4;
            this.PcbImagem.TabStop = false;
            // 
            // BtnLogar
            // 
            this.BtnLogar.Image = global::GerenciadorFinanceiro.Properties.Resources.apply;
            this.BtnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogar.Location = new System.Drawing.Point(102, 98);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(75, 25);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "OK";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 157);
            this.Controls.Add(this.GrpEsqueciMinhaSenha);
            this.Controls.Add(this.PcbImagem);
            this.Controls.Add(this.GrpLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            this.GrpEsqueciMinhaSenha.ResumeLayout(false);
            this.GrpEsqueciMinhaSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.PictureBox PcbImagem;
        private System.Windows.Forms.LinkLabel LnkEsqueciMinhaSenha;
        private System.Windows.Forms.GroupBox GrpEsqueciMinhaSenha;
        private System.Windows.Forms.Button BtnCancelarEsqueciMinhaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEnviarEmail;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}