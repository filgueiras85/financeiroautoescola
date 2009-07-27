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

        private void CamposInterface(Status status)
        {
            TxtDescricao.Text = _Servico.Descricao;
            txtValor.Text = _Servico.Valor.ToString();            

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

        private void ValidaCampos()
        {
            if (TxtDescricao.Text.Trim() == string.Empty)
                throw new Exception("O campo descrição está em branco.");
            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
                throw new Exception("O campo valor tem um número inválido.");
            _Servico.Descricao = TxtDescricao.Text;                        
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
            this.BuscarTodosOsServicos();
            this.CamposInterface(Status.Consultando);
        }



        #endregion 

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.CamposInterface(Status.Excluindo);
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
