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

        private List<Dominio.ModeloVeiculo> _ListaModeloVeiculos = new List<GerenciadorFinanceiro.Dominio.ModeloVeiculo>();
        private Dominio.ModeloVeiculo _ModeloVeiculo = new Dominio.ModeloVeiculo();
        private List<Dominio.FabricanteVeiculo> _ListaFabricanteVeiculo = new List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo>();

        private void ListarTodosOsModelosDeVeiculos()
        {
            _ListaModeloVeiculos = new Repositorio.RepositorioModeloVeiculo().BuscarTodos();
            this.DGModelos.DataSource = _ListaModeloVeiculos;
            ctrNavigator1.DataSource = _ListaModeloVeiculos;
        }

        private void ListarTodosOsFabricantesVeiculos()
        {
            _ListaFabricanteVeiculo = new Repositorio.RepositorioFabricanteVeiculo().BuscarTodos();
            this.CmbFabricanteVeiculo.DisplayMember = "Descricao";
            this.CmbFabricanteVeiculo.ValueMember = "IdFabricanteVeiculo";
            this.CmbFabricanteVeiculo.DataSource = _ListaFabricanteVeiculo;
        }

        private void FrmModeloVeiculo_Load(object sender, EventArgs e)
        {
            this.ListarTodosOsFabricantesVeiculos();
            this.ListarTodosOsModelosDeVeiculos();
            this.CamposInterface(_ModeloVeiculo, Status.Consultando);
        }

        private void CamposInterface(Dominio.ModeloVeiculo modeloVeiculo, Status status)
        {
            TxtDescricao.Text = modeloVeiculo.Descricao;
            if (modeloVeiculo.Fabricante != null)
                CmbFabricanteVeiculo.SelectedValue = modeloVeiculo.Fabricante.IdFabricanteVeiculo;
            else
                CmbFabricanteVeiculo.SelectedIndex = 0;
            if (status == Status.Inserindo)
            {
                TxtDescricao.Enabled = true;
                CmbFabricanteVeiculo.Enabled = true;
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Status.Editando)
            {
                TxtDescricao.Enabled = true;
                CmbFabricanteVeiculo.Enabled = true;
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Status.Excluindo)
            {
                TxtDescricao.Enabled = false;
                CmbFabricanteVeiculo.Enabled = false;
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                TxtDescricao.Enabled = false;
                CmbFabricanteVeiculo.Enabled = false;
                LblStatus.Text = "Status : Consultando";
            }
        }

        private void ctrNavigator1_EventoNovo()
        {
            _ModeloVeiculo = null;
            _ModeloVeiculo = new Dominio.ModeloVeiculo();
            this.CamposInterface(_ModeloVeiculo, Status.Inserindo);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(_ModeloVeiculo, Status.Consultando);
        }

        private void DGModelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGModelos.Columns[e.ColumnIndex].Name == "Fabricante")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.FabricanteVeiculo FabVeiculo = (Dominio.FabricanteVeiculo)e.Value;
                        e.Value = FabVeiculo.Descricao;
                    }
                }
            }
        }

        private void DGModelos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGModelos.Rows.Count > 0)
            {
                if (DGModelos.SelectedRows.Count > 0)
                {
                    _ModeloVeiculo = (Dominio.ModeloVeiculo)DGModelos.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null && ctrNavigator1.DataSource.Count > 0)
                        ctrNavigator1.Indice = DGModelos.SelectedRows[0].Index;
                }
            }
            else
            {
                _ModeloVeiculo = null;
                _ModeloVeiculo = new Dominio.ModeloVeiculo();
            }
            this.CamposInterface(_ModeloVeiculo, Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_ModeloVeiculo, Status.Editando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            //TODO:Validar Campos
            this._ModeloVeiculo.Descricao = TxtDescricao.Text;
            this._ModeloVeiculo.Fabricante = (Dominio.FabricanteVeiculo)CmbFabricanteVeiculo.SelectedItem;
            try
            {
                if (_ModeloVeiculo.IdModeloVeiculo == 0)
                    new Repositorio.RepositorioModeloVeiculo().SalvarObjeto(_ModeloVeiculo);
                else
                    new Repositorio.RepositorioModeloVeiculo().AtualizarObjeto(_ModeloVeiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
            this.ListarTodosOsModelosDeVeiculos();
            this.CamposInterface(_ModeloVeiculo, Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_ModeloVeiculo, Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioModeloVeiculo().DeletarObjeto(_ModeloVeiculo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
                this.ListarTodosOsModelosDeVeiculos();
            }
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGModelos.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGModelos.Rows[i].Selected = true;
                else
                    DGModelos.Rows[i].Selected = false;
            }
        }

    }
}
