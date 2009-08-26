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
    public partial class FrmCombustivel : Form
    {

        private List<Dominio.Veiculo> _ListaCarros;
        private BindingSource _Binding;

        private Dominio.DespesaCombustivel _Despesa;

        public FrmCombustivel()
        {
            InitializeComponent();
        }

        public FrmCombustivel(Dominio.DespesaCombustivel despesa)
        {
            InitializeComponent();
            _Despesa = despesa;
        }

        private void FrmCombustivel_Load(object sender, EventArgs e)
        {
            BuscarCarros();
            PreencherCampos();
        }
        
        private void BuscarCarros()
        {
           _ListaCarros = new Repositorio.RepositorioVeiculo().BuscarTodos();
           cmbVeiculo.DataSource = _ListaCarros;
           cmbVeiculo.SelectedValue = "IdVeiculo";
        }

        private void PreencherCampos()
        {
            if (_Despesa == null)
                _Despesa = new GerenciadorFinanceiro.Dominio.DespesaCombustivel();
            cmbVeiculo.SelectedValue = _Despesa.Veiculo.IdVeiculo;
            txtKmInicial.Text = _Despesa.KmInicial.ToString();
            txtKmFinal.Text = _Despesa.KmFinal.ToString();
            txtLitros.Text = _Despesa.QtdLitros.ToString();
            txtValorTotal.Text = _Despesa.ValorTotal.ToString();
            cmbTipoComb.SelectedIndex =(int) _Despesa.Combustivel;
            txtDataAbastec.Value = _Despesa.DataAbastecimento;
        }

        private void ValidarCampos()
        {
            if (_Despesa == null)
                _Despesa = new GerenciadorFinanceiro.Dominio.DespesaCombustivel();
            if (cmbVeiculo.SelectedItem == null)
                throw new Exception("Por favor escolha o veiculo.");
            _Despesa.Veiculo = (Dominio.Veiculo)cmbVeiculo.SelectedItem;
            int kmIni;
            if (!int.TryParse(txtKmInicial.Text, out kmIni))
                throw new Exception("Por favor digite a Km Inicial corretamente.");
            _Despesa.KmInicial = kmIni;
            int kmFim;
            if (!int.TryParse(txtKmFinal.Text, out kmFim))
                throw new Exception("Por favor digite a Km Final corretamente.");
            _Despesa.KmFinal = kmFim;
            int litros;
            if (!int.TryParse(txtLitros.Text, out litros))
                throw new Exception("Por favor digite a Quantidade de litros corretamente.");
            _Despesa.QtdLitros = litros;
            double valor;
            if (!double.TryParse(txtValorTotal.Text, out valor))
                throw new Exception("Por favor digite um valor");
            _Despesa.ValorTotal = valor;
            if (cmbTipoComb.SelectedIndex == -1)
                throw new Exception("Por favor escolha o tipo de combustivvel.");
            _Despesa.Combustivel = (TipoCombustivel)cmbTipoComb.SelectedIndex;
            _Despesa.DataAbastecimento = txtDataAbastec.Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();
                if (_Despesa.IdDespesaCombustivel == 0)
                    new Repositorio.RepositorioDespesasCombustivel().SalvarObjeto(_Despesa);
                else
                    new Repositorio.RepositorioDespesasCombustivel().AtualizarObjeto(_Despesa);
                _Despesa = new GerenciadorFinanceiro.Dominio.DespesaCombustivel();
                PreencherCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimoKm_Click(object sender, EventArgs e)
        {
            if (cmbVeiculo.SelectedItem != null)
            {
                Dominio.DespesaCombustivel despesa = new Repositorio.RepositorioDespesasCombustivel().BuscarUltimaDespesaVeiculo((Dominio.Veiculo)cmbVeiculo.SelectedItem);
                txtKmInicial.Text = despesa.KmFinal.ToString();
            }
            else
                MessageBox.Show("Por favor escolha um veiculo.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     }
}
