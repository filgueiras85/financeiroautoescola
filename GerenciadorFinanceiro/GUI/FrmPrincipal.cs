using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace GerenciadorFinanceiro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string data = diasemana + ", " + dia + " de " + mes + " de " + ano;


            LblDataHora.Text = data + "  " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            
        }

        private void instrutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }           

            GUI.FrmInstrutores form = new GerenciadorFinanceiro.GUI.FrmInstrutores();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tipoDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }

            GUI.FrmTipoVeiculo form = new GerenciadorFinanceiro.GUI.FrmTipoVeiculo();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void fabricanteDeVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }

            GUI.FrmFabricanteVeiculo form = new GerenciadorFinanceiro.GUI.FrmFabricanteVeiculo();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }

            GUI.FrmEstado form = new GerenciadorFinanceiro.GUI.FrmEstado();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }

            GUI.FrmCidade form = new GerenciadorFinanceiro.GUI.FrmCidade();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void modeloDeVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmModeloVeiculo form = new GerenciadorFinanceiro.GUI.FrmModeloVeiculo();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmVeiculo form = new GerenciadorFinanceiro.GUI.FrmVeiculo();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmAluno form = new GerenciadorFinanceiro.GUI.FrmAluno();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tiposDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmTipoServico form = new GerenciadorFinanceiro.GUI.FrmTipoServico();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmServicos form = new GerenciadorFinanceiro.GUI.FrmServicos();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmAluno form = new GerenciadorFinanceiro.GUI.FrmAluno();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.RealizarBackup)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                new Servicos.Backup().RealizarBackupBancoDados();
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
            Application.Exit();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmEmail form = new GerenciadorFinanceiro.GUI.FrmEmail();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            Configuracao.FrmUsuario  form = new GerenciadorFinanceiro.Configuracao.FrmUsuario();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmFormaPagamento form = new GerenciadorFinanceiro.GUI.FrmFormaPagamento();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmCategorias form = new GerenciadorFinanceiro.GUI.FrmCategorias();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void restaurarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracao.FrmRestaurarBackup frm = new Configuracao.FrmRestaurarBackup();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmReceita form = new GerenciadorFinanceiro.GUI.FrmReceita(new Dominio.Receita());
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void configuraçõesDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracao.FrmConfiguracao frm = new Configuracao.FrmConfiguracao(false);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void configurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            new Servicos.Backup().RealizarBackupBancoDados();
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void combustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmCombustivel form = new GerenciadorFinanceiro.GUI.FrmCombustivel();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
            }
            GUI.FrmDespesa form = new GerenciadorFinanceiro.GUI.FrmDespesa();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

    }
}
