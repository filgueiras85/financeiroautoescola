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

        #region " Eventos da Interface "

        private void ValidaDados()
        {
            if (TxtDescricao.Text.Trim() == String.Empty)
                throw new Exception("O campo descrição é obrigatório.");
            _FabricanteVeiculo.Descricao = TxtDescricao.Text;
        }

        private void EnabledCampos(bool enabled)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ComboBox)
                    ((ComboBox)ctr).Enabled = enabled;
                else if (ctr is TextBox)
                    ((TextBox)ctr).Enabled = enabled;
                else if (ctr is MaskedTextBox)
                    ((MaskedTextBox)ctr).Enabled = enabled;
                else if (ctr is Button)
                    ((Button)ctr).Enabled = enabled;
            }
        }

        private void CamposInterface(Status status)
        {
            if (_FabricanteVeiculo == null)
                _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            TxtDescricao.Text = _FabricanteVeiculo.Descricao;
            if (status == Status.Inserindo)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Status.Editando)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Status.Excluindo)
            {
                this.EnabledCampos(false);
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                this.EnabledCampos(false);
                LblStatus.Text = "Status : Consultando";
            }
        }

        #endregion

        private void BuscarTodosFabricantesVeiculos()
        {
            _ListaFabricanteVeiculo = new Repositorio.RepositorioFabricanteVeiculo().BuscarTodos();
            this.DGFabricantes.DataSource = _ListaFabricanteVeiculo;
            this.ctrNavigator1.DataSource = _ListaFabricanteVeiculo;
        }

        private void FrmFabricanteVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosFabricantesVeiculos();
            _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            _FabricanteVeiculo = new Dominio.FabricanteVeiculo();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);            
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGFabricantes.SelectedRows.Count > 0)
                _FabricanteVeiculo = (Dominio.FabricanteVeiculo)DGFabricantes.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_FabricanteVeiculo.IdFabricanteVeiculo == 0)
                    new Repositorio.RepositorioFabricanteVeiculo().SalvarObjeto(_FabricanteVeiculo);
                else
                    new Repositorio.RepositorioFabricanteVeiculo().AtualizarObjeto(_FabricanteVeiculo);
                this.BuscarTodosFabricantesVeiculos();
                this.CamposInterface(Status.Consultando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioFabricanteVeiculo().DeletarObjeto(_FabricanteVeiculo);
                    this.BuscarTodosFabricantesVeiculos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }               
            }
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            DGFabricantes.Rows[ctrNavigator1.Indice].Selected = true; 
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
            this.CamposInterface(Status.Consultando);
        }
    }
}
