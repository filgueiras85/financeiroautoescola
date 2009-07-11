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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.DGTipoVeiculo = new System.Windows.Forms.DataGridView();
            this.IdTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGTipoVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição :";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(104, 50);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(402, 20);
            this.TxtDescricao.TabIndex = 10;
            // 
            // DGTipoVeiculo
            // 
            this.DGTipoVeiculo.AllowUserToAddRows = false;
            this.DGTipoVeiculo.AllowUserToDeleteRows = false;
            this.DGTipoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGTipoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTipoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoVeiculo,
            this.Descricao});
            this.DGTipoVeiculo.Location = new System.Drawing.Point(20, 84);
            this.DGTipoVeiculo.Name = "DGTipoVeiculo";
            this.DGTipoVeiculo.ReadOnly = true;
            this.DGTipoVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTipoVeiculo.Size = new System.Drawing.Size(506, 173);
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
            // FrmTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.DGTipoVeiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoVeiculo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo de Veículo";
            this.Load += new System.EventHandler(this.FrmTipoVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTipoVeiculo)).EndInit();
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
    }
}