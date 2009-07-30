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

        #region " Eventos da Interface "

        private void ValidaDados()
        {
            if (TxtNomeEstado.Text.Trim() == String.Empty)
                throw new Exception("O campo estado é obrigatório.");
            if (TxtSiglaUF.Text.Trim() == String.Empty)
                throw new Exception("O campo sigla é obrigatório.");
            _Estado.NomeEstado = TxtNomeEstado.Text;
            _Estado.SiglaEstado = TxtSiglaUF.Text;
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
            if (_Estado == null)
                _Estado = new Dominio.Estado();
            TxtNomeEstado.Text = _Estado.NomeEstado;
            TxtNomeEstado.Focus();
            TxtSiglaUF.Text = _Estado.SiglaEstado;
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

        private void BuscarTodosOsEstados()
        {
            _ListEstados = new Repositorio.RepositorioEstado().BuscarTodos();
            this.DGEstados.DataSource = _ListEstados;
            this.ctrNavigator1.DataSource = _ListEstados;
        }
              
        private void ctrNavigator1_EventoNovo()
        {
            _Estado = null;
            _Estado = new Dominio.Estado();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioEstado().DeletarObjeto(_Estado);
                    this.BuscarTodosOsEstados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
            }
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_CancelarAcao()
        {            
            if (DGEstados.SelectedRows.Count > 0)
                _Estado = (Dominio.Estado)DGEstados.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_Estado.IdEstado == 0)
                    new Repositorio.RepositorioEstado().SalvarObjeto(_Estado);
                else
                    new Repositorio.RepositorioEstado().AtualizarObjeto(_Estado);
                this.BuscarTodosOsEstados();
                this.CamposInterface(Status.Consultando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsEstados();
            this.CamposInterface(Status.Consultando);
        }

        private void DGEstados_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGEstados.Rows.Count > 0)
            {
                if (DGEstados.SelectedRows.Count > 0)
                {
                    _Estado = (Dominio.Estado)DGEstados.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGEstados.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            DGEstados.Rows[ctrNavigator1.Indice].Selected = true; 
        }
    }
}
