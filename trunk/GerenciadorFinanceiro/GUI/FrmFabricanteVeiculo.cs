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
    public partial class FrmFabricanteVeiculo : Form
    {
        public FrmFabricanteVeiculo()
        {
            InitializeComponent();
        }

        private List<Dominio.FabricanteVeiculo> _ListaFabricanteVeiculo;

        private void BuscarTodosFabricantesVeiculos()
        {
            
            _ListaFabricanteVeiculo = new List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo>();
            
            //Repositorio.RepositorioFabricanteVeiculo repFabVeiculo = new Repositorio.RepositorioFabricanteVeiculo();
            //_ListaFabricanteVeiculo = repFabVeiculo.BuscarTodos();
            
            Dominio.FabricanteVeiculo fabVeiculo = new Dominio.FabricanteVeiculo();
            fabVeiculo.IdFabricanteVeiculo = 1;
            fabVeiculo.Descricao = "Volkswagem";
            _ListaFabricanteVeiculo.Add(fabVeiculo);
            fabVeiculo = new Dominio.FabricanteVeiculo();
            fabVeiculo.IdFabricanteVeiculo = 2;
            fabVeiculo.Descricao = "Chevrolet";
            _ListaFabricanteVeiculo.Add(fabVeiculo);
            fabVeiculo = new Dominio.FabricanteVeiculo();
            fabVeiculo.IdFabricanteVeiculo = 3;
            fabVeiculo.Descricao = "Fiat";
            _ListaFabricanteVeiculo.Add(fabVeiculo);


            this.DGFabricantes.DataSource = _ListaFabricanteVeiculo;
        }

        private void FrmFabricanteVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosFabricantesVeiculos();
            Controles.CtrNavigator ctr = new Controles.CtrNavigator(_ListaFabricanteVeiculo);
            this.Controls.Add(ctr);
            this.Refresh();
        }
    }
}
