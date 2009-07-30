using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorFinanceiro.Configuracao
{
    public partial class FrmUsuario : Form
    {

        private Dominio.Usuario _Usuario;
        private List<Dominio.Usuario> _ListaUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        #region " Eventos da Interface "
        
        private void ValidaCampos()
        {
            if (TxtNome.Text.Trim()  == String.Empty)
                throw new Exception("O campo nome é obrigatório.");
            if (txtEmail.Text.Trim() == String.Empty)
                throw new Exception("O campo email é obrigatório.");
            if (txtUsername.Text.Trim() == String.Empty)
                throw new Exception("O campo usuário é obrigatório.");
            if (txtSenha.Text.Trim() == String.Empty)
                throw new Exception("O campo senha é obrigatório.");
            _Usuario.Nome = TxtNome.Text;
            _Usuario.Telefone = txtTelefone.Text;
            _Usuario.Celular = TxtTelefoneCelular.Text;
            _Usuario.Email = txtEmail.Text;
            _Usuario.UserName = txtUsername.Text;
            _Usuario.Senha = txtSenha.Text;            
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
            if (_Usuario == null)
                _Usuario = new Dominio.Usuario();
            TxtNome.Text = _Usuario.Nome ;
            txtEmail.Text = _Usuario.Email;
            txtTelefone.Text = _Usuario.Telefone;
            TxtTelefoneCelular.Text = _Usuario.Celular;
            txtUsername.Text = _Usuario.UserName;
            txtSenha.Text = _Usuario.Senha;

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
        
        private void BuscarTodosOsUsuarios()
        {
            _ListaUsuario = new Repositorio.RepositorioUsuario().BuscarTodos();
            DGUsuarios.DataSource = _ListaUsuario;
            ctrNavigator1.DataSource = _ListaUsuario;
        }

        #region "Eventos Controle"

        private void ctrNavigator1_CancelarAcao()
        {
            _Usuario = (Dominio.Usuario)DGUsuarios.SelectedRows[0].DataBoundItem;
            this.CamposInterface(Status.Consultando);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(Status.Editando);
        }

        private void ctrNavigator1_EventoNovo()
        {
            _Usuario = null;
            _Usuario = new Dominio.Usuario();
            CamposInterface(Status.Inserindo);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                try
                {
                    new Repositorio.RepositorioUsuario().DeletarObjeto(_Usuario);
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
            for (int i = 0; i < DGUsuarios.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGUsuarios.Rows[i].Selected = true;
                else
                    DGUsuarios.Rows[i].Selected = false;
            }
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            try
            {
                this.ValidaCampos();
                if (_Usuario.IdUsuario == 0)
                    new Repositorio.RepositorioUsuario().SalvarObjeto(_Usuario);
                else
                    new Repositorio.RepositorioUsuario().AtualizarObjeto(_Usuario);
                this.BuscarTodosOsUsuarios();
                this.CamposInterface(Status.Consultando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsUsuarios();
        }
        #endregion

        private void DGUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGUsuarios.Rows.Count > 0)
            {
                if (DGUsuarios.SelectedRows.Count > 0)
                {
                    _Usuario = (Dominio.Usuario)DGUsuarios.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGUsuarios.SelectedRows[0].Index;
                }
            }
            else
            {
                _Usuario = null;
                _Usuario = new Dominio.Usuario();
            }
            this.CamposInterface(Status.Consultando);
        }

    }
}
