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
        private Dominio.FabricanteVeiculo _FabricanteVeiculo;

        private void CamposInterface(Dominio.FabricanteVeiculo fabVeiculo, Status status)
        {
            TxtDescricao.Text = fabVeiculo.Descricao;
            if (status == Status.Inserindo)
            {
                TxtDescricao.Enabled = true;
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Status.Editando)
            {
                TxtDescricao.Enabled = true;
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Status.Excluindo)
            {
                TxtDescricao.Enabled = false;
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                TxtDescricao.Enabled = false;
                LblStatus.Text = "Status : Consultando";
            }
            this.Refresh();
        }

        private void BuscarTodosFabricantesVeiculos()
        {
            Repositorio.RepositorioFabricanteVeiculo repFabVeiculo = new Repositorio.RepositorioFabricanteVeiculo();
            _ListaFabricanteVeiculo = repFabVeiculo.BuscarTodos();
            this.DGFabricantes.DataSource = _ListaFabricanteVeiculo;
            this.ctrNavigator1.DataSource = _ListaFabricanteVeiculo;
        }

        private void FrmFabricanteVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosFabricantesVeiculos();
            _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            this.CamposInterface(_FabricanteVeiculo, Status.Consultando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            this.CamposInterface(_FabricanteVeiculo, Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_FabricanteVeiculo, Status.Editando);            
        }

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(_FabricanteVeiculo, Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            this._FabricanteVeiculo.Descricao = TxtDescricao.Text;
            try
            {
                if (_FabricanteVeiculo.IdFabricanteVeiculo == 0)
                    new Repositorio.RepositorioFabricanteVeiculo().SalvarObjeto(_FabricanteVeiculo);
                else
                    new Repositorio.RepositorioFabricanteVeiculo().AtualizarObjeto(_FabricanteVeiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
            this.BuscarTodosFabricantesVeiculos();
            this.CamposInterface(_FabricanteVeiculo, Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_FabricanteVeiculo, Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioFabricanteVeiculo().DeletarObjeto(_FabricanteVeiculo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
                this.BuscarTodosFabricantesVeiculos();
            }
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGFabricantes.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGFabricantes.Rows[i].Selected = true;
                else
                    DGFabricantes.Rows[i].Selected = false;
            }
        }

        private void DGFabricantes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGFabricantes.Rows.Count > 0)
            {
                if (DGFabricantes.SelectedRows.Count > 0)
                {
                    _FabricanteVeiculo = (Dominio.FabricanteVeiculo)DGFabricantes.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGFabricantes.SelectedRows[0].Index;
                }
            }
            else
            {
                _FabricanteVeiculo = null;
                _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            }
            this.CamposInterface(_FabricanteVeiculo, Status.Consultando);
        }
    }
}
