namespace GerenciadorFinanceiro.Configuracao
{
    partial class FrmConfiguracao
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
            this.GrpBancoDados = new System.Windows.Forms.GroupBox();
            this.BtnRealizarBackupAgora = new System.Windows.Forms.Button();
            this.chkRealizarBackup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLocalBackup = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLocalBancoDados = new System.Windows.Forms.Button();
            this.txtLocalBanco = new System.Windows.Forms.TextBox();
            this.GrpUsuario = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.TabBancoDadosBackup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabEmail = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkRequerAutenticacao = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtServidorSMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRemetente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.GrpAutenticacao = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUsuarioAutenticar = new System.Windows.Forms.TextBox();
            this.TxtSenhaAutenticacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GrpBancoDados.SuspendLayout();
            this.GrpUsuario.SuspendLayout();
            this.TabBancoDadosBackup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabEmail.SuspendLayout();
            this.GrpAutenticacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBancoDados
            // 
            this.GrpBancoDados.Controls.Add(this.BtnRealizarBackupAgora);
            this.GrpBancoDados.Controls.Add(this.chkRealizarBackup);
            this.GrpBancoDados.Controls.Add(this.label2);
            this.GrpBancoDados.Controls.Add(this.BtnLocalBackup);
            this.GrpBancoDados.Controls.Add(this.txtBackup);
            this.GrpBancoDados.Controls.Add(this.label1);
            this.GrpBancoDados.Controls.Add(this.BtnLocalBancoDados);
            this.GrpBancoDados.Controls.Add(this.txtLocalBanco);
            this.GrpBancoDados.Location = new System.Drawing.Point(17, 20);
            this.GrpBancoDados.Name = "GrpBancoDados";
            this.GrpBancoDados.Size = new System.Drawing.Size(450, 153);
            this.GrpBancoDados.TabIndex = 0;
            this.GrpBancoDados.TabStop = false;
            this.GrpBancoDados.Text = "Banco de dados";
            // 
            // BtnRealizarBackupAgora
            // 
            this.BtnRealizarBackupAgora.Location = new System.Drawing.Point(304, 112);
            this.BtnRealizarBackupAgora.Name = "BtnRealizarBackupAgora";
            this.BtnRealizarBackupAgora.Size = new System.Drawing.Size(139, 25);
            this.BtnRealizarBackupAgora.TabIndex = 5;
            this.BtnRealizarBackupAgora.Text = "Realizar backup agora";
            this.BtnRealizarBackupAgora.UseVisualStyleBackColor = true;
            this.BtnRealizarBackupAgora.Click += new System.EventHandler(this.BtnRealizarBackupAgora_Click);
            // 
            // chkRealizarBackup
            // 
            this.chkRealizarBackup.AutoSize = true;
            this.chkRealizarBackup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chkRealizarBackup.Location = new System.Drawing.Point(18, 117);
            this.chkRealizarBackup.Name = "chkRealizarBackup";
            this.chkRealizarBackup.Size = new System.Drawing.Size(235, 19);
            this.chkRealizarBackup.TabIndex = 4;
            this.chkRealizarBackup.Text = "Realizar backup ao sair do programa";
            this.chkRealizarBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local para o backup";
            // 
            // BtnLocalBackup
            // 
            this.BtnLocalBackup.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.BtnLocalBackup.Location = new System.Drawing.Point(409, 75);
            this.BtnLocalBackup.Name = "BtnLocalBackup";
            this.BtnLocalBackup.Size = new System.Drawing.Size(34, 23);
            this.BtnLocalBackup.TabIndex = 3;
            this.BtnLocalBackup.UseVisualStyleBackColor = true;
            this.BtnLocalBackup.Click += new System.EventHandler(this.BtnLocalBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(18, 77);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(387, 20);
            this.txtBackup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local do banco de dados";
            // 
            // BtnLocalBancoDados
            // 
            this.BtnLocalBancoDados.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.BtnLocalBancoDados.Location = new System.Drawing.Point(409, 36);
            this.BtnLocalBancoDados.Name = "BtnLocalBancoDados";
            this.BtnLocalBancoDados.Size = new System.Drawing.Size(34, 23);
            this.BtnLocalBancoDados.TabIndex = 1;
            this.BtnLocalBancoDados.UseVisualStyleBackColor = true;
            this.BtnLocalBancoDados.Click += new System.EventHandler(this.BtnLocalBancoDados_Click);
            // 
            // txtLocalBanco
            // 
            this.txtLocalBanco.Location = new System.Drawing.Point(18, 38);
            this.txtLocalBanco.Name = "txtLocalBanco";
            this.txtLocalBanco.Size = new System.Drawing.Size(387, 20);
            this.txtLocalBanco.TabIndex = 0;
            // 
            // GrpUsuario
            // 
            this.GrpUsuario.Controls.Add(this.button1);
            this.GrpUsuario.Location = new System.Drawing.Point(17, 179);
            this.GrpUsuario.Name = "GrpUsuario";
            this.GrpUsuario.Size = new System.Drawing.Size(450, 81);
            this.GrpUsuario.TabIndex = 1;
            this.GrpUsuario.TabStop = false;
            this.GrpUsuario.Text = "Usuários";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar usuários";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.Image = global::GerenciadorFinanceiro.Properties.Resources.apply;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.Location = new System.Drawing.Point(389, 328);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(112, 25);
            this.BtnConfirmar.TabIndex = 1;
            this.BtnConfirmar.Text = "      Confirmar Dados";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.button5_Click);
            // 
            // TabBancoDadosBackup
            // 
            this.TabBancoDadosBackup.Controls.Add(this.tabPage1);
            this.TabBancoDadosBackup.Controls.Add(this.TabEmail);
            this.TabBancoDadosBackup.Location = new System.Drawing.Point(12, 12);
            this.TabBancoDadosBackup.Name = "TabBancoDadosBackup";
            this.TabBancoDadosBackup.SelectedIndex = 0;
            this.TabBancoDadosBackup.Size = new System.Drawing.Size(493, 306);
            this.TabBancoDadosBackup.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.GrpBancoDados);
            this.tabPage1.Controls.Add(this.GrpUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Banco de dados e Backup ";
            // 
            // TabEmail
            // 
            this.TabEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TabEmail.Controls.Add(this.label10);
            this.TabEmail.Controls.Add(this.label5);
            this.TabEmail.Controls.Add(this.label4);
            this.TabEmail.Controls.Add(this.ChkRequerAutenticacao);
            this.TabEmail.Controls.Add(this.label7);
            this.TabEmail.Controls.Add(this.TxtServidorSMTP);
            this.TabEmail.Controls.Add(this.label6);
            this.TabEmail.Controls.Add(this.TxtRemetente);
            this.TabEmail.Controls.Add(this.label3);
            this.TabEmail.Controls.Add(this.TxtEmail);
            this.TabEmail.Controls.Add(this.GrpAutenticacao);
            this.TabEmail.Location = new System.Drawing.Point(4, 22);
            this.TabEmail.Name = "TabEmail";
            this.TabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.TabEmail.Size = new System.Drawing.Size(485, 280);
            this.TabEmail.TabIndex = 1;
            this.TabEmail.Text = "Configuração de Email ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(280, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "( ex: smtp.nomedominio.com.br )";
            // 
            // ChkRequerAutenticacao
            // 
            this.ChkRequerAutenticacao.AutoSize = true;
            this.ChkRequerAutenticacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ChkRequerAutenticacao.Location = new System.Drawing.Point(44, 153);
            this.ChkRequerAutenticacao.Name = "ChkRequerAutenticacao";
            this.ChkRequerAutenticacao.Size = new System.Drawing.Size(218, 19);
            this.ChkRequerAutenticacao.TabIndex = 3;
            this.ChkRequerAutenticacao.Text = "Meu servidor requer autenticação";
            this.ChkRequerAutenticacao.UseVisualStyleBackColor = true;
            this.ChkRequerAutenticacao.CheckedChanged += new System.EventHandler(this.ChkRequerAutenticacao_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(41, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Servidor SMTP";
            // 
            // TxtServidorSMTP
            // 
            this.TxtServidorSMTP.Location = new System.Drawing.Point(44, 40);
            this.TxtServidorSMTP.Name = "TxtServidorSMTP";
            this.TxtServidorSMTP.Size = new System.Drawing.Size(399, 20);
            this.TxtServidorSMTP.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(41, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remetente";
            // 
            // TxtRemetente
            // 
            this.TxtRemetente.Location = new System.Drawing.Point(44, 126);
            this.TxtRemetente.Name = "TxtRemetente";
            this.TxtRemetente.Size = new System.Drawing.Size(399, 20);
            this.TxtRemetente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(44, 83);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(399, 20);
            this.TxtEmail.TabIndex = 1;
            // 
            // GrpAutenticacao
            // 
            this.GrpAutenticacao.Controls.Add(this.label8);
            this.GrpAutenticacao.Controls.Add(this.label9);
            this.GrpAutenticacao.Controls.Add(this.TxtUsuarioAutenticar);
            this.GrpAutenticacao.Controls.Add(this.TxtSenhaAutenticacao);
            this.GrpAutenticacao.Location = new System.Drawing.Point(44, 177);
            this.GrpAutenticacao.Name = "GrpAutenticacao";
            this.GrpAutenticacao.Size = new System.Drawing.Size(399, 82);
            this.GrpAutenticacao.TabIndex = 0;
            this.GrpAutenticacao.TabStop = false;
            this.GrpAutenticacao.Text = "Autenticação ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Usuário :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(17, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Senha :";
            // 
            // TxtUsuarioAutenticar
            // 
            this.TxtUsuarioAutenticar.Enabled = false;
            this.TxtUsuarioAutenticar.Location = new System.Drawing.Point(72, 19);
            this.TxtUsuarioAutenticar.Name = "TxtUsuarioAutenticar";
            this.TxtUsuarioAutenticar.Size = new System.Drawing.Size(300, 20);
            this.TxtUsuarioAutenticar.TabIndex = 0;
            // 
            // TxtSenhaAutenticacao
            // 
            this.TxtSenhaAutenticacao.Enabled = false;
            this.TxtSenhaAutenticacao.Location = new System.Drawing.Point(72, 48);
            this.TxtSenhaAutenticacao.Name = "TxtSenhaAutenticacao";
            this.TxtSenhaAutenticacao.Size = new System.Drawing.Size(300, 20);
            this.TxtSenhaAutenticacao.TabIndex = 1;
            this.TxtSenhaAutenticacao.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(242, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "( ex: nomeconta@nomedominio.com.br )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(296, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "( ex: Nome da sua Empresa )";
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 365);
            this.Controls.Add(this.TabBancoDadosBackup);
            this.Controls.Add(this.BtnConfirmar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            this.GrpBancoDados.ResumeLayout(false);
            this.GrpBancoDados.PerformLayout();
            this.GrpUsuario.ResumeLayout(false);
            this.TabBancoDadosBackup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabEmail.ResumeLayout(false);
            this.TabEmail.PerformLayout();
            this.GrpAutenticacao.ResumeLayout(false);
            this.GrpAutenticacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBancoDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLocalBancoDados;
        private System.Windows.Forms.TextBox txtLocalBanco;
        private System.Windows.Forms.GroupBox GrpUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLocalBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Button BtnRealizarBackupAgora;
        private System.Windows.Forms.CheckBox chkRealizarBackup;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TabControl TabBancoDadosBackup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtServidorSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRemetente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.GroupBox GrpAutenticacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUsuarioAutenticar;
        private System.Windows.Forms.TextBox TxtSenhaAutenticacao;
        private System.Windows.Forms.CheckBox ChkRequerAutenticacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
    }
}