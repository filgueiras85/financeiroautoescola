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
    public partial class FrmInstrutores : Form
    {
        public FrmInstrutores()
        {
            InitializeComponent();
        }

        private List<Dominio.Instrutor> _ListaInstrutor = new List<GerenciadorFinanceiro.Dominio.Instrutor>();
        private Dominio.Instrutor _Instrutor = new Dominio.Instrutor();

        private void BuscarTodosOsInstrutores()
        {
            Repositorio.RepositorioInstrutor repInstrutor = new Repositorio.RepositorioInstrutor();
            _ListaInstrutor = repInstrutor.BuscarTo;
            DGInstrutores.DataSource = _ListaInstrutor;
        }

        private void FrmInstrutores_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsInstrutores();
            Controles.CtrNavigator ctr = new Controles.CtrNavigator(_ListaInstrutor);
            this.Controls.Add(ctr);
            this.Refresh();
        }
    }
}
