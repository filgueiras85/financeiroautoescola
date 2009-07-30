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
    public partial class FrmFormaPagamento : Form
    {

        private Dominio.FormaPagamento _FormaPgto;
        private List<Dominio.FormaPagamento> _ListaFormaPgto;

        #region " Eventos da Interface "

        private void ValidaDados()
        {
            if (TxtDescricao.Text.Trim() == String.Empty)
                throw new Exception("O campo descrição é obrigatório.");
            _FormaPgto.Descricao = TxtDescricao.Text;
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
            if (_FormaPgto == null)
                _FormaPgto = new Dominio.FormaPagamento();
            TxtDescricao.Text = _FormaPgto.Descricao;
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

        public FrmFormaPagamento()
        {
            InitializeComponent();
        }

        private void BuscarTodasAsFormasPagamento()
        {
            _ListaFormaPgto = new Repositorio.RepositorioFormaPagamento().BuscarTodos();
            this.DGFormaPagamento.DataSource = _ListaFormaPgto;
            this.ctrNavigator1.DataSource = _ListaFormaPgto;
        }

        #region "Eventos Interface"

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGFormaPagamento.SelectedRows.Count > 0)
                _FormaPgto = (Dominio.FormaPagamento)DGFormaPagamento.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            _FormaPgto = null;
            _FormaPgto = new Dominio.FormaPagamento();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioFormaPagamento().DeletarObjeto(_FormaPgto);
                    this.BuscarTodasAsFormasPagamento();
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
            for (int i = 0; i < DGFormaPagamento.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGFormaPagamento.Rows[i].Selected = true;
                else
                    DGFormaPagamento.Rows[i].Selected = false;
            }
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_FormaPgto.Id == 0)
                    new Repositorio.RepositorioFormaPagamento().SalvarObjeto(_FormaPgto);
                else
                    new Repositorio.RepositorioFormaPagamento().AtualizarObjeto(_FormaPgto);
                this.BuscarTodasAsFormasPagamento();
                this.CamposInterface(Status.Consultando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }

        private void FrmFormaPagamento_Load(object sender, EventArgs e)
        {
            this.BuscarTodasAsFormasPagamento();
            this.CamposInterface(Status.Consultando);
        }
        #endregion

        private void DGFormaPagamento_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGFormaPagamento.Rows.Count > 0)
            {
                if (DGFormaPagamento.SelectedRows.Count > 0)
                {
                    _FormaPgto = (Dominio.FormaPagamento)DGFormaPagamento.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGFormaPagamento.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
        }


    }
}
