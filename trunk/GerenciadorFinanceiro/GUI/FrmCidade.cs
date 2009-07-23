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
    public partial class FrmCidade : Form
    {

        private List<Dominio.Cidade> _ListCidades = new List<GerenciadorFinanceiro.Dominio.Cidade>();
        private List<Dominio.Estado> _ListEstados = new List<GerenciadorFinanceiro.Dominio.Estado>();
        private Dominio.Cidade _Cidade = new Dominio.Cidade();

        public FrmCidade()
        {
            InitializeComponent();
        }

        private void BuscarTodosOsEstados()
        {
            _ListEstados = new Repositorio.RepositorioEstado().BuscarTodos();
            this.CmbEstados.DisplayMember = "NomeEstado";
            this.CmbEstados.ValueMember = "IdEstado";
            this.CmbEstados.DataSource = _ListEstados;          
        }

        private void BuscarTodasAsCidades()
        {
            _ListCidades = new Repositorio.RepositorioCidade().BuscarTodos();
            this.DGCidades.DataSource = _ListCidades;
            ctrNavigator1.DataSource = _ListCidades;
        }

        private void CamposInterface(Dominio.Cidade cidade, Dominio.Status status)
        {
            TxtNomeCidade.Text = cidade.NomeCidade;
            if (cidade.Estado != null)
                CmbEstados.SelectedValue = cidade.Estado.IdEstado;
            else
                CmbEstados.SelectedIndex = 0;
            if (status == Dominio.Status.Inserindo)
            {
                TxtNomeCidade.Enabled = true;
                CmbEstados.Enabled = true;
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Dominio.Status.Editando)
            {
                TxtNomeCidade.Enabled = true;
                CmbEstados.Enabled = true;
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Dominio.Status.Excluindo)
            {
                TxtNomeCidade.Enabled = false;
                TxtNomeCidade.Enabled = false;
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                TxtNomeCidade.Enabled = false;
                CmbEstados.Enabled = false;
                LblStatus.Text = "Status : Consultando";
            }
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGCidades.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGCidades.Rows[i].Selected = true;
                else
                    DGCidades.Rows[i].Selected = false;
            }
        }

        private void ctrNavigator1_EventoNovo()
        {
            _Cidade = null;
            _Cidade = new Dominio.Cidade();
            this.CamposInterface(_Cidade, GerenciadorFinanceiro.Dominio.Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_Cidade, GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(_Cidade, GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            //TODO:Validar Campos
            this._Cidade.NomeCidade = TxtNomeCidade.Text;
            this._Cidade.Estado = (Dominio.Estado)CmbEstados.SelectedItem;
            try
            {
                if (_Cidade.IdCidade == 0)
                    new Repositorio.RepositorioCidade().SalvarObjeto(_Cidade);
                else
                    new Repositorio.RepositorioCidade().AtualizarObjeto(_Cidade);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodasAsCidades();
            this.CamposInterface(_Cidade, Dominio.Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_Cidade, GerenciadorFinanceiro.Dominio.Status.Excluindo);
            //TODO: Confirmação de exclusao
            try
            {
                new Repositorio.RepositorioCidade().DeletarObjeto(_Cidade);
            }
            catch (Exception ex)
            {

            }
        }

        private void DGCidades_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGCidades.Rows.Count > 0)
            {
                if (DGCidades.SelectedRows.Count > 0)
                {
                    _Cidade = (Dominio.Cidade)DGCidades.SelectedRows[0].DataBoundItem;
                    ctrNavigator1.Indice = DGCidades.SelectedRows[0].Index;
                }
            }
            else
            {
                _Cidade = null;
                _Cidade = new Dominio.Cidade();
            }
            this.CamposInterface(_Cidade, Dominio.Status.Consultando);
        }

        private void DGCidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGCidades.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.Estado estado = (Dominio.Estado)e.Value;
                        e.Value = estado.NomeEstado;
                    }
                }
            }
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsEstados();
            this.BuscarTodasAsCidades();            
        }

    }
}
