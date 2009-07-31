namespace GerenciadorFinanceiro.GUI
{
    partial class FrmDespesa
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
            this.DGDespesas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGDespesas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGDespesas
            // 
            this.DGDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDespesas.Location = new System.Drawing.Point(13, 333);
            this.DGDespesas.Name = "DGDespesas";
            this.DGDespesas.Size = new System.Drawing.Size(484, 150);
            this.DGDespesas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(94, 88);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(236, 20);
            this.TxtDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Vcto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Forma Pgto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Despesa :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(24, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesa ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(205, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mensal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Parcelada";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Única";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.PnlBotoes.Location = new System.Drawing.Point(10, 7);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(538, 34);
            this.PnlBotoes.TabIndex = 19;
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Image = global::GerenciadorFinanceiro.Properties.Resources.primeiro;
            this.BtnPrimeiro.Location = new System.Drawing.Point(3, 3);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(35, 28);
            this.BtnPrimeiro.TabIndex = 0;
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
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
            // BtnAnterior
            // 
            this.BtnAnterior.Image = global::GerenciadorFinanceiro.Properties.Resources.anterior;
            this.BtnAnterior.Location = new System.Drawing.Point(43, 3);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(35, 28);
            this.BtnAnterior.TabIndex = 1;
            this.BtnAnterior.UseVisualStyleBackColor = true;
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
            // BtnProximo
            // 
            this.BtnProximo.Image = global::GerenciadorFinanceiro.Properties.Resources.proximo;
            this.BtnProximo.Location = new System.Drawing.Point(83, 3);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(35, 28);
            this.BtnProximo.TabIndex = 2;
            this.BtnProximo.UseVisualStyleBackColor = true;
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
            // BtnUltimo
            // 
            this.BtnUltimo.Image = global::GerenciadorFinanceiro.Properties.Resources.ultimo;
            this.BtnUltimo.Location = new System.Drawing.Point(123, 3);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(35, 28);
            this.BtnUltimo.TabIndex = 3;
            this.BtnUltimo.UseVisualStyleBackColor = true;
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
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 504);
            this.Controls.Add(this.PnlBotoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGDespesas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.DGDespesas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
    }
}