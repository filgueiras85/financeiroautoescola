namespace GerenciadorFinanceiro.GUI
{
    partial class FrmReceita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNovoAluno = new System.Windows.Forms.Button();
            this.CmbAluno = new System.Windows.Forms.ComboBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoDeServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbFrequencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQntdParcelas = new System.Windows.Forms.TextBox();
            this.LblVenvimento = new System.Windows.Forms.Label();
            this.DateTimePrimeiroVencimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabInfoGeral = new System.Windows.Forms.TabPage();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DGPreviewReceita = new System.Windows.Forms.DataGridView();
            this.ColIdParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumeroDaParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabInfoAdicionais = new System.Windows.Forms.TabPage();
            this.BtnNovoServico = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabInfoGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPreviewReceita)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoAluno
            // 
            this.BtnNovoAluno.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.BtnNovoAluno.Location = new System.Drawing.Point(447, 21);
            this.BtnNovoAluno.Name = "BtnNovoAluno";
            this.BtnNovoAluno.Size = new System.Drawing.Size(31, 24);
            this.BtnNovoAluno.TabIndex = 1;
            this.BtnNovoAluno.UseVisualStyleBackColor = true;
            this.BtnNovoAluno.Click += new System.EventHandler(this.BtnNovoAluno_Click);
            // 
            // CmbAluno
            // 
            this.CmbAluno.BackColor = System.Drawing.Color.White;
            this.CmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAluno.FormattingEnabled = true;
            this.CmbAluno.Location = new System.Drawing.Point(140, 24);
            this.CmbAluno.Name = "CmbAluno";
            this.CmbAluno.Size = new System.Drawing.Size(301, 21);
            this.CmbAluno.TabIndex = 0;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BackColor = System.Drawing.Color.White;
            this.TxtObservacao.Location = new System.Drawing.Point(140, 108);
            this.TxtObservacao.MaxLength = 500;
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(338, 80);
            this.TxtObservacao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Receber de :";
            // 
            // CmbServico
            // 
            this.CmbServico.BackColor = System.Drawing.Color.White;
            this.CmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServico.FormattingEnabled = true;
            this.CmbServico.Location = new System.Drawing.Point(140, 80);
            this.CmbServico.Name = "CmbServico";
            this.CmbServico.Size = new System.Drawing.Size(301, 21);
            this.CmbServico.TabIndex = 3;
            this.CmbServico.SelectedIndexChanged += new System.EventHandler(this.CmbServico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de Serviço :";
            // 
            // CmbTipoDeServico
            // 
            this.CmbTipoDeServico.BackColor = System.Drawing.Color.White;
            this.CmbTipoDeServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeServico.FormattingEnabled = true;
            this.CmbTipoDeServico.Location = new System.Drawing.Point(140, 52);
            this.CmbTipoDeServico.Name = "CmbTipoDeServico";
            this.CmbTipoDeServico.Size = new System.Drawing.Size(338, 21);
            this.CmbTipoDeServico.TabIndex = 2;
            this.CmbTipoDeServico.SelectedIndexChanged += new System.EventHandler(this.CmbCentroDeCusto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Serviço :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Observação :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Frequencia :";
            // 
            // CmbFrequencia
            // 
            this.CmbFrequencia.BackColor = System.Drawing.Color.White;
            this.CmbFrequencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFrequencia.FormattingEnabled = true;
            this.CmbFrequencia.Location = new System.Drawing.Point(140, 195);
            this.CmbFrequencia.Name = "CmbFrequencia";
            this.CmbFrequencia.Size = new System.Drawing.Size(176, 21);
            this.CmbFrequencia.TabIndex = 5;
            this.CmbFrequencia.SelectedIndexChanged += new System.EventHandler(this.CmbFrequencia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Qntd de parcelas :";
            // 
            // TxtQntdParcelas
            // 
            this.TxtQntdParcelas.BackColor = System.Drawing.Color.White;
            this.TxtQntdParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtQntdParcelas.Location = new System.Drawing.Point(438, 195);
            this.TxtQntdParcelas.MaxLength = 10;
            this.TxtQntdParcelas.Name = "TxtQntdParcelas";
            this.TxtQntdParcelas.Size = new System.Drawing.Size(40, 20);
            this.TxtQntdParcelas.TabIndex = 6;
            // 
            // LblVenvimento
            // 
            this.LblVenvimento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVenvimento.Location = new System.Drawing.Point(3, 225);
            this.LblVenvimento.Name = "LblVenvimento";
            this.LblVenvimento.Size = new System.Drawing.Size(134, 15);
            this.LblVenvimento.TabIndex = 30;
            this.LblVenvimento.Text = "Primeiro vencimento :";
            this.LblVenvimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateTimePrimeiroVencimento
            // 
            this.DateTimePrimeiroVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePrimeiroVencimento.Location = new System.Drawing.Point(140, 222);
            this.DateTimePrimeiroVencimento.Name = "DateTimePrimeiroVencimento";
            this.DateTimePrimeiroVencimento.Size = new System.Drawing.Size(176, 20);
            this.DateTimePrimeiroVencimento.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valor total da receita :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabInfoGeral);
            this.tabControl1.Controls.Add(this.TabInfoAdicionais);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // TabInfoGeral
            // 
            this.TabInfoGeral.BackColor = System.Drawing.SystemColors.Control;
            this.TabInfoGeral.Controls.Add(this.BtnNovoServico);
            this.TabInfoGeral.Controls.Add(this.TxtValorTotal);
            this.TabInfoGeral.Controls.Add(this.BtnPreview);
            this.TabInfoGeral.Controls.Add(this.BtnCancelar);
            this.TabInfoGeral.Controls.Add(this.BtnSalvar);
            this.TabInfoGeral.Controls.Add(this.DGPreviewReceita);
            this.TabInfoGeral.Controls.Add(this.CmbAluno);
            this.TabInfoGeral.Controls.Add(this.label8);
            this.TabInfoGeral.Controls.Add(this.label2);
            this.TabInfoGeral.Controls.Add(this.TxtObservacao);
            this.TabInfoGeral.Controls.Add(this.DateTimePrimeiroVencimento);
            this.TabInfoGeral.Controls.Add(this.BtnNovoAluno);
            this.TabInfoGeral.Controls.Add(this.LblVenvimento);
            this.TabInfoGeral.Controls.Add(this.label1);
            this.TabInfoGeral.Controls.Add(this.label6);
            this.TabInfoGeral.Controls.Add(this.CmbServico);
            this.TabInfoGeral.Controls.Add(this.TxtQntdParcelas);
            this.TabInfoGeral.Controls.Add(this.label3);
            this.TabInfoGeral.Controls.Add(this.CmbTipoDeServico);
            this.TabInfoGeral.Controls.Add(this.CmbFrequencia);
            this.TabInfoGeral.Controls.Add(this.label4);
            this.TabInfoGeral.Controls.Add(this.label5);
            this.TabInfoGeral.Location = new System.Drawing.Point(4, 22);
            this.TabInfoGeral.Name = "TabInfoGeral";
            this.TabInfoGeral.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfoGeral.Size = new System.Drawing.Size(505, 481);
            this.TabInfoGeral.TabIndex = 0;
            this.TabInfoGeral.Text = "Geral";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(140, 248);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(85, 20);
            this.TxtValorTotal.TabIndex = 8;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.BtnPreview.Location = new System.Drawing.Point(231, 246);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(28, 26);
            this.BtnPreview.TabIndex = 9;
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(393, 247);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 25);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "    Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSalvar.Image = global::GerenciadorFinanceiro.Properties.Resources.apply;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(302, 247);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(85, 25);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "   Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DGPreviewReceita
            // 
            this.DGPreviewReceita.AllowUserToAddRows = false;
            this.DGPreviewReceita.AllowUserToDeleteRows = false;
            this.DGPreviewReceita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DGPreviewReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPreviewReceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdParcela,
            this.ColNumeroDaParcela,
            this.ColDataVencimento,
            this.ColValorParcela,
            this.ColStatusParcela});
            this.DGPreviewReceita.Location = new System.Drawing.Point(25, 278);
            this.DGPreviewReceita.MultiSelect = false;
            this.DGPreviewReceita.Name = "DGPreviewReceita";
            this.DGPreviewReceita.ReadOnly = true;
            this.DGPreviewReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPreviewReceita.Size = new System.Drawing.Size(453, 180);
            this.DGPreviewReceita.TabIndex = 12;
            this.DGPreviewReceita.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGPreviewReceita_CellFormatting);
            // 
            // ColIdParcela
            // 
            this.ColIdParcela.DataPropertyName = "IdParcela";
            this.ColIdParcela.HeaderText = "IdParcela";
            this.ColIdParcela.Name = "ColIdParcela";
            this.ColIdParcela.ReadOnly = true;
            this.ColIdParcela.Visible = false;
            // 
            // ColNumeroDaParcela
            // 
            this.ColNumeroDaParcela.DataPropertyName = "NumeroDaParcela";
            this.ColNumeroDaParcela.HeaderText = "Parcela";
            this.ColNumeroDaParcela.Name = "ColNumeroDaParcela";
            this.ColNumeroDaParcela.ReadOnly = true;
            this.ColNumeroDaParcela.Width = 50;
            // 
            // ColDataVencimento
            // 
            this.ColDataVencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ColDataVencimento.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDataVencimento.HeaderText = "Data Vencimento";
            this.ColDataVencimento.Name = "ColDataVencimento";
            this.ColDataVencimento.ReadOnly = true;
            this.ColDataVencimento.Width = 120;
            // 
            // ColValorParcela
            // 
            this.ColValorParcela.DataPropertyName = "ValorParcela";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColValorParcela.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColValorParcela.HeaderText = "Valor da Parcela";
            this.ColValorParcela.Name = "ColValorParcela";
            this.ColValorParcela.ReadOnly = true;
            this.ColValorParcela.Width = 110;
            // 
            // ColStatusParcela
            // 
            this.ColStatusParcela.DataPropertyName = "StatusParcela";
            this.ColStatusParcela.HeaderText = "Status";
            this.ColStatusParcela.Name = "ColStatusParcela";
            this.ColStatusParcela.ReadOnly = true;
            // 
            // TabInfoAdicionais
            // 
            this.TabInfoAdicionais.BackColor = System.Drawing.SystemColors.Control;
            this.TabInfoAdicionais.Location = new System.Drawing.Point(4, 22);
            this.TabInfoAdicionais.Name = "TabInfoAdicionais";
            this.TabInfoAdicionais.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfoAdicionais.Size = new System.Drawing.Size(505, 481);
            this.TabInfoAdicionais.TabIndex = 1;
            this.TabInfoAdicionais.Text = "Informações Adicionais";
            // 
            // BtnNovoServico
            // 
            this.BtnNovoServico.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.BtnNovoServico.Location = new System.Drawing.Point(447, 77);
            this.BtnNovoServico.Name = "BtnNovoServico";
            this.BtnNovoServico.Size = new System.Drawing.Size(31, 24);
            this.BtnNovoServico.TabIndex = 34;
            this.BtnNovoServico.UseVisualStyleBackColor = true;
            this.BtnNovoServico.Click += new System.EventHandler(this.BtnNovoServico_Click);
            // 
            // FrmReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 531);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "FrmReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Receitas";
            this.Load += new System.EventHandler(this.FrmReceita_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabInfoGeral.ResumeLayout(false);
            this.TabInfoGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPreviewReceita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNovoAluno;
        private System.Windows.Forms.ComboBox CmbAluno;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoDeServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbFrequencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQntdParcelas;
        private System.Windows.Forms.Label LblVenvimento;
        private System.Windows.Forms.DateTimePicker DateTimePrimeiroVencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabInfoGeral;
        private System.Windows.Forms.TabPage TabInfoAdicionais;
        private System.Windows.Forms.DataGridView DGPreviewReceita;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumeroDaParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatusParcela;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Button BtnNovoServico;

    }
}