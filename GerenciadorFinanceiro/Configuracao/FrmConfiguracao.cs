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

        
    }
}
