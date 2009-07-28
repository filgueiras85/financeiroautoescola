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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Dominio.Usuario _Usuario; 

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Repositorio.RepositorioUsuario repUser = new Repositorio.RepositorioUsuario();
                Dominio.UsuarioLogado.User = repUser.ObterUsuarioPorUsernameAndPassword(this.TxtUsername.Text, this.TxtPassword.Text);
                if (Dominio.UsuarioLogado.User != null)
                {
                    FrmPrincipal Frm = new FrmPrincipal();
                    Frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválido.", "Atenção");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkEsqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GrpLogin.Visible = false;
            GrpEsqueciMinhaSenha.Visible = true;
        }

        private void BtnCancelarEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            GrpEsqueciMinhaSenha.Visible = false;
            GrpLogin.Visible = true;
        }

        private void BtnEnviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                _Usuario = new Repositorio.RepositorioUsuario().ObterUsuarioPorEmail(TxtEmail.Text);

                if (_Usuario != null)
                {
                    new Servicos.Email().EnviarEmail("alcenir@zyoncore.com.br", "Alcenir Moretto", _Usuario.Email,
                        "Esqueci Minha Senha", "Username = " + _Usuario.UserName + ", Senha = " + _Usuario.Senha, "smtp.zyoncore.com.br", "@MCH9482@", null);
                    MessageBox.Show("Email enviado com sucesso !", "Esqueci minha Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Usuário não cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
