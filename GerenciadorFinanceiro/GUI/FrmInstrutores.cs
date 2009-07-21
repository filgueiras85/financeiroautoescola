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
        private List<Dominio.Cidade> _ListaCidade = new List<GerenciadorFinanceiro.Dominio.Cidade>();
        private Dominio.Instrutor _Instrutor = new Dominio.Instrutor();

        private void BuscarTodosOsInstrutores()
        {
            Repositorio.RepositorioInstrutor repInstrutor = new Repositorio.RepositorioInstrutor();
            _ListaInstrutor = repInstrutor.BuscarTodos();
            DGInstrutores.DataSource = _ListaInstrutor;
            this.ctrNavigator1.DataSource = _ListaInstrutor;
        }

        private void FrmInstrutores_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsInstrutores();            
            this.Refresh();
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            Dominio.Instrutor instrutor = (Dominio.Instrutor)objetoAtual;
            this.TxtNomeInstrutor.Text = instrutor.Nome;
        }

        private void DGInstrutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGInstrutores.Columns[e.ColumnIndex].Name == "Rua")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.Endereco endereco = (Dominio.Endereco)e.Value;//DGInstrutores.Rows[e.RowIndex].Cells["Rua"]
                        e.Value = endereco.Rua;
                        DGInstrutores.Rows[e.RowIndex].Cells["Numero"].Value = endereco.Numero;
                        DGInstrutores.Rows[e.RowIndex].Cells["Complemento"].Value = endereco.Complemento;
                        DGInstrutores.Rows[e.RowIndex].Cells["Bairro"].Value = endereco.Bairro;
                        DGInstrutores.Rows[e.RowIndex].Cells["CEP"].Value = endereco.CEP;
                        DGInstrutores.Rows[e.RowIndex].Cells["Cidade"].Value = endereco.Cidade.NomeCidade;
                    }
                }
            }
        }
     }
}
