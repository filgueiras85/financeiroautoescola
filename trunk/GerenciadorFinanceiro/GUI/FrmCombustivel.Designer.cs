namespace GerenciadorFinanceiro.GUI
{
    partial class FrmCombustivel
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
            this.components = new System.ComponentModel.Container();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.btnUltimoKm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoComb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataAbastec = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new GerenciadorFinanceiro.Controles.FormatTextBox();
            this.SuspendLayout();
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(128, 12);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(220, 21);
            this.cmbVeiculo.TabIndex = 0;
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.Location = new System.Drawing.Point(128, 48);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(100, 20);
            this.txtKmInicial.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(52, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Veículo :";
            // 
            // btnAddVeiculo
            // 
            this.btnAddVeiculo.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.btnAddVeiculo.Location = new System.Drawing.Point(354, 9);
            this.btnAddVeiculo.Name = "btnAddVeiculo";
            this.btnAddVeiculo.Size = new System.Drawing.Size(31, 24);
            this.btnAddVeiculo.TabIndex = 14;
            this.btnAddVeiculo.UseVisualStyleBackColor = true;
            this.btnAddVeiculo.Click += new System.EventHandler(this.btnAddVeiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Km final :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Km inicial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Qnt de litros :";
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(128, 83);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(100, 20);
            this.txtKmFinal.TabIndex = 17;
            // 
            // btnUltimoKm
            // 
            this.btnUltimoKm.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.btnUltimoKm.Location = new System.Drawing.Point(234, 45);
            this.btnUltimoKm.Name = "btnUltimoKm";
            this.btnUltimoKm.Size = new System.Drawing.Size(31, 24);
            this.btnUltimoKm.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnUltimoKm, "Última km anotada.");
            this.btnUltimoKm.UseVisualStyleBackColor = true;
            this.btnUltimoKm.Click += new System.EventHandler(this.btnUltimoKm_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(128, 118);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 20);
            this.txtLitros.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor total :";
            // 
            // cmbTipoComb
            // 
            this.cmbTipoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComb.FormattingEnabled = true;
            this.cmbTipoComb.Items.AddRange(new object[] {
            "Gasolina",
            "Alcool",
            "Diesel",
            "Flex",
            "Gás"});
            this.cmbTipoComb.Location = new System.Drawing.Point(128, 188);
            this.cmbTipoComb.Name = "cmbTipoComb";
            this.cmbTipoComb.Size = new System.Drawing.Size(179, 21);
            this.cmbTipoComb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipo comb. :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(128, 265);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Data Abastec. :";
            // 
            // txtDataAbastec
            // 
            this.txtDataAbastec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataAbastec.Location = new System.Drawing.Point(128, 226);
            this.txtDataAbastec.Name = "txtDataAbastec";
            this.txtDataAbastec.Size = new System.Drawing.Size(100, 20);
            this.txtDataAbastec.TabIndex = 28;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(128, 153);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 26;
            // 
            // FrmCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 303);
            this.Controls.Add(this.txtDataAbastec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoComb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.btnUltimoKm);
            this.Controls.Add(this.txtKmFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddVeiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKmInicial);
            this.Controls.Add(this.cmbVeiculo);
            this.Name = "FrmCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar despesas de combustível";
            this.Load += new System.EventHandler(this.FrmCombustivel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.Button btnUltimoKm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoComb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private GerenciadorFinanceiro.Controles.FormatTextBox txtValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDataAbastec;
    }
}