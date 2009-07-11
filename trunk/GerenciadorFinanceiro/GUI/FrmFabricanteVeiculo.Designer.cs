namespace GerenciadorFinanceiro.GUI
{
    partial class FrmFabricanteVeiculo
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
            this.DGFabricantes = new System.Windows.Forms.DataGridView();
            this.idFabricanteVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFabricantes
            // 
            this.DGFabricantes.AllowUserToAddRows = false;
            this.DGFabricantes.AllowUserToDeleteRows = false;
            this.DGFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFabricanteVeiculo,
            this.Descricao});
            this.DGFabricantes.Location = new System.Drawing.Point(20, 84);
            this.DGFabricantes.Name = "DGFabricantes";
            this.DGFabricantes.ReadOnly = true;
            this.DGFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFabricantes.Size = new System.Drawing.Size(506, 173);
            this.DGFabricantes.TabIndex = 3;
            // 
            // idFabricanteVeiculo
            // 
            this.idFabricanteVeiculo.DataPropertyName = "idFabricanteVeiculo";
            this.idFabricanteVeiculo.HeaderText = "Código";
            this.idFabricanteVeiculo.Name = "idFabricanteVeiculo";
            this.idFabricanteVeiculo.ReadOnly = true;
            this.idFabricanteVeiculo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Fabricante";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 365;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(104, 50);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(402, 20);
            this.TxtDescricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição :";
            // 
            // FrmFabricanteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.DGFabricantes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabricanteVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fabricante de Veículos";
            this.Load += new System.EventHandler(this.FrmFabricanteVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFabricantes;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFabricanteVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}