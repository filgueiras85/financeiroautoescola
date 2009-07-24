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
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }
        
        private List<Dominio.Servico> _ListaServicos;        
        private Dominio.Servico _Servico = new Dominio.Servico();

        #region "Controlando alterações"

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

        private void CamposInterface(Dominio.Status status)
        {
            TxtDescricao.Text = _Servico.Descricao;
            txtValor.Text = _Servico.Valor.ToString();
            txtObservacao.Text = _Servico.Observacao;

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

        private void ValidaCampos()
        {
            if (TxtDescricao.Text.Trim() == string.Empty)
                throw new Exception("O campo descrição está em branco.");
            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
                throw new Exception("O campo valor tem um número inválido.");
            _Servico.Descricao = TxtDescricao.Text;            
            _Servico.Observacao = txtObservacao.Text;
            _Servico.Valor = valor;
        }

        private void BuscarTodosOsServicos()
        {
            _ListaServicos = new Repositorio.RepositorioServico().BuscarTodos();
            DGServicos.DataSource = _ListaServicos;
            this.ctrNavigator1.DataSource = _ListaServicos;
        }
        #endregion

        #region "Eventos formulario"

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            throw new Exception("Excecao de teste.");
            this.BuscarTodosOsServicos();
            this.CamposInterface(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }



        #endregion 

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(GerenciadorFinanceiro.Dominio.Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(GerenciadorFinanceiro.Dominio.Status.Editando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            this.CamposInterface(GerenciadorFinanceiro.Dominio.Status.Inserindo);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.CamposInterface(GerenciadorFinanceiro.Dominio.Status.Excluindo);
                try
                {
                    new Repositorio.RepositorioServico().DeletarObjeto((Dominio.Servico)objExcluir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
            }
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            _Servico = (Dominio.Servico)objetoAtual;
            DGServicos.CurrentCell = DGServicos.Rows[ctrNavigator1.Indice].Cells[0];
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaCampos();
                if (_Servico.IdServico == 0)
                    new Repositorio.RepositorioServico().SalvarObjeto(_Servico);
                else
                    new Repositorio.RepositorioServico().AtualizarObjeto(_Servico);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar salvar o Servico solicitado.", ex);
            }
        }
    }
}
