namespace GerenciadorFinanceiro.GUI
{
    partial class FrmInstrutores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeInstrutor = new System.Windows.Forms.TextBox();
            this.DGInstrutores = new System.Windows.Forms.DataGridView();
            this.idInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbCidade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtObservacaoInstrutor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLocalizarFotoInstrutor = new System.Windows.Forms.Button();
            this.PcbFotoInstrutor = new System.Windows.Forms.PictureBox();
            this.TxtTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            this.btnNovaCidade = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGInstrutores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoInstrutor)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome :";
            // 
            // TxtNomeInstrutor
            // 
            this.TxtNomeInstrutor.BackColor = System.Drawing.Color.White;
            this.TxtNomeInstrutor.Location = new System.Drawing.Point(92, 19);
            this.TxtNomeInstrutor.Name = "TxtNomeInstrutor";
            this.TxtNomeInstrutor.Size = new System.Drawing.Size(450, 20);
            this.TxtNomeInstrutor.TabIndex = 0;
            // 
            // DGInstrutores
            // 
            this.DGInstrutores.AllowUserToAddRows = false;
            this.DGInstrutores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGInstrutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGInstrutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGInstrutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInstrutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInstrutor,
            this.Nome,
            this.Rua,
            this.Numero,
            this.Complemento,
            this.Bairro,
            this.CEP,
            this.Cidade,
            this.Telefone,
            this.Celular});
            this.DGInstrutores.Location = new System.Drawing.Point(12, 314);
            this.DGInstrutores.Name = "DGInstrutores";
            this.DGInstrutores.ReadOnly = true;
            this.DGInstrutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGInstrutores.Size = new System.Drawing.Size(782, 176);
            this.DGInstrutores.TabIndex = 12;
            this.DGInstrutores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGInstrutores_CellFormatting);
            this.DGInstrutores.SelectionChanged += new System.EventHandler(this.DGInstrutores_SelectionChanged);
            // 
            // idInstrutor
            // 
            this.idInstrutor.DataPropertyName = "idInstrutor";
            this.idInstrutor.HeaderText = "Código";
            this.idInstrutor.Name = "idInstrutor";
            this.idInstrutor.ReadOnly = true;
            this.idInstrutor.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "Endereco";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            this.Rua.Width = 150;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 55;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Width = 80;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 50;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "TelefoneResidencial";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 60;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "TelefoneCelular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "CEP :";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.BackColor = System.Drawing.Color.White;
            this.TxtComplemento.Location = new System.Drawing.Point(254, 123);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(288, 20);
            this.TxtComplemento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Celular :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Complemento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bairro :";
            // 
            // TxtBairro
            // 
            this.TxtBairro.BackColor = System.Drawing.Color.White;
            this.TxtBairro.Location = new System.Drawing.Point(92, 149);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(335, 20);
            this.TxtBairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Número :";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.White;
            this.TxtNumero.Location = new System.Drawing.Point(92, 123);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(60, 20);
            this.TxtNumero.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Endereço :";
            // 
            // TxtRua
            // 
            this.TxtRua.BackColor = System.Drawing.Color.White;
            this.TxtRua.Location = new System.Drawing.Point(92, 97);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(450, 20);
            this.TxtRua.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cidade :";
            // 
            // CmbCidade
            // 
            this.CmbCidade.BackColor = System.Drawing.Color.White;
            this.CmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCidade.FormattingEnabled = true;
            this.CmbCidade.Location = new System.Drawing.Point(203, 175);
            this.CmbCidade.Name = "CmbCidade";
            this.CmbCidade.Size = new System.Drawing.Size(302, 21);
            this.CmbCidade.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Observação :";
            // 
            // TxtObservacaoInstrutor
            // 
            this.TxtObservacaoInstrutor.BackColor = System.Drawing.Color.White;
            this.TxtObservacaoInstrutor.Location = new System.Drawing.Point(92, 202);
            this.TxtObservacaoInstrutor.Multiline = true;
            this.TxtObservacaoInstrutor.Name = "TxtObservacaoInstrutor";
            this.TxtObservacaoInstrutor.Size = new System.Drawing.Size(450, 61);
            this.TxtObservacaoInstrutor.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLocalizarFotoInstrutor);
            this.groupBox1.Controls.Add(this.PcbFotoInstrutor);
            this.groupBox1.Location = new System.Drawing.Point(571, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto do Instrutor ";
            // 
            // BtnLocalizarFotoInstrutor
            // 
            this.BtnLocalizarFotoInstrutor.Image = global::GerenciadorFinanceiro.Properties.Resources.viewmag;
            this.BtnLocalizarFotoInstrutor.Location = new System.Drawing.Point(95, 264);
            this.BtnLocalizarFotoInstrutor.Name = "BtnLocalizarFotoInstrutor";
            this.BtnLocalizarFotoInstrutor.Size = new System.Drawing.Size(28, 26);
            this.BtnLocalizarFotoInstrutor.TabIndex = 0;
            this.BtnLocalizarFotoInstrutor.UseVisualStyleBackColor = true;
            this.BtnLocalizarFotoInstrutor.Click += new System.EventHandler(this.BtnLocalizarFotoInstrutor_Click);
            // 
            // PcbFotoInstrutor
            // 
            this.PcbFotoInstrutor.BackColor = System.Drawing.Color.White;
            this.PcbFotoInstrutor.Location = new System.Drawing.Point(12, 20);
            this.PcbFotoInstrutor.Name = "PcbFotoInstrutor";
            this.PcbFotoInstrutor.Size = new System.Drawing.Size(195, 238);
            this.PcbFotoInstrutor.TabIndex = 0;
            this.PcbFotoInstrutor.TabStop = false;
            // 
            // TxtTelefoneResidencial
            // 
            this.TxtTelefoneResidencial.BackColor = System.Drawing.Color.White;
            this.TxtTelefoneResidencial.Location = new System.Drawing.Point(92, 45);
            this.TxtTelefoneResidencial.Mask = "(99)0000-0000";
            this.TxtTelefoneResidencial.Name = "TxtTelefoneResidencial";
            this.TxtTelefoneResidencial.Size = new System.Drawing.Size(108, 20);
            this.TxtTelefoneResidencial.TabIndex = 1;
            // 
            // TxtTelefoneCelular
            // 
            this.TxtTelefoneCelular.BackColor = System.Drawing.Color.White;
            this.TxtTelefoneCelular.Location = new System.Drawing.Point(273, 45);
            this.TxtTelefoneCelular.Mask = "(99) 0000-0000";
            this.TxtTelefoneCelular.Name = "TxtTelefoneCelular";
            this.TxtTelefoneCelular.Size = new System.Drawing.Size(108, 20);
            this.TxtTelefoneCelular.TabIndex = 2;
            // 
            // TxtCEP
            // 
            this.TxtCEP.BackColor = System.Drawing.Color.White;
            this.TxtCEP.Location = new System.Drawing.Point(473, 149);
            this.TxtCEP.Mask = "00.000-999";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(69, 20);
            this.TxtCEP.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "UF :";
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.White;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(92, 175);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(50, 21);
            this.CmbEstado.TabIndex = 10;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 502);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(807, 22);
            this.StatusStrip.TabIndex = 31;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(124, 17);
            this.LblStatus.Text = "Status : Consultando";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "RG :";
            // 
            // TxtRG
            // 
            this.TxtRG.BackColor = System.Drawing.Color.White;
            this.TxtRG.Location = new System.Drawing.Point(92, 71);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(108, 20);
            this.TxtRG.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(237, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "CPF :";
            // 
            // TxtCPF
            // 
            this.TxtCPF.BackColor = System.Drawing.Color.White;
            this.TxtCPF.Location = new System.Drawing.Point(273, 71);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(108, 20);
            this.TxtCPF.TabIndex = 4;
            // 
            // ctrNavigator1
            // 
            this.ctrNavigator1.DataSource = null;
            this.ctrNavigator1.Indice = -1;
            this.ctrNavigator1.Location = new System.Drawing.Point(12, 267);
            this.ctrNavigator1.Name = "ctrNavigator1";
            this.ctrNavigator1.Size = new System.Drawing.Size(547, 42);
            this.ctrNavigator1.TabIndex = 14;
            this.ctrNavigator1.ExcluirRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Excluir(this.ctrNavigator1_ExcluirRegistro);
            this.ctrNavigator1.EventoNovo += new GerenciadorFinanceiro.Controles.CtrNavigator.Novo(this.ctrNavigator1_EventoNovo);
            this.ctrNavigator1.MudaRegistroSelecionado += new GerenciadorFinanceiro.Controles.CtrNavigator.MudaRegistro(this.ctrNavigator1_MudaRegistroSelecionado);
            this.ctrNavigator1.CancelarAcao += new GerenciadorFinanceiro.Controles.CtrNavigator.Cancelar(this.ctrNavigator1_CancelarAcao);
            this.ctrNavigator1.SalvarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Salvar(this.ctrNavigator1_SalvarRegistro);
            this.ctrNavigator1.EditarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Editar(this.ctrNavigator1_EditarRegistro);
            // 
            // btnNovaCidade
            // 
            this.btnNovaCidade.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.btnNovaCidade.Location = new System.Drawing.Point(511, 174);
            this.btnNovaCidade.Name = "btnNovaCidade";
            this.btnNovaCidade.Size = new System.Drawing.Size(31, 24);
            this.btnNovaCidade.TabIndex = 12;
            this.btnNovaCidade.UseVisualStyleBackColor = true;
            this.btnNovaCidade.Click += new System.EventHandler(this.btnNovaCidade_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // FrmInstrutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.btnNovaCidade);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtCEP);
            this.Controls.Add(this.TxtTelefoneCelular);
            this.Controls.Add(this.TxtTelefoneResidencial);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtObservacaoInstrutor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.DGInstrutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeInstrutor);
            this.MinimizeBox = false;
            this.Name = "FrmInstrutores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Instrutores";
            this.Load += new System.EventHandler(this.FrmInstrutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGInstrutores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoInstrutor)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeInstrutor;
        private System.Windows.Forms.DataGridView DGInstrutores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtObservacaoInstrutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PcbFotoInstrutor;
        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.Button BtnLocalizarFotoInstrutor;
        private System.Windows.Forms.MaskedTextBox TxtTelefoneResidencial;
        private System.Windows.Forms.MaskedTextBox TxtTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.Button btnNovaCidade;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}