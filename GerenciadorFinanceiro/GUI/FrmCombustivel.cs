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
    public partial class FrmCombustivel : Form
    {

        private List<Dominio.Veiculo> _ListaCarros;        

        public FrmCombustivel()
        {
            InitializeComponent();
        }

        private void FrmCombustivel_Load(object sender, EventArgs e)
        {
            BuscarCarros();
        }



        private void BuscarCarros()
        {
           _ListaCarros = new Repositorio.RepositorioVeiculo().BuscarTodos();
           cmbVeiculo.DataSource = _ListaCarros;                      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
