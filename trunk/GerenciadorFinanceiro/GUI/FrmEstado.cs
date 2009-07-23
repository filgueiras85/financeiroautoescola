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
    public partial class FrmEstado : Form
    {
        private List<Dominio.Estado> _ListEstados = new List<GerenciadorFinanceiro.Dominio.Estado>();
        private Dominio.Estado _Estado = new Dominio.Estado();

        public FrmEstado()
        {
            InitializeComponent();
        }

        private void BuscarTodosOsEstados()
        {
            _ListEstados = new Repositorio.RepositorioEstado().BuscarTodos();
            this.DGEstados.DataSource = _ListEstados;
            this.ctrNavigator1.DataSource = _ListEstados;
        }

        private void CamposInterface(Dominio.Estado estado, Dominio.Status status)
        {
            TxtNomeEstado.Text = estado.NomeEstado;
            TxtNomeEstado.Focus();
            TxtSiglaUF.Text = estado.SiglaEstado;
            if (status == Dominio.Status.Inserindo)
            {
                TxtNomeEstado.Enabled = true;
                TxtSiglaUF.Enabled = true;
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Dominio.Status.Editando)
            {
                TxtNomeEstado.Enabled = true;
                TxtSiglaUF.Enabled = true;
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Dominio.Status.Excluindo)
            {
                TxtNomeEstado.Enabled = false;
                TxtSiglaUF.Enabled = false;
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                TxtNomeEstado.Enabled = false;
                TxtSiglaUF.Enabled = false;
                LblStatus.Text = "Status : Consultando";
            }
        }

        private void ctrNavigator1_EventoNovo()
        {
            _Estado = null;
            _Estado = new Dominio.Estado();
            this.CamposInterface(_Estado, GerenciadorFinanceiro.Dominio.Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_Estado, GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_Estado, GerenciadorFinanceiro.Dominio.Status.Excluindo);
            //TODO: Confirmação de exclusao
            try
            {
                new Repositorio.RepositorioEstado().DeletarObjeto(_Estado);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodosOsEstados();
        }

        private void ctrNavigator1_CancelarAcao()
        {
            
            if (DGEstados.SelectedRows.Count > 0)
                _Estado = (Dominio.Estado)DGEstados.SelectedRows[0].DataBoundItem;
            this.CamposInterface(_Estado, GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            //TODO:Validar Campos
            this._Estado.NomeEstado = TxtNomeEstado.Text;
            this._Estado.SiglaEstado = TxtSiglaUF.Text;
            try
            {
                if (_Estado.IdEstado == 0)
                    new Repositorio.RepositorioEstado().SalvarObjeto(_Estado);
                else
                    new Repositorio.RepositorioEstado().AtualizarObjeto(_Estado);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodosOsEstados();
            this.CamposInterface(_Estado, Dominio.Status.Consultando);
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsEstados();
            this.CamposInterface(_Estado, Dominio.Status.Consultando);
        }

        private void DGEstados_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGEstados.Rows.Count > 0)
            {
                if (DGEstados.SelectedRows.Count > 0)
                {
                    _Estado = (Dominio.Estado)DGEstados.SelectedRows[0].DataBoundItem;
                    ctrNavigator1.Indice = DGEstados.SelectedRows[0].Index;
                }
            }
            else
            {
                _Estado = null;
                _Estado = new Dominio.Estado();
            }
            this.CamposInterface(_Estado, Dominio.Status.Consultando);
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGEstados.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGEstados.Rows[i].Selected = true;
                else
                    DGEstados.Rows[i].Selected = false;
            }
        }
    }
}
