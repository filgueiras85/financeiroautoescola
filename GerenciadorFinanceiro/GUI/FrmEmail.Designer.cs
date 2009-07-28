namespace GerenciadorFinanceiro.GUI
{
    partial class FrmEmail
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
            this.LblSiglaEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDestinatario = new System.Windows.Forms.TextBox();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtnEnviarEmail = new System.Windows.Forms.Button();
            this.BtnRemoverAnexo = new System.Windows.Forms.Button();
            this.BtnAnexar = new System.Windows.Forms.Button();
            this.ListAnexos = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LblSiglaEstado
            // 
            this.LblSiglaEstado.AutoSize = true;
            this.LblSiglaEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSiglaEstado.Location = new System.Drawing.Point(27, 40);
            this.LblSiglaEstado.Name = "LblSiglaEstado";
            this.LblSiglaEstado.Size = new System.Drawing.Size(60, 15);
            this.LblSiglaEstado.TabIndex = 24;
            this.LblSiglaEstado.Text = "Assunto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Para :";
            // 
            // TxtDestinatario
            // 
            this.TxtDestinatario.BackColor = System.Drawing.Color.White;
            this.TxtDestinatario.Location = new System.Drawing.Point(93, 12);
            this.TxtDestinatario.Name = "TxtDestinatario";
            this.TxtDestinatario.Size = new System.Drawing.Size(402, 20);
            this.TxtDestinatario.TabIndex = 0;
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.BackColor = System.Drawing.Color.White;
            this.TxtAssunto.Location = new System.Drawing.Point(93, 39);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(402, 20);
            this.TxtAssunto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Anexos :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mensagem :";
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.BackColor = System.Drawing.Color.White;
            this.TxtMensagem.Location = new System.Drawing.Point(93, 155);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(402, 186);
            this.TxtMensagem.TabIndex = 5;
            // 
            // BtnEnviarEmail
            // 
            this.BtnEnviarEmail.Image = global::GerenciadorFinanceiro.Properties.Resources.mail_send;
            this.BtnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnviarEmail.Location = new System.Drawing.Point(501, 317);
            this.BtnEnviarEmail.Name = "BtnEnviarEmail";
            this.BtnEnviarEmail.Size = new System.Drawing.Size(131, 25);
            this.BtnEnviarEmail.TabIndex = 6;
            this.BtnEnviarEmail.Text = "Enviar Email";
            this.BtnEnviarEmail.UseVisualStyleBackColor = true;
            this.BtnEnviarEmail.Click += new System.EventHandler(this.BtnEnviarEmail_Click);
            // 
            // BtnRemoverAnexo
            // 
            this.BtnRemoverAnexo.Image = global::GerenciadorFinanceiro.Properties.Resources.button_cancel_excluir;
            this.BtnRemoverAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemoverAnexo.Location = new System.Drawing.Point(501, 125);
            this.BtnRemoverAnexo.Name = "BtnRemoverAnexo";
            this.BtnRemoverAnexo.Size = new System.Drawing.Size(131, 25);
            this.BtnRemoverAnexo.TabIndex = 4;
            this.BtnRemoverAnexo.Text = "Remover Anexo";
            this.BtnRemoverAnexo.UseVisualStyleBackColor = true;
            this.BtnRemoverAnexo.Click += new System.EventHandler(this.BtnRemoverAnexo_Click);
            // 
            // BtnAnexar
            // 
            this.BtnAnexar.Image = global::GerenciadorFinanceiro.Properties.Resources.attach1616;
            this.BtnAnexar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnexar.Location = new System.Drawing.Point(501, 94);
            this.BtnAnexar.Name = "BtnAnexar";
            this.BtnAnexar.Size = new System.Drawing.Size(131, 25);
            this.BtnAnexar.TabIndex = 3;
            this.BtnAnexar.Text = "Anexar";
            this.BtnAnexar.UseVisualStyleBackColor = true;
            this.BtnAnexar.Click += new System.EventHandler(this.BtnAnexar_Click);
            // 
            // ListAnexos
            // 
            this.ListAnexos.FormattingEnabled = true;
            this.ListAnexos.Location = new System.Drawing.Point(93, 66);
            this.ListAnexos.Name = "ListAnexos";
            this.ListAnexos.Size = new System.Drawing.Size(402, 82);
            this.ListAnexos.TabIndex = 29;
            // 
            // OpenFile
            // 
            this.OpenFile.Multiselect = true;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 357);
            this.Controls.Add(this.ListAnexos);
            this.Controls.Add(this.BtnEnviarEmail);
            this.Controls.Add(this.BtnRemoverAnexo);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.LblSiglaEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDestinatario);
            this.Controls.Add(this.BtnAnexar);
            this.Name = "FrmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnexar;
        private System.Windows.Forms.Label LblSiglaEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDestinatario;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtnRemoverAnexo;
        private System.Windows.Forms.Button BtnEnviarEmail;
        private System.Windows.Forms.ListBox ListAnexos;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}