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
    public partial class FrmDespesa : Form
    {
        private Dominio.Despesa _Despesa;
        private BindingSource _Binding;

        public FrmDespesa()
        {
            InitializeComponent();
        }

        public FrmDespesa(Dominio.Despesa despesa)
        {
            _Despesa = despesa;
        }

        #region "Validacoes e Salvar"

        private void ValidarCampos()
        {
            if (TxtDescricao.Text.Trim() == string.Empty)
                throw new Exception("Campo descrição não pode ficar em branco.");
            _Despesa.Descricao = TxtDescricao.Text;
            if (cmbFavorecido.SelectedItem == null)
                throw new Exception("Por favor escolha um favorecido.");
            _Despesa.PagarPara = (Dominio.Fornecedor)cmbFavorecido.SelectedItem;
            if (cmbCategoria.SelectedItem == null)
                throw new Exception("Por favor escolha uma categoria.");
            _Despesa.CategoriaReceita = (Dominio.Categoria)cmbCategoria.SelectedItem;
            double d;
            if (!Double.TryParse(txtValorUnitario.Text,out d))
                throw new Exception("O valor digitado é inválido.");            
            if (cmbFrequencia.SelectedIndex == -1)
                throw new Exception("Por favor escolha a frequência das parcelas.");
            int i;
            if (!int.TryParse(txtQtdParcelas.Text,out i))
                throw new Exception("Por favor escolha o numero de parcelas.");

            _Despesa.ValorTotalDespesa = d * i;
            _Despesa.frequencia = (Dominio.Frequencia)cmbFrequencia.SelectedItem;
            _Despesa.QuantidadeParcela = i;
        }

        private void CarregarCampos()
        {
            cmbFrequencia.DataSource = new Dominio.ListaFrequencia().ListFrequencia;
            cmbFrequencia.DisplayMember = "Descricao";
            cmbFrequencia.ValueMember = "DiferencaDias";
        }

        private void Salvar()
        {
            if (_Despesa == null)
                _Despesa = new GerenciadorFinanceiro.Dominio.Despesa();
            if (_Despesa.ListaParcelasDespesas == null)
                _Despesa.ListaParcelasDespesas = new List<GerenciadorFinanceiro.Dominio.DespesaParcela>();

            ValidarCampos();

            if (_Despesa.IdDespesa == 0)
                new Repositorio.RepositorioDespesa().SalvarObjeto(_Despesa);
            else
                new Repositorio.RepositorioDespesa().AtualizarObjeto(_Despesa);

            for (int i = 0; i < _Despesa.ListaParcelasDespesas.Count; i++)
            {
                if(_Despesa.ListaParcelasDespesas[i].IdParcela==0)
                    new Repositorio.RepositorioDespesaParcela().SalvarObjeto(_Despesa.ListaParcelasDespesas[i]);
                else
                    new Repositorio.RepositorioDespesaParcela().AtualizarObjeto(_Despesa.ListaParcelasDespesas[i]);
            }
        }

        #endregion


        private void FrmDespesa_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {              
                Salvar();
                MessageBox.Show("Salvo com sucesso!", "Informação.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar o cadastro", "Pergunta.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                this.Close();
        }

        private void btnFavorecido_Click(object sender, EventArgs e)
        {
            FrmFavorecido favorecido = new FrmFavorecido();
            favorecido.ShowDialog();
        }

        private void btrnNovaCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias categoria = new FrmCategorias();
            categoria.ShowDialog();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();                
                int qtdParcelas = int.Parse(txtQtdParcelas.Text);
                if(_Despesa == null)
                    _Despesa = new GerenciadorFinanceiro.Dominio.Despesa();
                if(_Despesa.ListaParcelasDespesas==null)
                    _Despesa.ListaParcelasDespesas = new List<GerenciadorFinanceiro.Dominio.DespesaParcela>();
                if(_Binding ==null)
                    _Binding = new BindingSource(_Despesa.ListaParcelasDespesas, "");

                _Despesa.ListaParcelasDespesas.Clear();
                for (int i = 0; i < qtdParcelas; i++)
                {
                    Dominio.DespesaParcela parcela = new Dominio.DespesaParcela();
                    parcela.NumeroDaParcela = i+1;
                    parcela.Status = StatusParcela.Aberta;
                    parcela.ValorParcela = double.Parse(txtValorUnitario.Text);
                    Dominio.Frequencia frequencia = (Dominio.Frequencia)cmbFrequencia.SelectedItem;
                    parcela.Vencimento = txtDataVcto.Value.AddDays(i *  frequencia.DiferencaDias);
                    
                    _Despesa.ListaParcelasDespesas.Add(parcela);
                }
                gridViewParcelas.DataSource = _Binding;
                _Binding.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção.");
            }
        }

        private void cmbFrequencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrequencia.SelectedItem != null)
            {
                Dominio.Frequencia frequencia = (Dominio.Frequencia)cmbFrequencia.SelectedItem;
                if (frequencia.Descricao == "Uma única vez")
                {
                    txtQtdParcelas.Text = "1";
                    txtQtdParcelas.Enabled = false;
                }
                else
                    txtQtdParcelas.Enabled = true;

            }
        }    

    }
}
