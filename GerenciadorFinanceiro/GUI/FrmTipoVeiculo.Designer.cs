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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnPrimeiro = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.idFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGTipoVeiculo)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição :";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(112, 55);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(404, 20);
            this.TxtDescricao.TabIndex = 10;
            // 
            // DGTipoVeiculo
            // 
            this.DGTipoVeiculo.AllowUserToAddRows = false;
            this.DGTipoVeiculo.AllowUserToDeleteRows = false;
            this.DGTipoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGTipoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTipoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFabricante,
            this.Descricao});
            this.DGTipoVeiculo.Location = new System.Drawing.Point(13, 86);
            this.DGTipoVeiculo.Name = "DGTipoVeiculo";
            this.DGTipoVeiculo.ReadOnly = true;
            this.DGTipoVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTipoVeiculo.Size = new System.Drawing.Size(530, 136);
            this.DGTipoVeiculo.TabIndex = 9;
            this.DGTipoVeiculo.SelectionChanged += new System.EventHandler(this.DGTipoVeiculo_SelectionChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::GerenciadorFinanceiro.Properties.Resources._85551;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Controls.Add(this.BtnPrimeiro);
            this.PnlBotoes.Controls.Add(this.BtnExcluir);
            this.PnlBotoes.Controls.Add(this.BtnAnterior);
            this.PnlBotoes.Controls.Add(this.BtnSalvar);
            this.PnlBotoes.Controls.Add(this.BtnProximo);
            this.PnlBotoes.Controls.Add(this.BtnCancelar);
            this.PnlBotoes.Controls.Add(this.BtnUltimo);
            this.PnlBotoes.Controls.Add(this.BtnEditar);
            this.PnlBotoes.Controls.Add(this.BtnNovo);
            this.PnlBotoes.Location = new System.Drawing.Point(10, 9);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(538, 34);
            this.PnlBotoes.TabIndex = 12;
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.Image = global::GerenciadorFinanceiro.Properties.Resources.primeiro;
            this.BtnPrimeiro.Location = new System.Drawing.Point(3, 3);
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(35, 28);
            this.BtnPrimeiro.TabIndex = 0;
            this.BtnPrimeiro.UseVisualStyleBackColor = true;
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::GerenciadorFinanceiro.Properties.Resources.trash;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(463, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(70, 28);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "     Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Image = global::GerenciadorFinanceiro.Properties.Resources.anterior;
            this.BtnAnterior.Location = new System.Drawing.Point(43, 3);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(35, 28);
            this.BtnAnterior.TabIndex = 1;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::GerenciadorFinanceiro.Properties.Resources.disc;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(388, 3);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(70, 28);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "     Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Image = global::GerenciadorFinanceiro.Properties.Resources.proximo;
            this.BtnProximo.Location = new System.Drawing.Point(83, 3);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(35, 28);
            this.BtnProximo.TabIndex = 2;
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::GerenciadorFinanceiro.Properties.Resources.Cancel;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(313, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(70, 28);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Image = global::GerenciadorFinanceiro.Properties.Resources.ultimo;
            this.BtnUltimo.Location = new System.Drawing.Point(123, 3);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(35, 28);
            this.BtnUltimo.TabIndex = 3;
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = global::GerenciadorFinanceiro.Properties.Resources.file_edit;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(238, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 28);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "    Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(163, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(70, 28);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "     Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // idFabricante
            // 
            this.idFabricante.DataPropertyName = "IdTipoVeiculo";
            this.idFabricante.HeaderText = "Código";
            this.idFabricante.Name = "idFabricante";
            this.idFabricante.ReadOnly = true;
            this.idFabricante.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Tipo de Veículo";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 400;
            // 
            // FrmTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 236);
            this.Controls.Add(this.PnlBotoes);
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
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.DataGridView DGTipoVeiculo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnPrimeiro;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}