namespace GerenciadorFinanceiro.GUI
{
    partial class FrmEstado
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeEstado = new System.Windows.Forms.TextBox();
            this.DGEstados = new System.Windows.Forms.DataGridView();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiglaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSiglaUF = new System.Windows.Forms.TextBox();
            this.LblSiglaEstado = new System.Windows.Forms.Label();
            this.ctrNavigator1 = new GerenciadorFinanceiro.Controles.CtrNavigator();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 302);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(578, 22);
            this.StatusStrip.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrição :";
            // 
            // TxtNomeEstado
            // 
            this.TxtNomeEstado.BackColor = System.Drawing.Color.White;
            this.TxtNomeEstado.Enabled = false;
            this.TxtNomeEstado.Location = new System.Drawing.Point(100, 12);
            this.TxtNomeEstado.Name = "TxtNomeEstado";
            this.TxtNomeEstado.Size = new System.Drawing.Size(402, 20);
            this.TxtNomeEstado.TabIndex = 0;
            // 
            // DGEstados
            // 
            this.DGEstados.AllowUserToAddRows = false;
            this.DGEstados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGEstados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DGEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstado,
            this.NomeEstado,
            this.SiglaEstado});
            this.DGEstados.Location = new System.Drawing.Point(12, 109);
            this.DGEstados.MultiSelect = false;
            this.DGEstados.Name = "DGEstados";
            this.DGEstados.ReadOnly = true;
            this.DGEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGEstados.Size = new System.Drawing.Size(547, 179);
            this.DGEstados.TabIndex = 3;
            this.DGEstados.SelectionChanged += new System.EventHandler(this.DGEstados_SelectionChanged);
            // 
            // IdEstado
            // 
            this.IdEstado.DataPropertyName = "IdEstado";
            this.IdEstado.HeaderText = "Código";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Width = 95;
            // 
            // NomeEstado
            // 
            this.NomeEstado.DataPropertyName = "NomeEstado";
            this.NomeEstado.HeaderText = "Estado";
            this.NomeEstado.Name = "NomeEstado";
            this.NomeEstado.ReadOnly = true;
            this.NomeEstado.Width = 300;
            // 
            // SiglaEstado
            // 
            this.SiglaEstado.DataPropertyName = "SiglaEstado";
            this.SiglaEstado.HeaderText = "Sigla";
            this.SiglaEstado.Name = "SiglaEstado";
            this.SiglaEstado.ReadOnly = true;
            this.SiglaEstado.Width = 90;
            // 
            // TxtSiglaUF
            // 
            this.TxtSiglaUF.BackColor = System.Drawing.Color.White;
            this.TxtSiglaUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSiglaUF.Enabled = false;
            this.TxtSiglaUF.Location = new System.Drawing.Point(100, 37);
            this.TxtSiglaUF.MaxLength = 2;
            this.TxtSiglaUF.Name = "TxtSiglaUF";
            this.TxtSiglaUF.Size = new System.Drawing.Size(31, 20);
            this.TxtSiglaUF.TabIndex = 1;
            // 
            // LblSiglaEstado
            // 
            this.LblSiglaEstado.AutoSize = true;
            this.LblSiglaEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSiglaEstado.Location = new System.Drawing.Point(12, 39);
            this.LblSiglaEstado.Name = "LblSiglaEstado";
            this.LblSiglaEstado.Size = new System.Drawing.Size(58, 15);
            this.LblSiglaEstado.TabIndex = 13;
            this.LblSiglaEstado.Text = "Sigla UF :";
            // 
            // ctrNavigator1
            // 
            this.ctrNavigator1.DataSource = null;
            this.ctrNavigator1.Indice = -1;
            this.ctrNavigator1.Location = new System.Drawing.Point(12, 61);
            this.ctrNavigator1.Name = "ctrNavigator1";
            this.ctrNavigator1.Size = new System.Drawing.Size(547, 42);
            this.ctrNavigator1.TabIndex = 2;
            this.ctrNavigator1.ExcluirRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Excluir(this.ctrNavigator1_ExcluirRegistro);
            this.ctrNavigator1.EventoNovo += new GerenciadorFinanceiro.Controles.CtrNavigator.Novo(this.ctrNavigator1_EventoNovo);
            this.ctrNavigator1.MudaRegistroSelecionado += new GerenciadorFinanceiro.Controles.CtrNavigator.MudaRegistro(this.ctrNavigator1_MudaRegistroSelecionado);
            this.ctrNavigator1.CancelarAcao += new GerenciadorFinanceiro.Controles.CtrNavigator.Cancelar(this.ctrNavigator1_CancelarAcao);
            this.ctrNavigator1.SalvarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Salvar(this.ctrNavigator1_SalvarRegistro);
            this.ctrNavigator1.EditarRegistro += new GerenciadorFinanceiro.Controles.CtrNavigator.Editar(this.ctrNavigator1_EditarRegistro);
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 324);
            this.Controls.Add(this.ctrNavigator1);
            this.Controls.Add(this.LblSiglaEstado);
            this.Controls.Add(this.TxtSiglaUF);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeEstado);
            this.Controls.Add(this.DGEstados);
            this.MinimizeBox = false;
            this.Name = "FrmEstado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Estados";
            this.Load += new System.EventHandler(this.FrmEstado_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeEstado;
        private System.Windows.Forms.DataGridView DGEstados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaEstado;
        private System.Windows.Forms.TextBox TxtSiglaUF;
        private System.Windows.Forms.Label LblSiglaEstado;
        private GerenciadorFinanceiro.Controles.CtrNavigator ctrNavigator1;
    }
}