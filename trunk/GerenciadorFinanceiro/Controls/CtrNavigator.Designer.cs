namespace GerenciadorFinanceiro.Controls
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
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnProximo
            // 
            this.BtnProximo.Image = global::GerenciadorFinanceiro.Properties.Resources.proximo;
            this.BtnProximo.Location = new System.Drawing.Point(85, 2);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(35, 28);
            this.BtnProximo.TabIndex = 2;
            this.toolTip.SetToolTip(this.BtnProximo, "Próximo");
            this.BtnProximo.UseVisualStyleBackColor = true;
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Image = global::GerenciadorFinanceiro.Properties.Resources.ultimo;
            this.BtnUltimo.Location = new System.Drawing.Point(125, 2);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(35, 28);
            this.BtnUltimo.TabIndex = 3;
            this.toolTip.SetToolTip(this.BtnUltimo, "Último");
            this.BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Image = global::GerenciadorFinanceiro.Properties.Resources.anterior;
            this.BtnAnterior.Location = new System.Drawing.Point(45, 2);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(35, 28);
            this.BtnAnterior.TabIndex = 1;
            this.toolTip.SetToolTip(this.BtnAnterior, "Anterior");
            this.BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Image = global::GerenciadorFinanceiro.Properties.Resources.primeiro;
            this.BtnPrimeiro.Location = new System.Drawing.Point(5, 2);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(35, 28);
            this.BtnPrimeiro.TabIndex = 0;
            this.toolTip.SetToolTip(this.BtnPrimeiro, "Primeiro");
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CtrNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnUltimo);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnPrimeiro);
            this.Name = "CtrNavigator";
            this.Size = new System.Drawing.Size(164, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
