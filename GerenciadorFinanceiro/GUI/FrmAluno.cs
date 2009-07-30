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
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private Dominio.Aluno _Aluno = new Dominio.Aluno();
        private List<Dominio.Cidade> _ListaCidade;
        private List<Dominio.Estado> _ListaEstados;

        #region "Controla Alterações"

        private void CamposInterface(Status status)
        {
            TxtNome.Text = _Aluno.NomeAluno;
            TxtEmail.Text = _Aluno.Email;
            txtRua.Text = _Aluno.Endereco.Rua;
            txtNumero.Text = _Aluno.Endereco.Numero.ToString();
            txtBairro.Text = _Aluno.Endereco.Bairro;
            txtComplemento.Text = _Aluno.Endereco.Complemento;
            CmbEstado.SelectedValue = _Aluno.Endereco.Cidade.Estado.IdEstado;
            CmbCidade.SelectedValue = _Aluno.Endereco.Cidade.IdCidade;
            TxtTelefoneResidencial.Text = _Aluno.TelefoneResidencial;
            txtCelular.Text = _Aluno.TelefoneCelular;
            TxtCPF.Text = _Aluno.CPF_CNPJ;
            txtRg.Text = _Aluno.RG_InscEstadual;
            txtDataNasc.Value = _Aluno.DataNascimento;
            txtSSP.Text = _Aluno.SSP;
            txtNomeMae.Text = _Aluno.NomeMae;
            txtNomePai.Text = _Aluno.NomePai;
            txtObservacao.Text = _Aluno.Observacao;           

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

        
        private void BuscarTodosOsEstados()
        {
            _ListaEstados = new Repositorio.RepositorioEstado().BuscarTodos();
            CmbEstado.DisplayMember = "SiglaEstado";
            CmbEstado.ValueMember = "IdEstado";
            CmbEstado.DataSource = _ListaEstados;
        }

        private void BuscarTodasAsCidadesPorEstado(Dominio.Estado est)
        {
            _ListaCidade = new Repositorio.RepositorioCidade().BuscarCidadesPorEstado(est);
            CmbCidade.DisplayMember = "NomeCidade";
            CmbCidade.ValueMember = "IdCidade";
            CmbCidade.DataSource = _ListaCidade;
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


        private void ValidaCampos()
        {
            if (TxtNome.Text.Trim() == String.Empty)
                throw new Exception("Campo nome em branco.");
            _Aluno.NomeAluno = TxtNome.Text;
            if (new Servicos.Email().ValidaEmail(TxtEmail.Text.Trim()) == false)
                throw new Exception("Email inválido.");
            _Aluno.Email = TxtEmail.Text;
            if(TxtCPF.Text.Trim() == String.Empty  || TxtCPF.Text.Trim().Length != 14 )
                throw new Exception("Cpf inválido.");
            _Aluno.CPF_CNPJ = TxtCPF.Text;
            if (txtRg.Text.Trim() == String.Empty)
                throw new Exception("Campo RG em branco.");
            _Aluno.RG_InscEstadual = txtRg.Text;
            if (CmbCidade.SelectedItem == null)
                throw new Exception("Escolha uma cidade.");
            int numero;
            if  (!int.TryParse(txtNumero.Text,out numero))
                throw new Exception("Campo número inválido.");
            Dominio.Endereco end = new GerenciadorFinanceiro.Dominio.Endereco();
            end.Cidade = (Dominio.Cidade)CmbCidade.SelectedItem;
            end.Bairro = txtBairro.Text;
            end.Complemento = txtComplemento.Text;
            end.Numero = numero;
            end.Rua = txtRua.Text;
            _Aluno.Endereco = end;
            _Aluno.DataNascimento = txtDataNasc.Value;
            _Aluno.NomeMae = txtNomeMae.Text;
            _Aluno.NomePai = txtNomePai.Text;
            _Aluno.Observacao = txtObservacao.Text;
            _Aluno.SSP = txtSSP.Text;
            _Aluno.TelefoneCelular = txtCelular.Text;
            _Aluno.TelefoneResidencial = TxtTelefoneResidencial.Text;
        }

        #endregion 


        #region "Eventos Interface"

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            BuscarTodosOsEstados();
            this.CamposInterface(Status.Consultando);
        }

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
            this._Aluno = null;
            this._Aluno = new Dominio.Aluno();
            this.CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.CamposInterface(Status.Excluindo);
                try
                {
                    new Repositorio.RepositorioAluno().DeletarObjeto(_Aluno);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
            }
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                ValidaCampos();
                if(_Aluno.IdAluno == 0 )
                    new Repositorio.RepositorioAluno().SalvarObjeto(_Aluno);
                else
                    new Repositorio.RepositorioAluno().SalvarObjeto(_Aluno);
                this.CamposInterface(Status.Consultando);

            }
            catch (Exception ex)
            {
                this.CamposInterface(Status.Inserindo);
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbEstado.SelectedItem !=null)
                this.BuscarTodasAsCidadesPorEstado((Dominio.Estado)CmbEstado.SelectedItem);
        }

#endregion 

        private void btnNovaCidade_Click(object sender, EventArgs e)
        {
            FrmCidade frm = new FrmCidade();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodasAsCidadesPorEstado((Dominio.Estado)CmbEstado.SelectedItem);
        }
              


    }
}
