﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorFinanceiro.Configuracao
{
    public partial class FrmRestaurarBackup : Form
    {
        public FrmRestaurarBackup()
        {
            InitializeComponent();
        }

        private void BtnRealizarBackupAgora_Click(object sender, EventArgs e)
        {        
            if (MessageBox.Show("Tem certeza que deseja restaurar o sistema da backup Selecionado ?  ","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                new Servicos.Backup().RestaurarBancoDados(CmbListaBackups.Text);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.Close();
            }
        }

        private void FrmRestaurarBackup_Load(object sender, EventArgs e)
        {
            CmbListaBackups.Items.Clear();
            String[] registrosBackup = new Servicos.Backup().ListarTodosOsBackup();
            for (int i = 0; i < registrosBackup.Length; i++)
                CmbListaBackups.Items.Add(registrosBackup[i]);
            CmbListaBackups.SelectedIndex = 0;
        }

    }
}