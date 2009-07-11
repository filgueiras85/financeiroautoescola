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
        private object _Lista;
        private int _Indice = -1;
        private int _QuantidadeItensLista = 0;
        private object _ObjetoAtual;

        public CtrNavigator(object lista)
        {
            this._Lista = lista;
            InitializeComponent();
            this.VerificaQuantidadeItensLista();
            this.EnabledNavegator();
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        public delegate void Novo();

        [System.ComponentModel.Bindable(true)]
        public event Novo EventoNovo;

        public CtrNavigator()
        {
            InitializeComponent();
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
            //this.BtnPrimeiro.Enabled = false;
            //this.BtnAnterior.Enabled = false;
            //this.BtnProximo.Enabled = false;
            //this.BtnUltimo.Enabled = false;
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
            this.VerificaQuantidadeItensLista();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.EnabledButons(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void VerificaQuantidadeItensLista()
        {
            _QuantidadeItensLista = 0;
            foreach (FieldInfo f in GetType().GetFields())
            {
                _QuantidadeItensLista += 1;
            }
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
                if (_QuantidadeItensLista > (_Indice + 1))
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
            if (_Lista != null)
            {
                if (_Lista.GetType().GetInterface("IList", false) != null)
                {
                    //Isso aqui provavelmente não vai funcionar, pois IList<Object> não é a mesma coisa que IList<Button>, por mais
                    //que Button derive de Object, temos que ver outra possibilidade para iterar sobre a lista dinamicamente, sem precisar
                    //saber o tipo de objeto da lista.
                    //IList<Object> lista = (IList<object>)_Lista;
                    //_ObjetoAtual = lista[_Indice];

                    _Indice += 1;
                    this.EnabledNavegator();
                }
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            _Indice -= 1;
            this.EnabledNavegator();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            _Indice = 0;
            this.EnabledNavegator();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            _Indice = _QuantidadeItensLista - 1;
            this.EnabledNavegator();
        }

    }
}
