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
        private List<Dominio.TipoServico> _ListTipoServico;
        private List<Dominio.Servico> _ListServico;
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
            this.CmbTipoDeServico.SelectedItem = _Receita.TipoServicoReceita;
            this.CmbServico.SelectedItem = _Receita.ServicoReceita;
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
            this.BuscarTodosOsTiposDeServicos();
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

        private void BuscarTodosOsTiposDeServicos()
        {
            _ListTipoServico = new Repositorio.RepositorioTipoServico().BuscarTodos();
            CmbTipoDeServico.DisplayMember = "Descricao";
            CmbTipoDeServico.ValueMember = "IdTipoServico";
            CmbTipoDeServico.DataSource = _ListTipoServico;
        }

        private void BuscarTodosOsServicosPorTipoDeServico()
        {
            _ListServico = new Repositorio.RepositorioServico().BuscarTodosPorTipoDeServico((int)CmbTipoDeServico.SelectedValue);
            CmbServico.DisplayMember = "Descricao";
            CmbServico.ValueMember = "IdServico";
            CmbServico.DataSource = _ListServico;
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
            if (CmbTipoDeServico.SelectedItem != null)
                this.BuscarTodosOsServicosPorTipoDeServico();
        }

        private void PreencherReceita()
        {
            _Receita.AlunoReceita = (Dominio.Aluno)CmbAluno.SelectedItem;
            _Receita.TipoServicoReceita = (Dominio.TipoServico)CmbTipoDeServico.SelectedItem;
            _Receita.ServicoReceita = (Dominio.Servico)CmbServico.SelectedItem;
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
                                                 StatusParcela = 0, DataCompetencia = DateTimePrimeiroVencimento.Value.AddDays((int)CmbFrequencia.SelectedValue * (i))});
            _BindingSource.ResetBindings(true);
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            this.PreviewParcelasVenda();
            this.PreencherComboParcelas(_Receita.QuantidadeParcela);
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

        private void CmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbServico.SelectedItem != null)
                TxtValorTotal.Text = ((Dominio.Servico)CmbServico.SelectedItem).Valor.ToString();
        }

        private void BtnNovoServico_Click(object sender, EventArgs e)
        {
            FrmServicos frm = new FrmServicos();
            frm.ShowDialog();
            frm.Dispose();
            this.BuscarTodosOsServicosPorTipoDeServico();
        }

        private void PreencherComboParcelas(int qntdParcelas)
        {
            for (int i = 1; i <= qntdParcelas; i++)
                CmbParcela.Items.Add(i);
        }

        private void PreencherCamposInformacoesAdicionais()
        {
            this.TxtNumeroDoTitulo.Text = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].NumeroDoTitulo;
            this.CmbTipoDocumento.SelectedIndex = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].TipoDocumento;
            this.CmbDataCompetencia.Value = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].DataCompetencia;
            this.TxtNumeroDoDocumento.Text  = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].NumeroDoDocumento;
            this.TxtSerie.Text = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].Serie;
            this.TxtIdentificacao.Text = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].Identificacao;
            this.TxtObservacaoIndividual.Text = _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].ObservacaoIndividual;
        }

        private void CmbParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PreencherCamposInformacoesAdicionais();
        }

        private void TxtNumeroDoTitulo_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].NumeroDoTitulo = TxtNumeroDoTitulo.Text;
        }

        private void CmbTipoDocumento_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].TipoDocumento = CmbTipoDocumento.SelectedIndex;
        }

        private void CmbDataCompetencia_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].DataCompetencia = CmbDataCompetencia.Value;
        }

        private void TxtNumeroDoDocumento_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].NumeroDoDocumento = TxtNumeroDoDocumento.Text;
        }

        private void TxtSerie_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].Serie = TxtSerie.Text;
        }

        private void TxtIdentificacao_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].Identificacao = TxtIdentificacao.Text;
        }

        private void TxtObservacaoIndividual_Leave(object sender, EventArgs e)
        {
            _Receita.ListaReceitaParcela[(int)CmbParcela.SelectedIndex].ObservacaoIndividual = TxtObservacaoIndividual.Text;
        }

    }
}
