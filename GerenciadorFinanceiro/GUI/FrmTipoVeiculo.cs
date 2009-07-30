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
        private Dominio.TipoVeiculo _TipoVeiculo;
        
        public FrmTipoVeiculo()
        {
            InitializeComponent();
        }

        #region " Eventos da Interface "

        private void ValidaDados()
        {
            if (TxtDescricao.Text.Trim() == String.Empty)
                throw new Exception("O campo descrição é obrigatório.");
            _TipoVeiculo.Descricao = TxtDescricao.Text;
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
            if (_TipoVeiculo == null)
                _TipoVeiculo = new Dominio.TipoVeiculo();
            TxtDescricao.Text = _TipoVeiculo.Descricao;
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

        private void BuscarTodosTiposVeiculos()
        {
            _ListTipoVeiculo = new Repositorio.RepositorioTipoVeiculo().BuscarTodos();
            DGTipoVeiculo.DataSource = _ListTipoVeiculo;
            this.ctrNavigator1.DataSource = _ListTipoVeiculo;
        }

        private void ctrNavigator1_EventoNovo()
        {
            _TipoVeiculo = null;
            _TipoVeiculo = new Dominio.TipoVeiculo();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGTipoVeiculo.SelectedRows.Count > 0)
                _TipoVeiculo = (Dominio.TipoVeiculo)DGTipoVeiculo.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_TipoVeiculo.IdTipoVeiculo == 0)
                    new Repositorio.RepositorioTipoVeiculo().SalvarObjeto(_TipoVeiculo);
                else
                    new Repositorio.RepositorioTipoVeiculo().AtualizarObjeto(_TipoVeiculo);
                this.BuscarTodosTiposVeiculos();
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
                    new Repositorio.RepositorioTipoVeiculo().DeletarObjeto(_TipoVeiculo);
                    this.BuscarTodosTiposVeiculos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
            }
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void FrmTipoVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosTiposVeiculos();
            this.CamposInterface(Status.Consultando);
        }


        private void DGTipoVeiculo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGTipoVeiculo.Rows.Count > 0)
            {
                if (this.DGTipoVeiculo.SelectedRows.Count > 0)
                {
                    this._TipoVeiculo = (Dominio.TipoVeiculo)this.DGTipoVeiculo.SelectedRows[0].DataBoundItem;
                    if (this.ctrNavigator1.DataSource != null && _ListTipoVeiculo.Count > 0)
                        this.ctrNavigator1.Indice = DGTipoVeiculo.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
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
