using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorFinanceiro.Controls
{
    public partial class CtrNavigator : UserControl
    {
        private object _Lista;
        private int _Indice = -1;
        private object _ObjetoAtual;
  

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
            this.BtnPrimeiro.Enabled = false;
            this.BtnAnterior.Enabled = false;
            this.BtnProximo.Enabled = false;
            this.BtnUltimo.Enabled = false;
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

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (_Lista != null)
            {
                if (_Lista.GetType().GetInterface("IList", false) != null)
                {
                    //Isso aqui provavelmente não vai funcionar, pois IList<Object> não é a mesma coisa que IList<Button>, por mais
                    //que Button derive de Object, temos que ver outra possibilidade para iterar sobre a lista dinamicamente, sem precisar
                    //saber o tipo de objeto da lista.
                    IList<Object> lista = (IList<object>)_Lista;
                    _ObjetoAtual = lista[_Indice];
                }
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
