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
    public partial class FrmCadCategoria : Form
    {

        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        public delegate void FinalizaInsercao(object objeto);
        public event FinalizaInsercao Finalizando;

        private List<Dominio.CentroCustos> _Custos;


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Trim() == string.Empty)
                    throw new Exception("Descrição não pode ficar em branco.");

                if (checkBox1.Checked)
                    ConfiguraCategoria();
                else
                    ConfiguraCentroCustos();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }

        }


        private void ConfiguraCategoria()
        {
            Dominio.Categoria categoria = new GerenciadorFinanceiro.Dominio.Categoria();
            categoria.Descricao = txtDescricao.Text;
            categoria.CategoriaPai = (Dominio.CentroCustos)cmbCentroCustos.SelectedItem;
            new Repositorio.RepositorioCategoria().SalvarObjeto(categoria);
            if (Finalizando != null)
                Finalizando(categoria);
        }

        private void ConfiguraCentroCustos()
        {
            Dominio.CentroCustos custos = new GerenciadorFinanceiro.Dominio.CentroCustos();
            custos.Descricao = txtDescricao.Text;
            custos.ReceitaOuDespesa = rdbReceitas.Checked ? Dominio.CentroCustos.Tipo.Receita: Dominio.CentroCustos.Tipo.Despesa;
            new Repositorio.RepositorioCentroCustos().SalvarObjeto(custos);
            if (Finalizando != null)
                Finalizando(custos);   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Custos == null)
                {
                    if (rdbReceitas.Checked)
                        _Custos = new Repositorio.RepositorioCentroCustos().BuscarTodosPorTipo(GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Receita);
                    else
                        _Custos = new Repositorio.RepositorioCentroCustos().BuscarTodosPorTipo(GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Despesa);
                }
                cmbCentroCustos.DataSource = _Custos;
                cmbCentroCustos.DisplayMember = "Descricao";
                cmbCentroCustos.ValueMember = "Id";

                if (checkBox1.Checked == true)
                {
                    cmbCentroCustos.Enabled = true;
                }
                else
                {
                    cmbCentroCustos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }  
        }

        private void cmbCentroCustos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCentroCustos.SelectedItem != null)
            {
                Dominio.CentroCustos custos = (Dominio.CentroCustos)cmbCentroCustos.SelectedItem;               
            }
        }

        private void rdbReceitas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReceitas.Checked)
            {
                _Custos = new Repositorio.RepositorioCentroCustos().BuscarTodosPorTipo(GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Receita);
                cmbCentroCustos.DataSource = _Custos;
                cmbCentroCustos.DisplayMember = "Descricao";
                cmbCentroCustos.ValueMember = "Id";
            }

        }

        private void rdbDespesas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDespesas.Checked)
            {
                _Custos = new Repositorio.RepositorioCentroCustos().BuscarTodosPorTipo(GerenciadorFinanceiro.Dominio.CentroCustos.Tipo.Despesa);                
                cmbCentroCustos.DataSource = _Custos;
                cmbCentroCustos.DisplayMember = "Descricao";
                cmbCentroCustos.ValueMember = "Id";
            }
        }
    }
}
