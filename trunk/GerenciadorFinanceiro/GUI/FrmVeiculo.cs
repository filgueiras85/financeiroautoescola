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
    public partial class FrmVeiculo : Form
    {

        private List<Dominio.Veiculo> _ListaVeiculos = new List<GerenciadorFinanceiro.Dominio.Veiculo>();
        private List<Dominio.TipoVeiculo> _ListaTipoVeiculo = new List<GerenciadorFinanceiro.Dominio.TipoVeiculo>();
        private List<Dominio.ModeloVeiculo> _ListaModeloVeiculo = new List<GerenciadorFinanceiro.Dominio.ModeloVeiculo>();
        private Dominio.Veiculo _Veiculo = new Dominio.Veiculo();

        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {

        }

    }
}
