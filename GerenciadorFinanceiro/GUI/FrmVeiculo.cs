﻿using System;
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

        private void CamposInterface(Dominio.Veiculo veiculo, Dominio.Status status)
        {
            TxtPlaca.Text = veiculo.Placa;
            TxtRenavam.Text = veiculo.Renavam;
            TxtChassi.Text = veiculo.Chassi;
            CmbCombustivel.SelectedText = veiculo.Combustivel;
            //TxtAno.Text = veiculo.Ano;
            TxtCor.Text = veiculo.Cor;
            //TxtAnoModelo.Text = veiculo.Modelo;
            TxtObservacao.Text = veiculo.Observacao;
            if (veiculo.TipoVeiculo.IdTipoVeiculo > 0)
            {
                CmbTipo.SelectedValue = veiculo.TipoVeiculo.IdTipoVeiculo;
                CmbModelo.SelectedValue = veiculo.ModeloVeiculo.IdModeloVeiculo;
            }
            else
            {
                CmbTipo.SelectedIndex = 0;
                CmbModelo.SelectedIndex = 0;
            }

            if (status == Dominio.Status.Inserindo)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Dominio.Status.Editando)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Dominio.Status.Excluindo)
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
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            for (int i = 0; i < DGVeiculos.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGVeiculos.Rows[i].Selected = true;
                else
                    DGVeiculos.Rows[i].Selected = false;
            }
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
            this.CamposInterface(_Veiculo, GerenciadorFinanceiro.Dominio.Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_Veiculo, GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(_Veiculo, GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            this._Veiculo.Placa = TxtPlaca.Text;
            this._Veiculo.Renavam = TxtRenavam.Text;
            this._Veiculo.Chassi = TxtChassi.Text;
            this._Veiculo.TipoVeiculo = (Dominio.TipoVeiculo)CmbTipo.SelectedItem;
            this._Veiculo.Combustivel = CmbCombustivel.Text;
            this._Veiculo.Cor = TxtCor.Text;
            //this._Veiculo.Ano = (int)TxtAno.Text;
            //this._Veiculo.Modelo = TxtAnoModelo.Text;
            this._Veiculo.ModeloVeiculo = (Dominio.ModeloVeiculo)CmbModelo.SelectedItem;
            this._Veiculo.Observacao = TxtObservacao.Text;
            try
            {
                if (_Veiculo.IdVeiculo == 0)
                    new Repositorio.RepositorioVeiculo().SalvarObjeto(_Veiculo);
                else
                    new Repositorio.RepositorioVeiculo().AtualizarObjeto(_Veiculo);
            }
            catch (Exception ex)
            {

            }
            this.BuscarTodosOsVeiculos();
            this.CamposInterface(_Veiculo, Dominio.Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_Veiculo, GerenciadorFinanceiro.Dominio.Status.Excluindo);
            //TODO: Confirmação de exclusao
            try
            {
                new Repositorio.RepositorioVeiculo().DeletarObjeto(_Veiculo);
            }
            catch (Exception ex)
            {

            }
        }

        private void DGVeiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGVeiculos.Rows.Count > 0)
            {
                if (DGVeiculos.SelectedRows.Count > 0)
                {
                    _Veiculo = (Dominio.Veiculo)DGVeiculos.SelectedRows[0].DataBoundItem;
                    ctrNavigator1.Indice = DGVeiculos.SelectedRows[0].Index;
                }
            }
            else
            {
                _Veiculo = null;
                _Veiculo = new Dominio.Veiculo();
            }
            this.CamposInterface(_Veiculo, Dominio.Status.Consultando);
        }

    }
}
