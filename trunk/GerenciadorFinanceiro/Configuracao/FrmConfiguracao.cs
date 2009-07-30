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
            if (_PrimeiraVez)
                this.Height = 335;
            else
            {
                this.Height = 250;
                this.GrpUsuario.Visible = false;
            }
        }

        private void ValidaCampos()
        {
            if (txtLocalBanco.Text.Trim() == string.Empty)
                throw new Exception("Local do banco de dados inválido.");
            if (chkRealizarBackup.Checked)
                if (txtBackup.Text.Trim() == string.Empty)
                    throw new Exception("Local do backup não pode estar vazio quando o backup está habilitado.");
            GerenciadorFinanceiro.Properties.Settings.Default.LocalDB = txtLocalBanco.Text;
            GerenciadorFinanceiro.Properties.Settings.Default.LocalBackupDB = txtBackup.Text;
            GerenciadorFinanceiro.Properties.Settings.Default.RealizarBackup = chkRealizarBackup.Checked;
            GerenciadorFinanceiro.Properties.Settings.Default.Save();
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
            txtLocalBanco.Text = GerenciadorFinanceiro.Properties.Settings.Default.LocalDB;
            txtBackup.Text = GerenciadorFinanceiro.Properties.Settings.Default.LocalBackupDB;
            chkRealizarBackup.Checked = GerenciadorFinanceiro.Properties.Settings.Default.RealizarBackup;
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
        
    }
}
