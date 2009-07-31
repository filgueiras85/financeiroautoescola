namespace GerenciadorFinanceiro.GUI
{
    partial class FrmCadCategoria
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
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdbReceitas = new System.Windows.Forms.RadioButton();
            this.rdbDespesas = new System.Windows.Forms.RadioButton();
            this.cmbCentroCustos = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmar.Image = global::GerenciadorFinanceiro.Properties.Resources.apply;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.Location = new System.Drawing.Point(204, 158);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(85, 25);
            this.BtnConfirmar.TabIndex = 0;
            this.BtnConfirmar.Text = "    Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(305, 158);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 25);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "    Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(108, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // rdbReceitas
            // 
            this.rdbReceitas.AutoSize = true;
            this.rdbReceitas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rdbReceitas.Location = new System.Drawing.Point(108, 50);
            this.rdbReceitas.Name = "rdbReceitas";
            this.rdbReceitas.Size = new System.Drawing.Size(75, 19);
            this.rdbReceitas.TabIndex = 4;
            this.rdbReceitas.TabStop = true;
            this.rdbReceitas.Text = "Receitas";
            this.rdbReceitas.UseVisualStyleBackColor = true;
            // 
            // rdbDespesas
            // 
            this.rdbDespesas.AutoSize = true;
            this.rdbDespesas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rdbDespesas.Location = new System.Drawing.Point(108, 75);
            this.rdbDespesas.Name = "rdbDespesas";
            this.rdbDespesas.Size = new System.Drawing.Size(82, 19);
            this.rdbDespesas.TabIndex = 5;
            this.rdbDespesas.TabStop = true;
            this.rdbDespesas.Text = "Despesas";
            this.rdbDespesas.UseVisualStyleBackColor = true;
            // 
            // cmbCentroCustos
            // 
            this.cmbCentroCustos.BackColor = System.Drawing.Color.White;
            this.cmbCentroCustos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCustos.Enabled = false;
            this.cmbCentroCustos.FormattingEnabled = true;
            this.cmbCentroCustos.Location = new System.Drawing.Point(108, 125);
            this.cmbCentroCustos.Name = "cmbCentroCustos";
            this.cmbCentroCustos.Size = new System.Drawing.Size(282, 21);
            this.cmbCentroCustos.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(108, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sub categoria de :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição :";
            // 
            // FrmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbCentroCustos);
            this.Controls.Add(this.rdbDespesas);
            this.Controls.Add(this.rdbReceitas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnConfirmar);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(431, 230);
            this.Name = "FrmCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Centro de Custos e Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbReceitas;
        private System.Windows.Forms.RadioButton rdbDespesas;
        private System.Windows.Forms.ComboBox cmbCentroCustos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}