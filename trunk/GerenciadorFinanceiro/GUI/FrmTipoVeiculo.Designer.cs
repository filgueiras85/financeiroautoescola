namespace GerenciadorFinanceiro.GUI
{
    partial class FrmTipoVeiculo
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
            this.DGTipoVeiculo = new System.Windows.Forms.DataGridView();
            this.IdTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.DGTipoVeiculo)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição :";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BackColor = System.Drawing.Color.White;
            this.TxtDescricao.Location = new System.Drawing.Point(107, 18);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(402, 20);
            this.TxtDescricao.TabIndex = 10;
            // 
            // DGTipoVeiculo
            // 
            this.DGTipoVeiculo.AllowUserToAddRows = false;
            this.DGTipoVeiculo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGTipoVeiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGTipoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DGTipoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTipoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoVeiculo,
            this.Descricao});
            this.DGTipoVeiculo.Location = new System.Drawing.Point(15, 97);
            this.DGTipoVeiculo.MultiSelect = false;
            this.DGTipoVeiculo.Name = "DGTipoVeiculo";
            this.DGTipoVeiculo.ReadOnly = true;
            this.DGTipoVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTipoVeiculo.Size = new System.Drawing.Size(547, 190);
            this.DGTipoVeiculo.TabIndex = 9;
            this.DGTipoVeiculo.SelectionChanged += new System.EventHandler(this.DGTipoVeiculo_SelectionChanged);
            // 
            // IdTipoVeiculo
            // 
            this.IdTipoVeiculo.DataPropertyName = "IdTipoVeiculo";
            this.IdTipoVeiculo.HeaderText = "Código";
            this.IdTipoVeiculo.Name = "IdTipoVeiculo";
            this.IdTipoVeiculo.ReadOnly = true;
            this.IdTipoVeiculo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Tipo de Veículo";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 365;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::GerenciadorFinanceiro.Properties.Resources._85551;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 302);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(578, 22);
            this.StatusStrip.TabIndex = 13;
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
            this.ctrNavigator1.Location = new System.Drawing.Point(12, 49);
            this.ctrNavigator1.Name = "ctrNavigator1";
            this.ctrNavigator1.Size = new System.Drawing.Size(547, 42);
            this.ctrNavigator1.TabIndex = 12;
            this.ctrNavigator1.ExcluirRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Excluir(this.ctrNavigator1_ExcluirRegistro);
            this.ctrNavigator1.EventoNovo += new GerenciadorFinanceiro.Controles.CtrNavigator.Novo(this.ctrNavigator1_EventoNovo);
            this.ctrNavigator1.MudaRegistroSelecionado += new GerenciadorFinanceiro.Controles.CtrNavigator.MudaRegistro(this.ctrNavigator1_MudaRegistroSelecionado);
            this.ctrNavigator1.CancelarAcao += new GerenciadorFinanceiro.Controles.CtrNavigator.Cancelar(this.ctrNavigator1_CancelarAcao);
            this.ctrNavigator1.SalvarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Salvar(this.ctrNavigator1_SalvarRegistro);
            this.ctrNavigator1.EditarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Editar(this.ctrNavigator1_EditarRegistro);
            // 
            // FrmTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 324);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.DGTipoVeiculo);
            this.MinimizeBox = false;
            this.Name = "FrmTipoVeiculo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo de Veículo";
            this.Load += new System.EventHandler(this.FrmTipoVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTipoVeiculo)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.DataGridView DGTipoVeiculo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
    }
}