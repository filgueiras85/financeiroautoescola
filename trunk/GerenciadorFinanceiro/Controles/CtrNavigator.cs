using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GerenciadorFinanceiro.Controles
{
    public partial class CtrNavigator : UserControl
    {
        private System.Collections.IList _Lista;
        private int _Indice = -1;
        private object _ObjetoAtual;

        public delegate void MudaRegistro(object objetoAtual);
        [System.ComponentModel.Bindable(true)]
        public event MudaRegistro  MudaRegistroSelecionado;

        public delegate void Novo();
        [System.ComponentModel.Bindable(true)]
        public event Novo EventoNovo;

        public delegate void Cancelar();
        [System.ComponentModel.Bindable(true)]
        public event Cancelar CancelarAcao;

        public delegate void Editar(object objEditar);
        [System.ComponentModel.Bindable(true)]
        public event Editar EditarRegistro;

        public delegate void Salvar(object objSalvar);
        [System.ComponentModel.Bindable(true)]
        public event Salvar SalvarRegistro;

        public delegate void Excluir(object objExcluir);
        [System.ComponentModel.Bindable(true)]
        public event Excluir ExcluirRegistro;


        public System.Collections.IList DataSource
        {
            get { return _Lista; }
            set { _Lista = value; IniciaControles(); }
        }

        public CtrNavigator(System.Collections.IList lista)
        {
            this._Lista = lista;
            InitializeComponent();
            IniciaControles();
        }

        private void IniciaControles()
        {
            if (_Lista != null)
            {
                if (_Lista.Count > 0)
                    _Indice = 0;
            }
            this.EnabledNavegator();
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        public CtrNavigator()
        {
            InitializeComponent();
            IniciaControles();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Inserindo);
            if (EventoNovo != null)
                EventoNovo();
        }


        private void EnabledButons(Dominio.Status status)
        {
            if (status == GerenciadorFinanceiro.Dominio.Status.Consultando)
            {
                this.BtnNovo.Enabled = true;
                this.BtnCancelar.Enabled = false;
                this.BtnSalvar.Enabled = false;
                this.BtnEditar.Enabled = true;
                this.BtnExcluir.Enabled = true;
            }
            else if (status == GerenciadorFinanceiro.Dominio.Status.Editando)
            {
                this.BtnNovo.Enabled = false;
                this.BtnEditar.Enabled = false;
                this.BtnCancelar.Enabled = true;
                this.BtnSalvar.Enabled = true;
                this.BtnExcluir.Enabled = false;
            }
            else if (status == GerenciadorFinanceiro.Dominio.Status.Excluindo)
            {
                this.BtnNovo.Enabled = false;
                this.BtnEditar.Enabled = false;
                this.BtnCancelar.Enabled = true;
                this.BtnSalvar.Enabled = false;
                this.BtnExcluir.Enabled = true;
            }
            else if (status == GerenciadorFinanceiro.Dominio.Status.Inserindo)
            {
                this.BtnNovo.Enabled = false;
                this.BtnEditar.Enabled = false;
                this.BtnCancelar.Enabled = true;
                this.BtnSalvar.Enabled = true;
                this.BtnExcluir.Enabled = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void EnabledNavegator()
        {
            if (_Lista != null)
            {
                if (_Indice <= 0)
                {
                    this.BtnPrimeiro.Enabled = false;
                    this.BtnAnterior.Enabled = false;
                }
                else
                {
                    this.BtnPrimeiro.Enabled = true;
                    this.BtnAnterior.Enabled = true;
                }
                if (_Lista.Count > (_Indice + 1))
                {
                    this.BtnProximo.Enabled = true;
                    this.BtnUltimo.Enabled = true;
                }
                else
                {
                    this.BtnProximo.Enabled = false;
                    this.BtnUltimo.Enabled = false;
                }
            }
            else
            {
                this.BtnPrimeiro.Enabled = false;
                this.BtnAnterior.Enabled = false;
                this.BtnProximo.Enabled = false;
                this.BtnUltimo.Enabled = false;
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            _Indice += 1;
            this.EnabledNavegator();
            if (_Lista != null)
            {
                if (_Lista.Count > 0)
                {
                    _ObjetoAtual = _Lista[_Indice];
                    if (MudaRegistroSelecionado != null)
                        MudaRegistroSelecionado(_ObjetoAtual);
                }
            }        
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            _Indice -= 1;
            this.EnabledNavegator();
            if (_Lista != null)
            {
                if (_Lista.Count > 0)
                {
                    _ObjetoAtual = _Lista[_Indice];
                    if (MudaRegistroSelecionado != null)
                        MudaRegistroSelecionado(_ObjetoAtual);
                }
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            _Indice = 0;
            this.EnabledNavegator();
            if (_Lista != null)
            {
                if (_Lista.Count > 0)
                {
                    _ObjetoAtual = _Lista[_Indice];
                    if (MudaRegistroSelecionado != null)
                        MudaRegistroSelecionado(_ObjetoAtual);
                }
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            _Indice = _Lista.Count - 1;
            this.EnabledNavegator();
            if (_Lista != null)
            {
                if (_Lista.Count > 0)
                {
                    _ObjetoAtual = _Lista[_Indice];
                    if (MudaRegistroSelecionado != null)
                        MudaRegistroSelecionado(_ObjetoAtual);
                }
            }
        }
    }
}
