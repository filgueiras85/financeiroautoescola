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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdbReceitas = new System.Windows.Forms.RadioButton();
            this.rdbDespesas = new System.Windows.Forms.RadioButton();
            this.cmbCentroCustos = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(108, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(227, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // rdbReceitas
            // 
            this.rdbReceitas.AutoSize = true;
            this.rdbReceitas.Location = new System.Drawing.Point(108, 60);
            this.rdbReceitas.Name = "rdbReceitas";
            this.rdbReceitas.Size = new System.Drawing.Size(67, 17);
            this.rdbReceitas.TabIndex = 4;
            this.rdbReceitas.TabStop = true;
            this.rdbReceitas.Text = "Receitas";
            this.rdbReceitas.UseVisualStyleBackColor = true;
            // 
            // rdbDespesas
            // 
            this.rdbDespesas.AutoSize = true;
            this.rdbDespesas.Location = new System.Drawing.Point(108, 89);
            this.rdbDespesas.Name = "rdbDespesas";
            this.rdbDespesas.Size = new System.Drawing.Size(72, 17);
            this.rdbDespesas.TabIndex = 5;
            this.rdbDespesas.TabStop = true;
            this.rdbDespesas.Text = "Despesas";
            this.rdbDespesas.UseVisualStyleBackColor = true;
            // 
            // cmbCentroCustos
            // 
            this.cmbCentroCustos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCustos.Enabled = false;
            this.cmbCentroCustos.FormattingEnabled = true;
            this.cmbCentroCustos.Location = new System.Drawing.Point(108, 141);
            this.cmbCentroCustos.Name = "cmbCentroCustos";
            this.cmbCentroCustos.Size = new System.Drawing.Size(282, 21);
            this.cmbCentroCustos.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sub categoria de :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 219);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbCentroCustos);
            this.Controls.Add(this.rdbDespesas);
            this.Controls.Add(this.rdbReceitas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Centro de Custos e Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbReceitas;
        private System.Windows.Forms.RadioButton rdbDespesas;
        private System.Windows.Forms.ComboBox cmbCentroCustos;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}