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
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DGFabricantes = new System.Windows.Forms.DataGridView();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.idFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(80, 47);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(167, 47);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(251, 47);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // DGFabricantes
            // 
            this.DGFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.idFabricante,
            this.Descricao});
            this.DGFabricantes.Location = new System.Drawing.Point(12, 82);
            this.DGFabricantes.Name = "DGFabricantes";
            this.DGFabricantes.Size = new System.Drawing.Size(332, 136);
            this.DGFabricantes.TabIndex = 3;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(80, 17);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(246, 20);
            this.TxtDescricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição :";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::GerenciadorFinanceiro.Properties.Resources._85551;
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // idFabricante
            // 
            this.idFabricante.HeaderText = "Código";
            this.idFabricante.Name = "idFabricante";
            this.idFabricante.Width = 50;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Fabricante";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 180;
            // 
            // FrmFabricanteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.DGFabricantes);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabricanteVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fabricante de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.DGFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DGFabricantes;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}