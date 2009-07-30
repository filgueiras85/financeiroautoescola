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

        #region " Campos Interface "

        private void ValidaDados()
        {
            if (TxtNomeCidade.Text.Trim() == String.Empty)
                throw new Exception("O campo Cidade é obrigatório.");
            if (CmbEstados.SelectedValue == null )
                throw new Exception("O campo estado é obrigatório.");
            _Cidade.NomeCidade = TxtNomeCidade.Text;
            _Cidade.Estado = (Dominio.Estado)CmbEstados.SelectedItem;
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
            if (_Cidade == null)
                _Cidade = new Dominio.Cidade();
            TxtNomeCidade.Text = _Cidade.NomeCidade;
            if (_Cidade.Estado != null)
                CmbEstados.SelectedValue = _Cidade.Estado.IdEstado;
            else
                CmbEstados.SelectedIndex = 0;
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
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGCidades.SelectedRows.Count > 0)
                _Cidade = (Dominio.Cidade)DGCidades.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_Cidade.IdCidade == 0)
                    new Repositorio.RepositorioCidade().SalvarObjeto(_Cidade);
                else
                    new Repositorio.RepositorioCidade().AtualizarObjeto(_Cidade);
                this.BuscarTodasAsCidades();
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
                    new Repositorio.RepositorioCidade().DeletarObjeto(_Cidade);
                    this.BuscarTodasAsCidades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }                
            }
            this.CamposInterface(Status.Consultando);
        }

        private void DGCidades_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGCidades.Rows.Count > 0)
            {
                if (DGCidades.SelectedRows.Count > 0)
                {
                    _Cidade = (Dominio.Cidade)DGCidades.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGCidades.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
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

        private void btnNovoEstado_Click(object sender, EventArgs e)
        {
            GUI.FrmEstado frm = new FrmEstado();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodosOsEstados();
        }

    }
}
