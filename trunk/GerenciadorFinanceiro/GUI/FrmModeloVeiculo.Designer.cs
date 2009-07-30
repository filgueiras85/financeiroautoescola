namespace GerenciadorFinanceiro.GUI
{
    partial class FrmModeloVeiculo
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
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.CmbFabricanteVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGModelos = new System.Windows.Forms.DataGridView();
            this.idModeloVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            this.btnNovoFabricante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGModelos)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrição :";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BackColor = System.Drawing.Color.White;
            this.TxtDescricao.Location = new System.Drawing.Point(104, 12);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(392, 20);
            this.TxtDescricao.TabIndex = 9;
            // 
            // CmbFabricanteVeiculo
            // 
            this.CmbFabricanteVeiculo.BackColor = System.Drawing.Color.White;
            this.CmbFabricanteVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFabricanteVeiculo.FormattingEnabled = true;
            this.CmbFabricanteVeiculo.Location = new System.Drawing.Point(104, 39);
            this.CmbFabricanteVeiculo.Name = "CmbFabricanteVeiculo";
            this.CmbFabricanteVeiculo.Size = new System.Drawing.Size(392, 21);
            this.CmbFabricanteVeiculo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fabricante :";
            // 
            // DGModelos
            // 
            this.DGModelos.AllowUserToAddRows = false;
            this.DGModelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGModelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGModelos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DGModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModeloVeiculo,
            this.Descricao,
            this.Fabricante});
            this.DGModelos.Location = new System.Drawing.Point(20, 112);
            this.DGModelos.Name = "DGModelos";
            this.DGModelos.ReadOnly = true;
            this.DGModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGModelos.Size = new System.Drawing.Size(538, 175);
            this.DGModelos.TabIndex = 13;
            this.DGModelos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGModelos_CellFormatting);
            this.DGModelos.SelectionChanged += new System.EventHandler(this.DGModelos_SelectionChanged);
            // 
            // idModeloVeiculo
            // 
            this.idModeloVeiculo.DataPropertyName = "idModeloVeiculo";
            this.idModeloVeiculo.HeaderText = "Código";
            this.idModeloVeiculo.Name = "idModeloVeiculo";
            this.idModeloVeiculo.ReadOnly = true;
            this.idModeloVeiculo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Modelo";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            this.Fabricante.Width = 200;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 302);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(578, 22);
            this.StatusStrip.TabIndex = 15;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(124, 17);
            this.LblStatus.Text = "Status : Consultando";
            // 
            // ctrNavigator1
            // 
            this.ctrNavigator1.DataSource = null;
            this.ctrNavigator1.Indice = -1;
            this.ctrNavigator1.Location = new System.Drawing.Point(17, 66);
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
            // btnNovoFabricante
            // 
            this.btnNovoFabricante.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.btnNovoFabricante.Location = new System.Drawing.Point(502, 39);
            this.btnNovoFabricante.Name = "btnNovoFabricante";
            this.btnNovoFabricante.Size = new System.Drawing.Size(31, 24);
            this.btnNovoFabricante.TabIndex = 38;
            this.btnNovoFabricante.UseVisualStyleBackColor = true;
            this.btnNovoFabricante.Click += new System.EventHandler(this.btnNovoFabricante_Click);
            // 
            // FrmModeloVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 324);
            this.Controls.Add(this.btnNovoFabricante);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.DGModelos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbFabricanteVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescricao);
            this.MinimizeBox = false;
            this.Name = "FrmModeloVeiculo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Modelos de Veiculos";
            this.Load += new System.EventHandler(this.FrmModeloVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGModelos)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.ComboBox CmbFabricanteVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGModelos;
        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModeloVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.Button btnNovoFabricante;
    }
}