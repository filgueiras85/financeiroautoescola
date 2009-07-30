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
            this.GrpBancoDados.SuspendLayout();
            this.GrpUsuario.SuspendLayout();
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
            this.GrpBancoDados.Location = new System.Drawing.Point(12, 12);
            this.GrpBancoDados.Name = "GrpBancoDados";
            this.GrpBancoDados.Size = new System.Drawing.Size(450, 153);
            this.GrpBancoDados.TabIndex = 0;
            this.GrpBancoDados.TabStop = false;
            this.GrpBancoDados.Text = "Banco de dados";
            // 
            // BtnRealizarBackupAgora
            // 
            this.BtnRealizarBackupAgora.Location = new System.Drawing.Point(315, 112);
            this.BtnRealizarBackupAgora.Name = "BtnRealizarBackupAgora";
            this.BtnRealizarBackupAgora.Size = new System.Drawing.Size(128, 25);
            this.BtnRealizarBackupAgora.TabIndex = 7;
            this.BtnRealizarBackupAgora.Text = "Realizar backup agora";
            this.BtnRealizarBackupAgora.UseVisualStyleBackColor = true;
            this.BtnRealizarBackupAgora.Click += new System.EventHandler(this.BtnRealizarBackupAgora_Click);
            // 
            // chkRealizarBackup
            // 
            this.chkRealizarBackup.AutoSize = true;
            this.chkRealizarBackup.Location = new System.Drawing.Point(18, 117);
            this.chkRealizarBackup.Name = "chkRealizarBackup";
            this.chkRealizarBackup.Size = new System.Drawing.Size(199, 17);
            this.chkRealizarBackup.TabIndex = 6;
            this.chkRealizarBackup.Text = "Realizar backup ao sair do programa";
            this.chkRealizarBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local para o backup";
            // 
            // BtnLocalBackup
            // 
            this.BtnLocalBackup.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.BtnLocalBackup.Location = new System.Drawing.Point(409, 75);
            this.BtnLocalBackup.Name = "BtnLocalBackup";
            this.BtnLocalBackup.Size = new System.Drawing.Size(34, 23);
            this.BtnLocalBackup.TabIndex = 4;
            this.BtnLocalBackup.UseVisualStyleBackColor = true;
            this.BtnLocalBackup.Click += new System.EventHandler(this.BtnLocalBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(18, 77);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(387, 20);
            this.txtBackup.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
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
            this.GrpUsuario.Location = new System.Drawing.Point(12, 171);
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
            this.BtnConfirmar.Location = new System.Drawing.Point(350, 264);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(112, 25);
            this.BtnConfirmar.TabIndex = 2;
            this.BtnConfirmar.Text = "      Confirmar Dados";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 301);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.GrpUsuario);
            this.Controls.Add(this.GrpBancoDados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracao";
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            this.GrpBancoDados.ResumeLayout(false);
            this.GrpBancoDados.PerformLayout();
            this.GrpUsuario.ResumeLayout(false);
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
    }
}