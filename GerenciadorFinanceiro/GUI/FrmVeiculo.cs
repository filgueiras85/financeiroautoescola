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
    public partial class FrmVeiculo : Form
    {

        private List<Dominio.Veiculo> _ListaVeiculos = new List<GerenciadorFinanceiro.Dominio.Veiculo>();
        private List<Dominio.TipoVeiculo> _ListaTipoVeiculo = new List<GerenciadorFinanceiro.Dominio.TipoVeiculo>();
        private List<Dominio.ModeloVeiculo> _ListaModeloVeiculo = new List<GerenciadorFinanceiro.Dominio.ModeloVeiculo>();
        private Dominio.Veiculo _Veiculo = new Dominio.Veiculo();

        public FrmVeiculo()
        {
            InitializeComponent();
        }

        #region " Campos Interface "

        private void ValidaDados()
        {
            if (TxtPlaca.Text.Trim() == String.Empty)
                throw new Exception("O campo placa é obrigatório.");
            if (TxtCor.Text.Trim() == String.Empty)
                throw new Exception("O campo cor é obrigatório.");
            if (TxtAno.Text.Trim() == String.Empty)
                throw new Exception("O campo ano é obrigatório.");
            if (CmbTipo.SelectedValue == null)
                throw new Exception("O campo tipo é obrigatório.");
            if (CmbModelo.SelectedValue == null)
                throw new Exception("O campo modelo é obrigatório.");
            if (CmbCombustivel.SelectedText == String.Empty)
                throw new Exception("O campo combustível é obrigatório.");
            this._Veiculo.Placa = TxtPlaca.Text;
            this._Veiculo.Renavam = TxtRenavam.Text;
            this._Veiculo.Chassi = TxtChassi.Text;
            this._Veiculo.TipoVeiculo = (Dominio.TipoVeiculo)CmbTipo.SelectedItem;
            this._Veiculo.Combustivel = CmbCombustivel.Text;
            this._Veiculo.Cor = TxtCor.Text;
            this._Veiculo.Ano = int.Parse(TxtAno.Text);
            this._Veiculo.Modelo = int.Parse(TxtAnoModelo.Text);
            this._Veiculo.ModeloVeiculo = (Dominio.ModeloVeiculo)CmbModelo.SelectedItem;
            this._Veiculo.Observacao = TxtObservacao.Text;
            if (this._Veiculo.PathFoto == null)
                this._Veiculo.PathFoto = "";
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
            if (_Veiculo == null)
                _Veiculo  = new Dominio.Veiculo();
            TxtPlaca.Text = _Veiculo.Placa;
            TxtRenavam.Text = _Veiculo.Renavam;
            TxtChassi.Text = _Veiculo.Chassi;
            CmbCombustivel.SelectedText = _Veiculo.Combustivel;
            TxtAno.Text = _Veiculo.Ano.ToString();
            TxtCor.Text = _Veiculo.Cor;
            TxtAnoModelo.Text = _Veiculo.Modelo.ToString();
            TxtObservacao.Text = _Veiculo.Observacao;
            if (_Veiculo.TipoVeiculo.IdTipoVeiculo > 0)
            {
                CmbTipo.SelectedValue = _Veiculo.TipoVeiculo.IdTipoVeiculo;
                CmbModelo.SelectedValue = _Veiculo.ModeloVeiculo.IdModeloVeiculo;
            }
            else
            {
                CmbTipo.SelectedIndex = 0;
                CmbModelo.SelectedIndex = 0;
            }
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

        private void BuscarTodosOsVeiculos()
        {
            _ListaVeiculos = new Repositorio.RepositorioVeiculo().BuscarTodos();
            DGVeiculos.DataSource = _ListaVeiculos;
            this.ctrNavigator1.DataSource = _ListaVeiculos;
        }

        private void BuscarTodosOsTiposVeiculo()
        {
            _ListaTipoVeiculo = new Repositorio.RepositorioTipoVeiculo().BuscarTodos();
            CmbTipo.DisplayMember = "Descricao";
            CmbTipo.ValueMember = "IdTipoVeiculo";
            CmbTipo.DataSource = _ListaTipoVeiculo;
        }

        private void BuscarTodosOsModelosVeiculos()
        {
            _ListaModeloVeiculo = new Repositorio.RepositorioModeloVeiculo().BuscarTodos();
            CmbModelo.DisplayMember = "Descricao";
            CmbModelo.ValueMember = "IdModeloVeiculo";
            CmbModelo.DataSource = _ListaModeloVeiculo;
        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsTiposVeiculo();
            this.BuscarTodosOsModelosVeiculos();
            this.BuscarTodosOsVeiculos();
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            DGVeiculos.Rows[ctrNavigator1.Indice].Selected = true; 
        }

        private void DGVeiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGVeiculos.Columns[e.ColumnIndex].Name == "TipoVeiculo")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.TipoVeiculo tipo = (Dominio.TipoVeiculo)e.Value;
                        e.Value = tipo.Descricao;
                    }
                }
            }
            else if (this.DGVeiculos.Columns[e.ColumnIndex].Name == "ModeloVeiculo")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.ModeloVeiculo mod = (Dominio.ModeloVeiculo)e.Value;
                        e.Value = mod.Descricao;
                    }
                }
            }
        }

        private void ctrNavigator1_EventoNovo()
        {
            _Veiculo = null;
            _Veiculo = new Dominio.Veiculo();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGVeiculos.SelectedRows.Count > 0)
                _Veiculo = (Dominio.Veiculo)DGVeiculos.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_Veiculo.IdVeiculo == 0)
                    new Repositorio.RepositorioVeiculo().SalvarObjeto(_Veiculo);
                else
                    new Repositorio.RepositorioVeiculo().AtualizarObjeto(_Veiculo);
                this.BuscarTodosOsVeiculos();
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
                    new Repositorio.RepositorioVeiculo().DeletarObjeto(_Veiculo);
                    this.BuscarTodosOsVeiculos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }                
            }
            this.CamposInterface(Status.Consultando);
        }

        private void DGVeiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGVeiculos.Rows.Count > 0)
            {
                if (DGVeiculos.SelectedRows.Count > 0)
                {
                    _Veiculo = (Dominio.Veiculo)DGVeiculos.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null && _ListaVeiculos.Count > 0)
                        ctrNavigator1.Indice = DGVeiculos.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
        }

        private void btnNovoTipoVeiculo_Click(object sender, EventArgs e)
        {
            FrmTipoServico frm = new FrmTipoServico();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodosOsTiposVeiculo();
        }

        private void btnNovoModelo_Click(object sender, EventArgs e)
        {
            FrmModeloVeiculo frm = new FrmModeloVeiculo();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodosOsModelosVeiculos();
        }

        private void BtnLocalizarFotoInstrutor_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
                _Veiculo.PathFoto = openFile.FileName;
        }
    }
}
