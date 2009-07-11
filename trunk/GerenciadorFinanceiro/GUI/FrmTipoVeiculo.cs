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

        //private void EnabledButons(Dominio.Status status, Dominio.TipoVeiculo tipoVeiculo)
        //{
        //    this.TxtDescricao.Text = tipoVeiculo.Descricao;
        //    if (status == GerenciadorFinanceiro.Dominio.Status.Consultando){
        //        this.TxtDescricao.Enabled = false;
        //        this.BtnNovo.Enabled = true;
        //        this.BtnCancelar.Enabled = false;
        //        this.BtnSalvar.Enabled = false;
        //        if (this._ListTipoVeiculo.Count > 0)
        //        {
        //            this.BtnEditar.Enabled = true;
        //            this.BtnExcluir.Enabled = true;
        //        }
        //        else
        //        {
        //            this.BtnEditar.Enabled = false;
        //            this.BtnExcluir.Enabled = false;
        //        }
        //    }else if(status == GerenciadorFinanceiro.Dominio.Status.Editando){
        //        this.TxtDescricao.Enabled = true;
        //        this.BtnNovo.Enabled = false;
        //        this.BtnEditar.Enabled = false;
        //        this.BtnCancelar.Enabled = true;
        //        this.BtnSalvar.Enabled = true;
        //        this.BtnExcluir.Enabled = false;
        //    }else if (status == GerenciadorFinanceiro.Dominio.Status.Excluindo){
        //        this.TxtDescricao.Enabled = false;
        //        this.BtnNovo.Enabled = false;
        //        this.BtnEditar.Enabled = false;
        //        this.BtnCancelar.Enabled = true;
        //        this.BtnSalvar.Enabled = false;
        //        this.BtnExcluir.Enabled = true;
        //    }else if (status == GerenciadorFinanceiro.Dominio.Status.Inserindo){
        //        this.TxtDescricao.Enabled = true;
        //        this.BtnNovo.Enabled = false;
        //        this.BtnEditar.Enabled = false;
        //        this.BtnCancelar.Enabled = true;
        //        this.BtnSalvar.Enabled = true;
        //        this.BtnExcluir.Enabled = false;
        //    }
        //    if (this._ListTipoVeiculo.Count > 0)
        //    {
        //        if (this._IndiceTipoSelecionado > 0)
        //        {
        //            this.BtnAnterior.Enabled = true;
        //            this.BtnPrimeiro.Enabled = true;
        //        }
        //        else 
        //        {
        //            this.BtnAnterior.Enabled = false;
        //            this.BtnPrimeiro.Enabled = false;
        //        }
        //        if (this._IndiceTipoSelecionado < this._ListTipoVeiculo.Count)
        //        {
        //            this.BtnProximo.Enabled = true;
        //            this.BtnUltimo.Enabled = true;
        //        }
        //        else
        //        {
        //            this.BtnProximo.Enabled = false;
        //            this.BtnUltimo.Enabled = false;
        //        }
        //    }
        //    else
        //    {
        //        this.BtnPrimeiro.Enabled = false;
        //        this.BtnAnterior.Enabled = false;
        //        this.BtnProximo.Enabled = false;
        //        this.BtnUltimo.Enabled = false;
        //    }
        //}

        //private void BtnPrimeiro_Click(object sender, EventArgs e)
        //{
        //    this._IndiceTipoSelecionado = 0;
        //    this.DGTipoVeiculo.Rows[_IndiceTipoSelecionado].Selected = true;
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //}

        //private void BtnAnterior_Click(object sender, EventArgs e)
        //{
        //    this._IndiceTipoSelecionado -= 1;
        //    this.DGTipoVeiculo.Rows[_IndiceTipoSelecionado].Selected = true;
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //}

        //private void BtnProximo_Click(object sender, EventArgs e)
        //{
        //    this._IndiceTipoSelecionado += 1;
        //    this.DGTipoVeiculo.Rows[_IndiceTipoSelecionado].Selected = true;
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //}

        //private void BtnUltimo_Click(object sender, EventArgs e)
        //{
        //    this._IndiceTipoSelecionado = _ListTipoVeiculo.Count - 1;
        //    this.DGTipoVeiculo.Rows[_IndiceTipoSelecionado].Selected = true;
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //}

        private void DGTipoVeiculo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGTipoVeiculo.Rows.Count > 0)
            {
                if (this.DGTipoVeiculo.SelectedRows.Count > 0)
                {
                   this._TipoVeiculo = (Dominio.TipoVeiculo)this.DGTipoVeiculo.SelectedRows[0].DataBoundItem;
                }
                else
                {
                   this._TipoVeiculo  = new Dominio.TipoVeiculo();
                }
             }
             else
             {
                this._TipoVeiculo  = new Dominio.TipoVeiculo();
             }
        }

        //private void BtnNovo_Click(object sender, EventArgs e)
        //{
        //    this._TipoVeiculo = new Dominio.TipoVeiculo();
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Inserindo, _TipoVeiculo);
        //}

        //private void BtnEditar_Click(object sender, EventArgs e)
        //{
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Editando, _TipoVeiculo);
        //}

        //private void BtnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //}

        //private void BtnSalvar_Click(object sender, EventArgs e)
        //{
        //    this._TipoVeiculo.IdTipoVeiculo = this._ListTipoVeiculo.Count + 1;
        //    this._TipoVeiculo.Descricao = this.TxtDescricao.Text;
        //    this._ListTipoVeiculo.Add(this._TipoVeiculo);
        //    this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando, _TipoVeiculo);
        //    this.DGTipoVeiculo.DataSource = null;
        //    this.DGTipoVeiculo.DataSource = this._ListTipoVeiculo;
        //    this.DGTipoVeiculo.Refresh();
        //}

        //private void BtnExcluir_Click(object sender, EventArgs e)
        //{
        //    this._ListTipoVeiculo.Remove(this._TipoVeiculo);
        //}

        private void BuscarTodosTiposVeiculos()
        {
            Repositorio.RepositorioTipoVeiculo repTipoVeiculo = new Repositorio.RepositorioTipoVeiculo();
            _ListTipoVeiculo = repTipoVeiculo.BuscarTodos();
            DGTipoVeiculo.DataSource = _ListTipoVeiculo;
        }

        private void FrmTipoVeiculo_Load(object sender, EventArgs e)
        {
            this.BuscarTodosTiposVeiculos();            
            Controles.CtrNavigator ctr = new Controles.CtrNavigator(_ListTipoVeiculo);
            this.Controls.Add(ctr);
            this.Refresh();
        }          
        
    }
}
