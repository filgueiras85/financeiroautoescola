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
    partial class FrmReceita : Form
    {

        private Dominio.Receita _Receita;
        private List<Dominio.Aluno> _ListAlunos;
        private List<Dominio.CentroCustos> _ListCentroCustos;
        private List<Dominio.Categoria> _ListCategoria;
        BindingSource _BindingSource = new BindingSource();

        //public FrmReceita()
        //{
        //    InitializeComponent();
        //}

        public FrmReceita(Dominio.Receita receita)
        {
            InitializeComponent();
            _Receita = receita;
        }

        private void PreencherFormulario()
        {
            this.CmbAluno.SelectedItem = _Receita.AlunoReceita;
            this.CmbCentroDeCusto.SelectedItem = _Receita.CentroCustoReceita;
            this.CmbCategoria.SelectedItem = _Receita.CategoriaReceita;
            this.TxtObservacao.Text = _Receita.Observacao;
            this.CmbFrequencia.SelectedText = _Receita.Frequencia;
            this.TxtQntdParcelas.Text = _Receita.QuantidadeParcela.ToString();
            this.DateTimePrimeiroVencimento.Value = _Receita.UltimoVencimento;
            this.TxtValorTotal.Text = _Receita.ValorTotalReceita.ToString();
        }

        private void PreencherComboFrequencia()
        {
            CmbFrequencia.DisplayMember = "Descricao";
            CmbFrequencia.ValueMember = "DiferencaDias";
            CmbFrequencia.DataSource = new Dominio.ListaFrequencia().ListFrequencia;
        }

        private void FrmReceita_Load(object sender, EventArgs e)
        {
            this.PreencherComboFrequencia();
            this.BuscarTodosOsAlunos();
            this.BuscarTodosOsCentrosDeCusto();
            this.PreencherFormulario();
            _BindingSource.DataSource = _Receita.ListaReceitaParcela;
            DGPreviewReceita.DataSource = _BindingSource;
        }

        private void BuscarTodosOsAlunos()
        {
            _ListAlunos = new Repositorio.RepositorioAluno().BuscarTodos();
            CmbAluno.DisplayMember = "NomeAluno";
            CmbAluno.ValueMember = "IdAluno";
            CmbAluno.DataSource = _ListAlunos;
        }

        private void BuscarTodosOsCentrosDeCusto()
        {
            _ListCentroCustos = new Repositorio.RepositorioCentroCustos().BuscarTodos();
            CmbCentroDeCusto.DisplayMember = "Descricao";
            CmbCentroDeCusto.ValueMember = "Id";
            CmbCentroDeCusto.DataSource = _ListCentroCustos;
        }

        private void BuscarTodasAsCategoriasPorCentroDeCusto()
        {
            _ListCategoria = new Repositorio.RepositorioCategoria().BuscarTodasPorCentroCusto((int)CmbCentroDeCusto.SelectedValue);
            CmbCategoria.DisplayMember = "Descricao";
            CmbCategoria.ValueMember = "Id";
            CmbCategoria.DataSource = _ListCategoria;
        }

        private void CamposQuantidadeParcela()
        {
            if (CmbFrequencia.SelectedIndex == 0)
            {
                LblVenvimento.Text = "Vencimento :";
                TxtQntdParcelas.Text = "1";
                TxtQntdParcelas.Enabled = false;
            }
            else
            {
                LblVenvimento.Text = "Primeiro vencimento :";
                TxtQntdParcelas.Enabled = true;
            }
        }

        private void CmbFrequencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CamposQuantidadeParcela();
        }

        private void CmbCentroDeCusto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCentroDeCusto.SelectedItem != null)
                this.BuscarTodasAsCategoriasPorCentroDeCusto();
        }

        private void PreencherReceita()
        {
            _Receita.AlunoReceita = (Dominio.Aluno)CmbAluno.SelectedItem;
            _Receita.CentroCustoReceita = (Dominio.CentroCustos)CmbCentroDeCusto.SelectedItem;
            _Receita.CategoriaReceita = (Dominio.Categoria)CmbCategoria.SelectedItem;
            _Receita.Observacao = TxtObservacao.Text;
            _Receita.Frequencia = CmbFrequencia.SelectedText;
            _Receita.QuantidadeParcela = int.Parse(TxtQntdParcelas.Text);
            _Receita.ValorTotalReceita = double.Parse(TxtValorTotal.Text);
            _Receita.UltimoVencimento = DateTimePrimeiroVencimento.Value.AddDays((int.Parse(TxtQntdParcelas.Text) * (int)CmbFrequencia.SelectedValue));
        }

        private void PreviewParcelasVenda()
        {
            PreencherReceita();
            _Receita.ListaReceitaParcela.Clear();
            for(int i = 0; i < _Receita.QuantidadeParcela; i++)
                _Receita.ListaReceitaParcela.Add(new Dominio.ReceitaParcela(){ IdParcela = 0, NumeroDaParcela = (i + 1), 
                                                 ValorParcela = (double.Parse(TxtValorTotal.Text) /  int.Parse(TxtQntdParcelas.Text)), 
                                                 Vencimento = DateTimePrimeiroVencimento.Value.AddDays((int)CmbFrequencia.SelectedValue * (i)), 
                                                 StatusParcela = 0});
            _BindingSource.ResetBindings(true);
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            this.PreviewParcelasVenda();
        }

        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            FrmAluno frm = new FrmAluno();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodosOsAlunos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGPreviewReceita_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGPreviewReceita.Columns[e.ColumnIndex].Name == "ColStatusParcela")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        if ((int)e.Value == 0)
                            e.Value = "Aberta";
                        else
                            e.Value = "Quitada";
                    }
                }
            }
        }
    }
}
