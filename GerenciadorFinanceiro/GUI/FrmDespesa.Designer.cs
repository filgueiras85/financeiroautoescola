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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewParcelas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataVcto = new System.Windows.Forms.DateTimePicker();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFrequencia = new System.Windows.Forms.ComboBox();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.btnFavorecido = new System.Windows.Forms.Button();
            this.cmbFavorecido = new System.Windows.Forms.ComboBox();
            this.btrnNovaCategoria = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtdParcelas = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ColEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColIdDespesaParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataVcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataQuitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorUnitario = new GerenciadorFinanceiro.Controles.FormatTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParcelas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewParcelas
            // 
            this.gridViewParcelas.AllowUserToAddRows = false;
            this.gridViewParcelas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEditar,
            this.ColIdDespesaParcela,
            this.ColNumeroParcela,
            this.ColDataVcto,
            this.ColValorParcela,
            this.ColStatus,
            this.ColDataQuitada,
            this.ColValorPago,
            this.ColDocumento});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewParcelas.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewParcelas.Location = new System.Drawing.Point(9, 254);
            this.gridViewParcelas.MultiSelect = false;
            this.gridViewParcelas.Name = "gridViewParcelas";
            this.gridViewParcelas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewParcelas.RowHeadersWidth = 30;
            this.gridViewParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewParcelas.Size = new System.Drawing.Size(624, 213);
            this.gridViewParcelas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição :";
            // 
            // txtDataVcto
            // 
            this.txtDataVcto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVcto.Location = new System.Drawing.Point(116, 192);
            this.txtDataVcto.Name = "txtDataVcto";
            this.txtDataVcto.Size = new System.Drawing.Size(131, 20);
            this.txtDataVcto.TabIndex = 3;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(119, 15);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(270, 20);
            this.TxtDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Vcto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(116, 86);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(236, 21);
            this.cmbCategoria.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor unitário:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 504);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtValorUnitario);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cmbFrequencia);
            this.tabPage1.Controls.Add(this.btnGerarParcelas);
            this.tabPage1.Controls.Add(this.btnFavorecido);
            this.tabPage1.Controls.Add(this.cmbFavorecido);
            this.tabPage1.Controls.Add(this.btrnNovaCategoria);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtQtdParcelas);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.gridViewParcelas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtDataVcto);
            this.tabPage1.Controls.Add(this.cmbCategoria);
            this.tabPage1.Controls.Add(this.TxtDescricao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(32, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Frequência :";
            // 
            // cmbFrequencia
            // 
            this.cmbFrequencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencia.FormattingEnabled = true;
            this.cmbFrequencia.Location = new System.Drawing.Point(116, 160);
            this.cmbFrequencia.Name = "cmbFrequencia";
            this.cmbFrequencia.Size = new System.Drawing.Size(173, 21);
            this.cmbFrequencia.TabIndex = 27;
            this.cmbFrequencia.SelectedIndexChanged += new System.EventHandler(this.cmbFrequencia_SelectedIndexChanged);
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Image = global::GerenciadorFinanceiro.Properties.Resources.apply;
            this.btnGerarParcelas.Location = new System.Drawing.Point(278, 220);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(111, 23);
            this.btnGerarParcelas.TabIndex = 26;
            this.btnGerarParcelas.Text = "Gerar parcelas";
            this.btnGerarParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnGerarParcelas, "Atualizar as parcelas.");
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // btnFavorecido
            // 
            this.btnFavorecido.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.btnFavorecido.Location = new System.Drawing.Point(358, 46);
            this.btnFavorecido.Name = "btnFavorecido";
            this.btnFavorecido.Size = new System.Drawing.Size(31, 24);
            this.btnFavorecido.TabIndex = 25;
            this.btnFavorecido.UseVisualStyleBackColor = true;
            this.btnFavorecido.Click += new System.EventHandler(this.btnFavorecido_Click);
            // 
            // cmbFavorecido
            // 
            this.cmbFavorecido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFavorecido.FormattingEnabled = true;
            this.cmbFavorecido.Location = new System.Drawing.Point(116, 49);
            this.cmbFavorecido.Name = "cmbFavorecido";
            this.cmbFavorecido.Size = new System.Drawing.Size(236, 21);
            this.cmbFavorecido.TabIndex = 24;
            // 
            // btrnNovaCategoria
            // 
            this.btrnNovaCategoria.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.btrnNovaCategoria.Location = new System.Drawing.Point(358, 84);
            this.btrnNovaCategoria.Name = "btrnNovaCategoria";
            this.btrnNovaCategoria.Size = new System.Drawing.Size(31, 24);
            this.btrnNovaCategoria.TabIndex = 23;
            this.btrnNovaCategoria.UseVisualStyleBackColor = true;
            this.btrnNovaCategoria.Click += new System.EventHandler(this.btrnNovaCategoria_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(35, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Favorecido :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Qnt de Parcelas :";
            // 
            // txtQtdParcelas
            // 
            this.txtQtdParcelas.Location = new System.Drawing.Point(119, 222);
            this.txtQtdParcelas.Name = "txtQtdParcelas";
            this.txtQtdParcelas.Size = new System.Drawing.Size(135, 20);
            this.txtQtdParcelas.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Documentos";
            // 
            // button5
            // 
            this.button5.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.button5.Location = new System.Drawing.Point(306, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 24);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.button4.Location = new System.Drawing.Point(306, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 24);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(139, 99);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(161, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(24, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo lançamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(55, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nº do titulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observações :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 298);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(441, 76);
            this.textBox2.TabIndex = 6;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::GerenciadorFinanceiro.Properties.Resources.disc;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(240, 514);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(70, 28);
            this.BtnSalvar.TabIndex = 24;
            this.BtnSalvar.Text = "     Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(361, 514);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(70, 28);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Image = global::GerenciadorFinanceiro.Properties.Resources.file_edit;
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            // 
            // ColIdDespesaParcela
            // 
            this.ColIdDespesaParcela.DataPropertyName = "IdParcela";
            this.ColIdDespesaParcela.HeaderText = "IdDespesaParcela";
            this.ColIdDespesaParcela.Name = "ColIdDespesaParcela";
            this.ColIdDespesaParcela.ReadOnly = true;
            this.ColIdDespesaParcela.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColIdDespesaParcela.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColIdDespesaParcela.Visible = false;
            // 
            // ColNumeroParcela
            // 
            this.ColNumeroParcela.DataPropertyName = "NumeroDaParcela";
            this.ColNumeroParcela.HeaderText = "NumeroParcela";
            this.ColNumeroParcela.Name = "ColNumeroParcela";
            this.ColNumeroParcela.ReadOnly = true;
            // 
            // ColDataVcto
            // 
            this.ColDataVcto.DataPropertyName = "Vencimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ColDataVcto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDataVcto.HeaderText = "Data Vencimento";
            this.ColDataVcto.Name = "ColDataVcto";
            this.ColDataVcto.ReadOnly = true;
            // 
            // ColValorParcela
            // 
            this.ColValorParcela.DataPropertyName = "ValorParcela";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ColValorParcela.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColValorParcela.HeaderText = "Valor";
            this.ColValorParcela.Name = "ColValorParcela";
            this.ColValorParcela.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ColDataQuitada
            // 
            this.ColDataQuitada.DataPropertyName = "DataQuitada";
            dataGridViewCellStyle4.NullValue = null;
            this.ColDataQuitada.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDataQuitada.HeaderText = "Data Quitada";
            this.ColDataQuitada.Name = "ColDataQuitada";
            this.ColDataQuitada.ReadOnly = true;
            // 
            // ColValorPago
            // 
            this.ColValorPago.DataPropertyName = "ValorPago";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ColValorPago.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColValorPago.HeaderText = "Valor Pago";
            this.ColValorPago.Name = "ColValorPago";
            this.ColValorPago.ReadOnly = true;
            // 
            // ColDocumento
            // 
            this.ColDocumento.DataPropertyName = "Documento";
            this.ColDocumento.HeaderText = "Documento";
            this.ColDocumento.Name = "ColDocumento";
            this.ColDocumento.ReadOnly = true;
            this.ColDocumento.Visible = false;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(116, 125);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(173, 20);
            this.txtValorUnitario.TabIndex = 29;
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 549);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.FrmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParcelas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataVcto;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQtdParcelas;
        private System.Windows.Forms.Button btrnNovaCategoria;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFavorecido;
        private System.Windows.Forms.ComboBox cmbFavorecido;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFrequencia;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn ColEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDespesaParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataVcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataQuitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocumento;
        private GerenciadorFinanceiro.Controles.FormatTextBox txtValorUnitario;
    }
}