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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (_ReceitasFocus)
            {
                MessageBox.Show("Receita");
            }
            else if (_DespesasFocus)
            {
                MessageBox.Show("Despesa");
            }            
        }

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
                treeViewReceitas.Nodes.Add(custo.Descricao).Tag = objeto;
            }
            else
            {
                Dominio.Categoria cat = (Dominio.Categoria)objeto;
                for (int i = 0; i < treeViewReceitas.Nodes.Count; i++)
                {
                    Dominio.CentroCustos Ccustos = (Dominio.CentroCustos)treeViewReceitas.Nodes[i].Tag;
                    if (Ccustos.Id == cat.CategoriaPai.Id)
                    {
                        treeViewReceitas.Nodes[i].Nodes.Add(cat.Descricao).Tag = cat;
                        break;
                    }
                }
            }
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(_DespesasFocus)
            {
                object obj = treeViewReceitas.SelectedNode.Tag;
                if (obj is Dominio.CentroCustos)
                {
                    //new Repositorio.
                }
                else if (obj is Dominio.Categoria)
                {
 
                }

            }
            else if(_ReceitasFocus)
            {

            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            List<Dominio.CentroCustos> listaCustos = new Repositorio.RepositorioCentroCustos().BuscarTodos();
            for (int i = 0; i < listaCustos.Count; i++)
            {
                treeViewReceitas.Nodes.Add(listaCustos[i].Descricao).Tag = listaCustos[i];
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

        private void treeViewReceitas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Tag is Dominio.CentroCustos)
                {
                    Dominio.CentroCustos custos =(Dominio.CentroCustos)e.Node.Tag;
                    List<Dominio.Categoria> listaCat = new Repositorio.RepositorioCategoria().BuscarTodasPorCentroCusto(custos.Id);

                    for (int i = 0; i < listaCat.Count; i++)
                    {
                        e.Node.Nodes.Add(listaCat[i].Descricao).Tag = listaCat[i];   
                    }
                }
            }
        }
    }
}
