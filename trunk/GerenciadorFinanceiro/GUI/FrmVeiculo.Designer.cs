namespace GerenciadorFinanceiro.GUI
{
    partial class FrmVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.DGVeiculos = new System.Windows.Forms.DataGridView();
            this.idVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.TxtChassi = new System.Windows.Forms.TextBox();
            this.TxtRenavam = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GrpImagens = new System.Windows.Forms.GroupBox();
            this.BtnLocalizarFotoInstrutor = new System.Windows.Forms.Button();
            this.PcbFotoVeiculo = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAnoModelo = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.CmbCombustivel = new System.Windows.Forms.ComboBox();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.DGVeiculos)).BeginInit();
            this.GrpImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoVeiculo)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cor :";
            // 
            // TxtCor
            // 
            this.TxtCor.BackColor = System.Drawing.Color.White;
            this.TxtCor.Location = new System.Drawing.Point(96, 121);
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(92, 20);
            this.TxtCor.TabIndex = 5;
            // 
            // DGVeiculos
            // 
            this.DGVeiculos.AllowUserToAddRows = false;
            this.DGVeiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVeiculo,
            this.Placa,
            this.Renavam,
            this.Chassi,
            this.Cor,
            this.Combustivel,
            this.Ano,
            this.Modelo,
            this.ModeloVeiculo,
            this.TipoVeiculo,
            this.Observacao});
            this.DGVeiculos.Location = new System.Drawing.Point(12, 287);
            this.DGVeiculos.Name = "DGVeiculos";
            this.DGVeiculos.ReadOnly = true;
            this.DGVeiculos.Size = new System.Drawing.Size(690, 167);
            this.DGVeiculos.TabIndex = 11;
            this.DGVeiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVeiculos_CellFormatting);
            this.DGVeiculos.SelectionChanged += new System.EventHandler(this.DGVeiculos_SelectionChanged);
            // 
            // idVeiculo
            // 
            this.idVeiculo.DataPropertyName = "IdVeiculo";
            this.idVeiculo.HeaderText = "Código";
            this.idVeiculo.Name = "idVeiculo";
            this.idVeiculo.ReadOnly = true;
            this.idVeiculo.Width = 50;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 50;
            // 
            // Renavam
            // 
            this.Renavam.DataPropertyName = "Renavam";
            this.Renavam.HeaderText = "Renavam";
            this.Renavam.Name = "Renavam";
            this.Renavam.ReadOnly = true;
            // 
            // Chassi
            // 
            this.Chassi.DataPropertyName = "Chassi";
            this.Chassi.HeaderText = "Chassi";
            this.Chassi.Name = "Chassi";
            this.Chassi.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            this.Cor.Width = 60;
            // 
            // Combustivel
            // 
            this.Combustivel.DataPropertyName = "Combustivel";
            this.Combustivel.HeaderText = "Combustível";
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 60;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // ModeloVeiculo
            // 
            this.ModeloVeiculo.DataPropertyName = "ModeloVeiculo";
            this.ModeloVeiculo.HeaderText = "Modelo Veículo";
            this.ModeloVeiculo.Name = "ModeloVeiculo";
            this.ModeloVeiculo.ReadOnly = true;
            this.ModeloVeiculo.Width = 150;
            // 
            // TipoVeiculo
            // 
            this.TipoVeiculo.DataPropertyName = "TipoVeiculo";
            this.TipoVeiculo.HeaderText = "Tipo";
            this.TipoVeiculo.Name = "TipoVeiculo";
            this.TipoVeiculo.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // CmbModelo
            // 
            this.CmbModelo.BackColor = System.Drawing.Color.White;
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(96, 148);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(301, 21);
            this.CmbModelo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Placa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Renavam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chassi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Modelo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observação :";
            // 
            // CmbTipo
            // 
            this.CmbTipo.BackColor = System.Drawing.Color.White;
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(96, 66);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(301, 21);
            this.CmbTipo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo :";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BackColor = System.Drawing.Color.White;
            this.TxtObservacao.Location = new System.Drawing.Point(96, 176);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(301, 58);
            this.TxtObservacao.TabIndex = 9;
            // 
            // TxtAno
            // 
            this.TxtAno.BackColor = System.Drawing.Color.White;
            this.TxtAno.Location = new System.Drawing.Point(228, 121);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(53, 20);
            this.TxtAno.TabIndex = 6;
            // 
            // TxtChassi
            // 
            this.TxtChassi.BackColor = System.Drawing.Color.White;
            this.TxtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtChassi.Location = new System.Drawing.Point(96, 39);
            this.TxtChassi.Name = "TxtChassi";
            this.TxtChassi.Size = new System.Drawing.Size(301, 20);
            this.TxtChassi.TabIndex = 2;
            // 
            // TxtRenavam
            // 
            this.TxtRenavam.BackColor = System.Drawing.Color.White;
            this.TxtRenavam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRenavam.Location = new System.Drawing.Point(258, 12);
            this.TxtRenavam.Name = "TxtRenavam";
            this.TxtRenavam.Size = new System.Drawing.Size(139, 20);
            this.TxtRenavam.TabIndex = 1;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.BackColor = System.Drawing.Color.White;
            this.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPlaca.Location = new System.Drawing.Point(96, 12);
            this.TxtPlaca.MaxLength = 10;
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(88, 20);
            this.TxtPlaca.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Combustível :";
            // 
            // GrpImagens
            // 
            this.GrpImagens.Controls.Add(this.BtnLocalizarFotoInstrutor);
            this.GrpImagens.Controls.Add(this.PcbFotoVeiculo);
            this.GrpImagens.Location = new System.Drawing.Point(403, 6);
            this.GrpImagens.Name = "GrpImagens";
            this.GrpImagens.Size = new System.Drawing.Size(299, 228);
            this.GrpImagens.TabIndex = 30;
            this.GrpImagens.TabStop = false;
            this.GrpImagens.Text = "Foto do Veículo ";
            // 
            // BtnLocalizarFotoInstrutor
            // 
            this.BtnLocalizarFotoInstrutor.Location = new System.Drawing.Point(135, 199);
            this.BtnLocalizarFotoInstrutor.Name = "BtnLocalizarFotoInstrutor";
            this.BtnLocalizarFotoInstrutor.Size = new System.Drawing.Size(28, 26);
            this.BtnLocalizarFotoInstrutor.TabIndex = 0;
            this.BtnLocalizarFotoInstrutor.UseVisualStyleBackColor = true;
            // 
            // PcbFotoVeiculo
            // 
            this.PcbFotoVeiculo.BackColor = System.Drawing.Color.White;
            this.PcbFotoVeiculo.Location = new System.Drawing.Point(11, 19);
            this.PcbFotoVeiculo.Name = "PcbFotoVeiculo";
            this.PcbFotoVeiculo.Size = new System.Drawing.Size(278, 174);
            this.PcbFotoVeiculo.TabIndex = 1;
            this.PcbFotoVeiculo.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Modelo :";
            // 
            // TxtAnoModelo
            // 
            this.TxtAnoModelo.BackColor = System.Drawing.Color.White;
            this.TxtAnoModelo.Location = new System.Drawing.Point(344, 121);
            this.TxtAnoModelo.Name = "TxtAnoModelo";
            this.TxtAnoModelo.Size = new System.Drawing.Size(53, 20);
            this.TxtAnoModelo.TabIndex = 7;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 468);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(715, 22);
            this.StatusStrip.TabIndex = 34;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(124, 17);
            this.LblStatus.Text = "Status : Consultando";
            // 
            // CmbCombustivel
            // 
            this.CmbCombustivel.BackColor = System.Drawing.Color.White;
            this.CmbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCombustivel.FormattingEnabled = true;
            this.CmbCombustivel.Items.AddRange(new object[] {
            "Alcool",
            "Diesel",
            "Flex",
            "Gasolina"});
            this.CmbCombustivel.Location = new System.Drawing.Point(96, 94);
            this.CmbCombustivel.Name = "CmbCombustivel";
            this.CmbCombustivel.Size = new System.Drawing.Size(301, 21);
            this.CmbCombustivel.TabIndex = 4;
            // 
            // ctrNavigator1
            // 
            this.ctrNavigator1.DataSource = null;
            this.ctrNavigator1.Indice = -1;
            this.ctrNavigator1.Location = new System.Drawing.Point(15, 239);
            this.ctrNavigator1.Name = "ctrNavigator1";
            this.ctrNavigator1.Size = new System.Drawing.Size(547, 42);
            this.ctrNavigator1.TabIndex = 10;
            this.ctrNavigator1.ExcluirRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Excluir(this.ctrNavigator1_ExcluirRegistro);
            this.ctrNavigator1.EventoNovo += new GerenciadorFinanceiro.Controles.CtrNavigator.Novo(this.ctrNavigator1_EventoNovo);
            this.ctrNavigator1.MudaRegistroSelecionado += new GerenciadorFinanceiro.Controles.CtrNavigator.MudaRegistro(this.ctrNavigator1_MudaRegistroSelecionado);
            this.ctrNavigator1.CancelarAcao += new GerenciadorFinanceiro.Controles.CtrNavigator.Cancelar(this.ctrNavigator1_CancelarAcao);
            this.ctrNavigator1.SalvarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Salvar(this.ctrNavigator1_SalvarRegistro);
            this.ctrNavigator1.EditarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Editar(this.ctrNavigator1_EditarRegistro);
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 490);
            this.Controls.Add(this.CmbCombustivel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TxtAnoModelo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.GrpImagens);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.TxtRenavam);
            this.Controls.Add(this.TxtChassi);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.DGVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCor);
            this.MinimizeBox = false;
            this.Name = "FrmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.FrmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVeiculos)).EndInit();
            this.GrpImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoVeiculo)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.DataGridView DGVeiculos;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.TextBox TxtChassi;
        private System.Windows.Forms.TextBox TxtRenavam;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GrpImagens;
        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtAnoModelo;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.Button BtnLocalizarFotoInstrutor;
        private System.Windows.Forms.PictureBox PcbFotoVeiculo;
        private System.Windows.Forms.ComboBox CmbCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renavam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
    }
}