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
    public partial class FrmTipoVeiculo : Form
    {

        private List<Dominio.TipoVeiculo> _ListTipoVeiculo = new List<GerenciadorFinanceiro.Dominio.TipoVeiculo>();
        private Dominio.TipoVeiculo _TipoVeiculo = new Dominio.TipoVeiculo();


        public FrmTipoVeiculo()
        {
            InitializeComponent();
        }       

        private bool ValidaDados()
        {
            if (TxtDescricao.Text.Length  > 3) {
                return true;
            } else {
                return false;
            }
        }

        private void BuscarTodosTiposVeiculos()
        {
            _ListTipoVeiculo = new Repositorio.RepositorioTipoVeiculo().BuscarTodos();
            DGTipoVeiculo.DataSource = _ListTipoVeiculo;
            this.ctrNavigator1.DataSource = _ListTipoVeiculo;
        }

        private void CamposInterface(Dominio.TipoVeiculo tipo, Dominio.Status status)
        {
            TxtDescricao.Text = tipo.Descricao;
            TxtDescricao.Focus();
            if (status == Dominio.Status.Inserindo)
            {
                TxtDescricao.Enabled = true;
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Dominio.Status.Editando)
            {
                TxtDescricao.Enabled = true;
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Dominio.Status.Excluindo)
            {
                TxtDescricao.Enabled = false;
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                TxtDescricao.Enabled = false;
                LblStatus.Text = "Status : Consultando";
            }
        }

        private void ctrNavigator1_EventoNovo()
        {
            _TipoVeiculo = null;
            _TipoVeiculo = new Dominio.TipoVeiculo();
            this.CamposInterface(_TipoVeiculo, GerenciadorFinanceiro.Dominio.Status.Inserindo);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGTipoVeiculo.SelectedRows.Count > 0)
                _TipoVeiculo = (Dominio.TipoVeiculo)DGTipoVeiculo.SelectedRows[0].DataBoundItem;
            this.CamposInterface(_TipoVeiculo, GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            //TODO:Validar Campos
            this._TipoVeiculo.Descricao = TxtDescricao.Text;
            try
            {
                if (_TipoVeiculo.IdTipoVeiculo == 0)
                    new Repositorio.RepositorioTipoVeiculo().SalvarObjeto(_TipoVeiculo);
                else
                    new Repositorio.RepositorioTipoVeiculo().AtualizarObjeto(_TipoVeiculo);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodosTiposVeiculos();
            this.CamposInterface(_TipoVeiculo, Dominio.Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {

            this.CamposInterface(_TipoVeiculo, GerenciadorFinanceiro.Dominio.Status.Excluindo);
            //TODO: Confirmação de exclusao
            try
            {
                new Repositorio.RepositorioTipoVeiculo().DeletarObjeto(_TipoVeiculo);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodosTiposVeiculos();
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_TipoVeiculo, GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void FrmTipoVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosTiposVeiculos();            
        }


        private void DGTipoVeiculo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGTipoVeiculo.Rows.Count > 0)
            {
                if (this.DGTipoVeiculo.SelectedRows.Count > 0)
                {
                    this._TipoVeiculo = (Dominio.TipoVeiculo)this.DGTipoVeiculo.SelectedRows[0].DataBoundItem;
                    ctrNavigator1.Indice = DGInstrutores.SelectedRows[0].Index;
                }
            }
            else
            {
                this._TipoVeiculo = null;
                this._TipoVeiculo = new Dominio.TipoVeiculo();
            }
            this.CamposInterface(_TipoVeiculo, GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGTipoVeiculo.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGTipoVeiculo.Rows[i].Selected = true;
                else
                    DGTipoVeiculo.Rows[i].Selected = false;
            }
        }

    }
}
