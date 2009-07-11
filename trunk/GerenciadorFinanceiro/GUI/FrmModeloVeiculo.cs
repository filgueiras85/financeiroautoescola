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
    public partial class FrmModeloVeiculo : Form
    {
        public FrmModeloVeiculo()
        {
            InitializeComponent();
        }

        private List<Dominio.ModeloVeiculo> _ListaModeloVeiculos;

        private void ListarTodosOsModelosDeVeiculos()
        {
           // Repositorio.RepositorioModeloVeiculo  repModeloVeiculo = new Repositorio.RepositorioModeloVeiculo();
            //_ListaModeloVeiculos = repModeloVeiculo.BuscarTodos();
            Dominio.ModeloVeiculo modVeiculo = new Dominio.ModeloVeiculo();
            modVeiculo.IdModeloVeiculo = 1;
            modVeiculo.Descricao = "Gol";
            _ListaModeloVeiculos.Add(modVeiculo);
            modVeiculo.IdModeloVeiculo = 2;
            modVeiculo.Descricao = "Corsa";
            _ListaModeloVeiculos.Add(modVeiculo);
            modVeiculo.IdModeloVeiculo = 3;
            modVeiculo.Descricao = "Palio";
            _ListaModeloVeiculos.Add(modVeiculo);
            this.DGModelos.DataSource = _ListaModeloVeiculos;
        }

        private void FrmModeloVeiculo_Load(object sender, EventArgs e)
        {
            this.ListarTodosOsModelosDeVeiculos();
            Controles.CtrNavigator ctr = new Controles.CtrNavigator(_ListaModeloVeiculos);
            this.Controls.Add(ctr);
            this.Refresh();
        }

        private void DGModelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGModelos.Columns[e.ColumnIndex].Name == "idFabricante")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.FabricanteVeiculo FabVeiculo = (Dominio.FabricanteVeiculo)DGModelos.Rows[e.RowIndex].Cells["idFabricante"].Value;
                        e.Value = FabVeiculo.Descricao;
                    }
                }
            }
        }
    }
}
