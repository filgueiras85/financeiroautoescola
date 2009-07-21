namespace GerenciadorFinanceiro.GUI
{
    partial class FrmCidade
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
            this.LblSiglaEstado = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeCidade = new System.Windows.Forms.TextBox();
            this.DGCidades = new System.Windows.Forms.DataGridView();
            this.CmbEstados = new System.Windows.Forms.ComboBox();
            this.IdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSiglaEstado
            // 
            this.LblSiglaEstado.AutoSize = true;
            this.LblSiglaEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSiglaEstado.Location = new System.Drawing.Point(12, 39);
            this.LblSiglaEstado.Name = "LblSiglaEstado";
            this.LblSiglaEstado.Size = new System.Drawing.Size(52, 15);
            this.LblSiglaEstado.TabIndex = 20;
            this.LblSiglaEstado.Text = "Estado :";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 302);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(578, 22);
            this.StatusStrip.TabIndex = 19;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(124, 17);
            this.LblStatus.Text = "Status : Consultando";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cidade :";
            // 
            // TxtNomeCidade
            // 
            this.TxtNomeCidade.BackColor = System.Drawing.Color.White;
            this.TxtNomeCidade.Enabled = false;
            this.TxtNomeCidade.Location = new System.Drawing.Point(100, 12);
            this.TxtNomeCidade.Name = "TxtNomeCidade";
            this.TxtNomeCidade.Size = new System.Drawing.Size(402, 20);
            this.TxtNomeCidade.TabIndex = 14;
            // 
            // DGCidades
            // 
            this.DGCidades.AllowUserToAddRows = false;
            this.DGCidades.AllowUserToDeleteRows = false;
            this.DGCidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DGCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCidade,
            this.NomeCidade,
            this.Estado});
            this.DGCidades.Location = new System.Drawing.Point(12, 109);
            this.DGCidades.Name = "DGCidades";
            this.DGCidades.ReadOnly = true;
            this.DGCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCidades.Size = new System.Drawing.Size(547, 179);
            this.DGCidades.TabIndex = 17;
            this.DGCidades.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGCidades_CellFormatting);
            this.DGCidades.SelectionChanged += new System.EventHandler(this.DGCidades_SelectionChanged);
            // 
            // CmbEstados
            // 
            this.CmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstados.FormattingEnabled = true;
            this.CmbEstados.Location = new System.Drawing.Point(100, 37);
            this.CmbEstados.Name = "CmbEstados";
            this.CmbEstados.Size = new System.Drawing.Size(402, 21);
            this.CmbEstados.TabIndex = 21;
            // 
            // IdCidade
            // 
            this.IdCidade.DataPropertyName = "IdCidade";
            this.IdCidade.HeaderText = "Código";
            this.IdCidade.Name = "IdCidade";
            this.IdCidade.ReadOnly = true;
            this.IdCidade.Width = 60;
            // 
            // NomeCidade
            // 
            this.NomeCidade.DataPropertyName = "NomeCidade";
            this.NomeCidade.HeaderText = "Cidade";
            this.NomeCidade.Name = "NomeCidade";
            this.NomeCidade.ReadOnly = true;
            this.NomeCidade.Width = 235;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 190;
            // 
            // ctrNavigator1
            // 
            this.ctrNavigator1.DataSource = null;
            this.ctrNavigator1.Indice = -1;
            this.ctrNavigator1.Location = new System.Drawing.Point(12, 61);
            this.ctrNavigator1.Name = "ctrNavigator1";
            this.ctrNavigator1.Size = new System.Drawing.Size(547, 42);
            this.ctrNavigator1.TabIndex = 16;
            this.ctrNavigator1.ExcluirRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Excluir(this.ctrNavigator1_ExcluirRegistro);
            this.ctrNavigator1.EventoNovo += new GerenciadorFinanceiro.Controles.CtrNavigator.Novo(this.ctrNavigator1_EventoNovo);
            this.ctrNavigator1.MudaRegistroSelecionado += new GerenciadorFinanceiro.Controles.CtrNavigator.MudaRegistro(this.ctrNavigator1_MudaRegistroSelecionado);
            this.ctrNavigator1.CancelarAcao += new GerenciadorFinanceiro.Controles.CtrNavigator.Cancelar(this.ctrNavigator1_CancelarAcao);
            this.ctrNavigator1.SalvarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Salvar(this.ctrNavigator1_SalvarRegistro);
            this.ctrNavigator1.EditarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Editar(this.ctrNavigator1_EditarRegistro);
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 324);
            this.Controls.Add(this.CmbEstados);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.LblSiglaEstado);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeCidade);
            this.Controls.Add(this.DGCidades);
            this.Name = "FrmCidade";
            this.Text = "Cadastro de Cidades";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
        private System.Windows.Forms.Label LblSiglaEstado;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeCidade;
        private System.Windows.Forms.DataGridView DGCidades;
        private System.Windows.Forms.ComboBox CmbEstados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}