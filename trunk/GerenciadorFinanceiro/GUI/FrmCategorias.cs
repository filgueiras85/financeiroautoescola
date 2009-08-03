using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorFinanceiro.GUI
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private bool _DespesasFocus;
        private bool _ReceitasFocus;

        private void treeViewReceitas_Enter(object sender, EventArgs e)
        {
            _DespesasFocus = false;
            _ReceitasFocus = true;
        }

        private void treeViewDespesas_Enter(object sender, EventArgs e)
        {
            _DespesasFocus = true;
            _ReceitasFocus = false;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FrmCadCategoria form = new FrmCadCategoria();
            form.Finalizando +=new FrmCadCategoria.FinalizaInsercao(Handler_FinalizarCadastro);
            form.ShowDialog();
        }

        private void Handler_FinalizarCadastro(object objeto)
        {
            if (objeto is Dominio.CentroCustos)
            {
                Dominio.CentroCustos custo = (Dominio.CentroCustos)objeto;
                if(custo.ReceitaOuDespesa == GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Receita )
                    treeViewReceitas.Nodes.Add(custo.Id.ToString(), custo.Descricao, 1, 1).Tag = objeto;
                else
                    treeViewDespesas.Nodes.Add(custo.Id.ToString(), custo.Descricao, 1, 1).Tag = objeto;
                
            }
            else
            {
                Dominio.Categoria cat = (Dominio.Categoria)objeto;
                if (cat.CategoriaPai.ReceitaOuDespesa == GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Receita)
                {
                    for (int i = 0; i < treeViewReceitas.Nodes.Count; i++)
                    {
                        Dominio.CentroCustos Ccustos = (Dominio.CentroCustos)treeViewReceitas.Nodes[i].Tag;
                        if (Ccustos.Id == cat.CategoriaPai.Id)
                        {
                            treeViewReceitas.Nodes[i].Nodes.Add(cat.Id.ToString(), cat.Descricao, 0).Tag = cat;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < treeViewDespesas.Nodes.Count; i++)
                    {
                        Dominio.CentroCustos Ccustos = (Dominio.CentroCustos)treeViewDespesas.Nodes[i].Tag;
                        if (Ccustos.Id == cat.CategoriaPai.Id)
                        {
                            treeViewDespesas.Nodes[i].Nodes.Add(cat.Id.ToString(), cat.Descricao, 0).Tag = cat;
                            break;
                        }
                    }
                }
            }
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_DespesasFocus)
                {
                    object obj = treeViewReceitas.SelectedNode.Tag;
                    if (obj is Dominio.CentroCustos)
                    {
                        new Repositorio.RepositorioCentroCustos().DeletarObjeto((Dominio.CentroCustos)obj);
                    }
                    else if (obj is Dominio.Categoria)
                    {
                        new Repositorio.RepositorioCategoria().DeletarObjeto((Dominio.Categoria)obj);
                    }                    
                }
                else if (_ReceitasFocus)
                {
                    object obj = treeViewReceitas.SelectedNode.Tag;
                    if (obj is Dominio.CentroCustos)
                    {
                        new Repositorio.RepositorioCentroCustos().DeletarObjeto((Dominio.CentroCustos)obj);
                    }
                    else if (obj is Dominio.Categoria)
                    {
                        new Repositorio.RepositorioCategoria().DeletarObjeto((Dominio.Categoria)obj);
                    }
                }
                CarregaArvore();
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaArvore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção.");
            }
        }


        private void CarregaArvore()
        {
            treeViewReceitas.Nodes.Clear();
            treeViewDespesas.Nodes.Clear();

            List<Dominio.CentroCustos> listaCustos = new Repositorio.RepositorioCentroCustos().BuscarTodos();
            for (int i = 0; i < listaCustos.Count; i++)
            {
                List<Dominio.Categoria> listaCat = new Repositorio.RepositorioCategoria().BuscarTodasPorCentroCusto(listaCustos[i].Id);
                TreeNode node;
                if (listaCustos[i].ReceitaOuDespesa == GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Receita)
                {
                    node = treeViewReceitas.Nodes.Add(listaCustos[i].Id.ToString(), listaCustos[i].Descricao, 1, 1);
                    node.Tag = listaCustos[i];
                }
                else
                {
                    node = treeViewDespesas.Nodes.Add(listaCustos[i].Id.ToString(), listaCustos[i].Descricao, 1, 1);
                    node.Tag = listaCustos[i];
                }
                for (int j = 0; j < listaCat.Count; j++)
                {
                    node.Nodes.Add(listaCat[j].Descricao).Tag = listaCat[j];
                }
            }
        }

        private void treeViewReceitas_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Node.Tag is Dominio.CentroCustos)
                {
                    Dominio.CentroCustos custos = (Dominio.CentroCustos)e.Node.Tag;
                    custos.Descricao = e.Label;
                    new Repositorio.RepositorioCentroCustos().AtualizarObjeto(custos);
                }
                else
                {
                    Dominio.Categoria cat = (Dominio.Categoria)e.Node.Tag;
                    cat.Descricao = e.Label;
                    new Repositorio.RepositorioCategoria().AtualizarObjeto(cat);
                }
            }
        }
    }
}
