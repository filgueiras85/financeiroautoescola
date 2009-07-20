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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

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
    }
}
