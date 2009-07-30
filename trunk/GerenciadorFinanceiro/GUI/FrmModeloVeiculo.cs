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
    public partial class FrmModeloVeiculo : Form
    {
        public FrmModeloVeiculo()
        {
            InitializeComponent();
        }

        private List<Dominio.ModeloVeiculo> _ListaModeloVeiculos = new List<GerenciadorFinanceiro.Dominio.ModeloVeiculo>();
        private Dominio.ModeloVeiculo _ModeloVeiculo = new Dominio.ModeloVeiculo();
        private List<Dominio.FabricanteVeiculo> _ListaFabricanteVeiculo = new List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo>();

        #region " Campos Interface "

        private void ValidaDados()
        {
            if (TxtDescricao.Text.Trim() == String.Empty)
                throw new Exception("O campo descrição é obrigatório.");
            if (CmbFabricanteVeiculo.SelectedValue == null)
                throw new Exception("O campo fabricante é obrigatório.");
            _ModeloVeiculo.Descricao = TxtDescricao.Text;
            _ModeloVeiculo.Fabricante = (Dominio.FabricanteVeiculo)CmbFabricanteVeiculo.SelectedItem;
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
            if (_ModeloVeiculo == null)
                _ModeloVeiculo = new Dominio.ModeloVeiculo();
            TxtDescricao.Text = _ModeloVeiculo.Descricao;
            if (_ModeloVeiculo.Fabricante != null)
                CmbFabricanteVeiculo.SelectedValue = _ModeloVeiculo.Fabricante.IdFabricanteVeiculo;
            else
                CmbFabricanteVeiculo.SelectedIndex = 0;
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

        private void ListarTodosOsModelosDeVeiculos()
        {
            _ListaModeloVeiculos = new Repositorio.RepositorioModeloVeiculo().BuscarTodos();
            this.DGModelos.DataSource = _ListaModeloVeiculos;
            ctrNavigator1.DataSource = _ListaModeloVeiculos;
        }

        private void ListarTodosOsFabricantesVeiculos()
        {
            _ListaFabricanteVeiculo = new Repositorio.RepositorioFabricanteVeiculo().BuscarTodos();
            this.CmbFabricanteVeiculo.DisplayMember = "Descricao";
            this.CmbFabricanteVeiculo.ValueMember = "IdFabricanteVeiculo";
            this.CmbFabricanteVeiculo.DataSource = _ListaFabricanteVeiculo;
        }

        private void FrmModeloVeiculo_Load(object sender, EventArgs e)
        {
            this.ListarTodosOsFabricantesVeiculos();
            this.ListarTodosOsModelosDeVeiculos();
            this.CamposInterface(Status.Consultando);
        }
           
        private void ctrNavigator1_EventoNovo()
        {
            _ModeloVeiculo = null;
            _ModeloVeiculo = new Dominio.ModeloVeiculo();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            if (DGModelos.SelectedRows.Count > 0)
                _ModeloVeiculo = (Dominio.ModeloVeiculo)DGModelos.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void DGModelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGModelos.Columns[e.ColumnIndex].Name == "Fabricante")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.FabricanteVeiculo FabVeiculo = (Dominio.FabricanteVeiculo)e.Value;
                        e.Value = FabVeiculo.Descricao;
                    }
                }
            }
        }

        private void DGModelos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGModelos.Rows.Count > 0)
            {
                if (DGModelos.SelectedRows.Count > 0)
                {
                    _ModeloVeiculo = (Dominio.ModeloVeiculo)DGModelos.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null && ctrNavigator1.DataSource.Count > 0)
                        ctrNavigator1.Indice = DGModelos.SelectedRows[0].Index;
                }
            }
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaDados();
                if (_ModeloVeiculo.IdModeloVeiculo == 0)
                    new Repositorio.RepositorioModeloVeiculo().SalvarObjeto(_ModeloVeiculo);
                else
                    new Repositorio.RepositorioModeloVeiculo().AtualizarObjeto(_ModeloVeiculo);

                this.ListarTodosOsModelosDeVeiculos();
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
                    new Repositorio.RepositorioModeloVeiculo().DeletarObjeto(_ModeloVeiculo);
                    this.ListarTodosOsModelosDeVeiculos();
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
            DGModelos.Rows[ctrNavigator1.Indice].Selected = true; 
        }

        private void btnNovoFabricante_Click(object sender, EventArgs e)
        {
            GUI.FrmFabricanteVeiculo frm = new FrmFabricanteVeiculo();
            frm.ShowDialog();
            frm.Dispose();
            this.ListarTodosOsFabricantesVeiculos();
        }

    }
}
