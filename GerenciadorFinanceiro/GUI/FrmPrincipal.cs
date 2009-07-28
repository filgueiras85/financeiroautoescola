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

    }
}
