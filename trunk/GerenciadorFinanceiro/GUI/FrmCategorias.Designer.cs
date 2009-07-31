namespace GerenciadorFinanceiro.GUI
{
    partial class FrmCategorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewReceitas = new System.Windows.Forms.TreeView();
            this.treeViewDespesas = new System.Windows.Forms.TreeView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewReceitas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeViewDespesas);
            this.splitContainer1.Size = new System.Drawing.Size(533, 464);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewReceitas
            // 
            this.treeViewReceitas.ImageIndex = 0;
            this.treeViewReceitas.ImageList = this.imageList1;
            this.treeViewReceitas.LabelEdit = true;
            this.treeViewReceitas.Location = new System.Drawing.Point(3, 3);
            this.treeViewReceitas.Name = "treeViewReceitas";
            this.treeViewReceitas.SelectedImageIndex = 0;
            this.treeViewReceitas.Size = new System.Drawing.Size(255, 458);
            this.treeViewReceitas.TabIndex = 0;
            this.treeViewReceitas.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewReceitas_AfterLabelEdit);
            this.treeViewReceitas.Enter += new System.EventHandler(this.treeViewReceitas_Enter);
            this.treeViewReceitas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewReceitas_AfterSelect);
            // 
            // treeViewDespesas
            // 
            this.treeViewDespesas.Location = new System.Drawing.Point(7, 3);
            this.treeViewDespesas.Name = "treeViewDespesas";
            this.treeViewDespesas.Size = new System.Drawing.Size(255, 458);
            this.treeViewDespesas.TabIndex = 1;
            this.treeViewDespesas.Enter += new System.EventHandler(this.treeViewDespesas_Enter);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::GerenciadorFinanceiro.Properties.Resources.trash;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(104, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(70, 28);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "     Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Image = global::GerenciadorFinanceiro.Properties.Resources.file_add;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(28, 12);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(70, 28);
            this.BtnNovo.TabIndex = 9;
            this.BtnNovo.Text = "     Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 495);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Doc.png");
            this.imageList1.Images.SetKeyName(1, "Folder.png");
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnNovo);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewReceitas;
        private System.Windows.Forms.TreeView treeViewDespesas;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}