namespace GerenciadorFinanceiro.Controles
{
    partial class CtrNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Image = global::GerenciadorFinanceiro.Properties.Resources.ultimo;
            this.BtnUltimo.Location = new System.Drawing.Point(123, 3);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(35, 28);
            this.BtnUltimo.TabIndex = 3;
            this.toolTip.SetToolTip(this.BtnUltimo, "Último");
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Image = global::GerenciadorFinanceiro.Properties.Resources.proximo;
            this.BtnProximo.Location = new System.Drawing.Point(83, 3);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(35, 28);
            this.BtnProximo.TabIndex = 2;
            this.toolTip.SetToolTip(this.BtnProximo, "Próximo");
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Image = global::GerenciadorFinanceiro.Properties.Resources.anterior;
            this.BtnAnterior.Location = new System.Drawing.Point(43, 3);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(35, 28);
            this.BtnAnterior.TabIndex = 1;
            this.toolTip.SetToolTip(this.BtnAnterior, "Anterior");
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Image = global::GerenciadorFinanceiro.Properties.Resources.primeiro;
            this.BtnPrimeiro.Location = new System.Drawing.Point(3, 3);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(35, 28);
            this.BtnPrimeiro.TabIndex = 0;
            this.toolTip.SetToolTip(this.BtnPrimeiro, "Primeiro");
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::GerenciadorFinanceiro.Properties.Resources.trash;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(463, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(70, 28);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "     Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::GerenciadorFinanceiro.Properties.Resources.disc;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(388, 3);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(70, 28);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "     Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(313, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(70, 28);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = global::GerenciadorFinanceiro.Properties.Resources.file_edit;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(238, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 28);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "    Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(163, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(70, 28);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "     Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Controls.Add(this.BtnPrimeiro);
            this.PnlBotoes.Controls.Add(this.BtnExcluir);
            this.PnlBotoes.Controls.Add(this.BtnAnterior);
            this.PnlBotoes.Controls.Add(this.BtnSalvar);
            this.PnlBotoes.Controls.Add(this.BtnProximo);
            this.PnlBotoes.Controls.Add(this.BtnCancelar);
            this.PnlBotoes.Controls.Add(this.BtnUltimo);
            this.PnlBotoes.Controls.Add(this.BtnEditar);
            this.PnlBotoes.Controls.Add(this.BtnNovo);
            this.PnlBotoes.Location = new System.Drawing.Point(4, 4);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(538, 34);
            this.PnlBotoes.TabIndex = 9;
            // 
            // CtrNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlBotoes);
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "CtrNavigator";
            this.Size = new System.Drawing.Size(547, 42);
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Panel PnlBotoes;
    }
}
