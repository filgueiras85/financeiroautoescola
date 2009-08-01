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
    public partial class FrmConfiguracao : Form
    {

        private bool _PrimeiraVez;

        public FrmConfiguracao(bool inicial)
        {
            InitializeComponent();
            _PrimeiraVez = inicial;
            if (_PrimeiraVez == false)
                this.GrpUsuario.Visible = false;
        }

        private void ValidaCampos()
        {
            if (txtLocalBanco.Text.Trim() == string.Empty)
                throw new Exception("Local do banco de dados inválido.");
            if (chkRealizarBackup.Checked)
                if (txtBackup.Text.Trim() == string.Empty)
                    throw new Exception("Local do backup não pode estar vazio quando o backup está habilitado.");
            if (TxtEmail.Text.Trim() != String.Empty)
                if (new Servicos.Email().ValidaEmail(TxtEmail.Text) == false)
                    throw new Exception("Email inválido. ");
            Properties.Settings.Default.LocalDB = txtLocalBanco.Text;
            Properties.Settings.Default.LocalBackupDB = txtBackup.Text;
            Properties.Settings.Default.RealizarBackup = chkRealizarBackup.Checked;
            Properties.Settings.Default.ServidorSMTP = TxtServidorSMTP.Text;
            Properties.Settings.Default.Email = TxtEmail.Text;
            Properties.Settings.Default.Remetente = TxtRemetente.Text;
            Properties.Settings.Default.RequerAutenticacao = ChkRequerAutenticacao.Checked;
            Properties.Settings.Default.UsuarioAutenticar = TxtUsuarioAutenticar.Text;
            Properties.Settings.Default.SenhaAutenticar = TxtSenhaAutenticacao.Text;
            GerenciadorFinanceiro.Properties.Settings.Default.Save();
        }

        private void PreencherFormularioComDadosCadastrados()
        {
            txtLocalBanco.Text = GerenciadorFinanceiro.Properties.Settings.Default.LocalDB;
            txtBackup.Text = GerenciadorFinanceiro.Properties.Settings.Default.LocalBackupDB;
            chkRealizarBackup.Checked = GerenciadorFinanceiro.Properties.Settings.Default.RealizarBackup;
            TxtServidorSMTP.Text = Properties.Settings.Default.ServidorSMTP;
            TxtEmail.Text = Properties.Settings.Default.Email;
            TxtRemetente.Text = Properties.Settings.Default.Remetente;
            ChkRequerAutenticacao.Checked = Properties.Settings.Default.RequerAutenticacao;
            TxtUsuarioAutenticar.Text = Properties.Settings.Default.UsuarioAutenticar;
            TxtSenhaAutenticacao.Text = Properties.Settings.Default.SenhaAutenticar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            PreencherFormularioComDadosCadastrados();
        }

        private void BtnLocalBackup_Click(object sender, EventArgs e)
        {
            folderBrowser.SelectedPath = txtBackup.Text;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtBackup.Text = folderBrowser.SelectedPath;
        }

        private void BtnLocalBancoDados_Click(object sender, EventArgs e)
        {
            folderBrowser.SelectedPath = txtLocalBanco.Text;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtLocalBanco.Text = folderBrowser.SelectedPath;
        }

        private void BtnRealizarBackupAgora_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            new Servicos.Backup().RealizarBackupBancoDados(txtLocalBanco.Text, txtBackup.Text);
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void ChkRequerAutenticacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRequerAutenticacao.Checked)
            {
                TxtUsuarioAutenticar.Enabled = true;
                TxtSenhaAutenticacao.Enabled = true;
            }
            else
            {
                TxtUsuarioAutenticar.Enabled = false;
                TxtSenhaAutenticacao.Enabled = false;
            }
        }
        
    }
}
