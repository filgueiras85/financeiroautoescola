namespace GerenciadorFinanceiro.Configuracao
{
    partial class FrmRestaurarBackup
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
            this.GrpRestauracaodoSistema = new System.Windows.Forms.GroupBox();
            this.BtnRealizarBackupAgora = new System.Windows.Forms.Button();
            this.CmbListaBackups = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrpRestauracaodoSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpRestauracaodoSistema
            // 
            this.GrpRestauracaodoSistema.Controls.Add(this.BtnRealizarBackupAgora);
            this.GrpRestauracaodoSistema.Controls.Add(this.CmbListaBackups);
            this.GrpRestauracaodoSistema.Controls.Add(this.label7);
            this.GrpRestauracaodoSistema.Location = new System.Drawing.Point(15, 12);
            this.GrpRestauracaodoSistema.Name = "GrpRestauracaodoSistema";
            this.GrpRestauracaodoSistema.Size = new System.Drawing.Size(351, 140);
            this.GrpRestauracaodoSistema.TabIndex = 0;
            this.GrpRestauracaodoSistema.TabStop = false;
            this.GrpRestauracaodoSistema.Text = "Restauração do Sistema ";
            // 
            // BtnRealizarBackupAgora
            // 
            this.BtnRealizarBackupAgora.Location = new System.Drawing.Point(158, 90);
            this.BtnRealizarBackupAgora.Name = "BtnRealizarBackupAgora";
            this.BtnRealizarBackupAgora.Size = new System.Drawing.Size(167, 25);
            this.BtnRealizarBackupAgora.TabIndex = 27;
            this.BtnRealizarBackupAgora.Text = "Restaurar backup Agora ?";
            this.BtnRealizarBackupAgora.UseVisualStyleBackColor = true;
            this.BtnRealizarBackupAgora.Click += new System.EventHandler(this.BtnRealizarBackupAgora_Click);
            // 
            // CmbListaBackups
            // 
            this.CmbListaBackups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbListaBackups.FormattingEnabled = true;
            this.CmbListaBackups.Location = new System.Drawing.Point(26, 50);
            this.CmbListaBackups.Name = "CmbListaBackups";
            this.CmbListaBackups.Size = new System.Drawing.Size(299, 21);
            this.CmbListaBackups.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Selecione o Backup que deseja Restaurar :";
            // 
            // FrmRestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 167);
            this.Controls.Add(this.GrpRestauracaodoSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestaurarBackup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurar Backup do Sistema";
            this.Load += new System.EventHandler(this.FrmRestaurarBackup_Load);
            this.GrpRestauracaodoSistema.ResumeLayout(false);
            this.GrpRestauracaodoSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpRestauracaodoSistema;
        private System.Windows.Forms.ComboBox CmbListaBackups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRealizarBackupAgora;
    }
}