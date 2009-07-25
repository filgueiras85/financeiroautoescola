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
    public partial class FrmInstrutores : Form
    {
        public FrmInstrutores()
        {
            InitializeComponent();
        }

        private List<Dominio.Instrutor> _ListaInstrutor = new List<GerenciadorFinanceiro.Dominio.Instrutor>();
        private List<Dominio.Cidade> _ListaCidade = new List<GerenciadorFinanceiro.Dominio.Cidade>();
        private List<Dominio.Estado> _ListaEstados = new List<GerenciadorFinanceiro.Dominio.Estado>();
        private Dominio.Instrutor _Instrutor = new Dominio.Instrutor();

        private void EnabledCampos(bool enabled)
        {           
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ComboBox)
                    ((ComboBox)ctr).Enabled = enabled;
                else if (ctr is TextBox)
                    ((TextBox)ctr).Enabled = enabled;
                else if (ctr is MaskedTextBox)
                    ((MaskedTextBox)ctr).Enabled = enabled;
                else if (ctr is Button)
                    ((Button)ctr).Enabled = enabled;
            }
        }

        private void CamposInterface(Dominio.Instrutor instrutor, Status status)
        {
            TxtNomeInstrutor.Text = instrutor.Nome;
            TxtTelefoneResidencial.Text = instrutor.TelefoneResidencial;
            TxtTelefoneCelular.Text = instrutor.TelefoneCelular;
            TxtRG.Text = instrutor.RG;
            TxtCPF.Text = instrutor.CPF;
            TxtRua.Text = instrutor.Endereco.Rua;
            TxtNumero.Text = instrutor.Endereco.Numero.ToString();
            TxtComplemento.Text = instrutor.Endereco.Complemento;
            TxtBairro.Text = instrutor.Endereco.Bairro;
            TxtCEP.Text = instrutor.Endereco.CEP;
            if (instrutor.Endereco.Cidade.IdCidade > 0)
            {
                CmbEstado.SelectedValue = instrutor.Endereco.Cidade.Estado.IdEstado;
                CmbCidade.SelectedValue = instrutor.Endereco.Cidade.IdCidade;
            }
            else
            {
                CmbEstado.SelectedIndex = 0;
                CmbCidade.SelectedIndex = 0;
            }
            TxtObservacaoInstrutor.Text = instrutor.Observacao;
          
            if (status == Status.Inserindo)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Inserindo";
            }
            else if (status == Status.Editando)
            {
                this.EnabledCampos(true);
                LblStatus.Text = "Status : Editando";
            }
            else if (status == Status.Excluindo)
            {
                this.EnabledCampos(false);
                LblStatus.Text = "Status : Excluindo";
            }
            else
            {
                this.EnabledCampos(false);
                LblStatus.Text = "Status : Consultando";
            }
        }

        private void BuscarTodosOsInstrutores()
        {
            _ListaInstrutor = new Repositorio.RepositorioInstrutor().BuscarTodos();
            DGInstrutores.DataSource = _ListaInstrutor;
            this.ctrNavigator1.DataSource = _ListaInstrutor;
        }

        private void BuscarTodosOsEstados()
        {
            _ListaEstados = new Repositorio.RepositorioEstado().BuscarTodos();
            CmbEstado.DisplayMember = "SiglaEstado";
            CmbEstado.ValueMember = "IdEstado";
            CmbEstado.DataSource = _ListaEstados;
        }

        private void BuscarTodasAsCidadesPorEstado(Dominio.Estado est)
        {
            _ListaCidade = new Repositorio.RepositorioCidade().BuscarCidadesPorEstado(est);
            CmbCidade.DisplayMember = "NomeCidade";
            CmbCidade.ValueMember = "IdCidade";
            CmbCidade.DataSource = _ListaCidade;
        }

        private void FrmInstrutores_Load(object sender, EventArgs e)
        {
            this.BuscarTodosOsEstados();
            this.BuscarTodosOsInstrutores();            
            this.Refresh();
        }

        private void ctrNavigator1_MudaRegistroSelecionado(object objetoAtual)
        {
            //Dominio.Instrutor instrutor = (Dominio.Instrutor)objetoAtual;
            //this.TxtNomeInstrutor.Text = instrutor.Nome;
            for (int i = 0; i < DGInstrutores.Rows.Count; i++)
            {
                if (i == ctrNavigator1.Indice)
                    DGInstrutores.Rows[i].Selected = true;
                else
                    DGInstrutores.Rows[i].Selected = false;
            }
        }

        private void DGInstrutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGInstrutores.Columns[e.ColumnIndex].Name == "Rua")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        Dominio.Endereco endereco = (Dominio.Endereco)e.Value;//DGInstrutores.Rows[e.RowIndex].Cells["Rua"]
                        e.Value = endereco.Rua;
                        DGInstrutores.Rows[e.RowIndex].Cells["Numero"].Value = endereco.Numero;
                        DGInstrutores.Rows[e.RowIndex].Cells["Complemento"].Value = endereco.Complemento;
                        DGInstrutores.Rows[e.RowIndex].Cells["Bairro"].Value = endereco.Bairro;
                        DGInstrutores.Rows[e.RowIndex].Cells["CEP"].Value = endereco.CEP;
                        DGInstrutores.Rows[e.RowIndex].Cells["Cidade"].Value = endereco.Cidade.NomeCidade;
                    }
                }
            }
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuscarTodasAsCidadesPorEstado((Dominio.Estado)CmbEstado.SelectedItem);
        }

        private void ctrNavigator1_EventoNovo()
        {
            _Instrutor = null;
            _Instrutor = new Dominio.Instrutor();
            this.CamposInterface(_Instrutor, Status.Inserindo);
        }

        private void ctrNavigator1_EditarRegistro(object objEditar)
        {
            this.CamposInterface(_Instrutor, Status.Editando);
        }

        private void ctrNavigator1_CancelarAcao()
        {
            this.CamposInterface(_Instrutor, Status.Consultando);
        }

        private void ctrNavigator1_SalvarRegistro(object objSalvar)
        {
            this._Instrutor.Nome = TxtNomeInstrutor.Text;
            this._Instrutor.TelefoneResidencial = TxtTelefoneResidencial.Text;
            this._Instrutor.TelefoneCelular = TxtTelefoneCelular.Text;
            this._Instrutor.RG = TxtRG.Text;
            this._Instrutor.CPF = TxtCPF.Text;
            Dominio.Endereco end = new Dominio.Endereco();
            end.Rua = TxtRua.Text;
            end.Numero = int.Parse(TxtNumero.Text);
            end.Complemento = TxtComplemento.Text;
            end.Bairro = TxtBairro.Text;
            end.CEP = TxtCEP.Text;
            end.Cidade = (Dominio.Cidade)CmbCidade.SelectedItem;
            end.Cidade.Estado = (Dominio.Estado)CmbEstado.SelectedItem;
            this._Instrutor.Endereco = end;
            this._Instrutor.Observacao = TxtObservacaoInstrutor.Text;
            this._Instrutor.PathFoto = "";
            try
            {
                if (_Instrutor.IdInstrutor == 0)
                    new Repositorio.RepositorioInstrutor().SalvarObjeto(_Instrutor);
                else
                    new Repositorio.RepositorioInstrutor().AtualizarObjeto(_Instrutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
            this.BuscarTodosOsInstrutores();
            this.CamposInterface(_Instrutor, Status.Consultando);
        }

        private void ctrNavigator1_ExcluirRegistro(object objExcluir)
        {
            this.CamposInterface(_Instrutor, Status.Excluindo);
            if (MessageBox.Show("Deseja excluir o registro.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Repositorio.RepositorioInstrutor().DeletarObjeto(_Instrutor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!");
                }
                this.BuscarTodosOsInstrutores();
            }
        }

        private void DGInstrutores_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DGInstrutores.Rows.Count > 0)
            {
                if (DGInstrutores.SelectedRows.Count > 0)
                {
                    _Instrutor = (Dominio.Instrutor)DGInstrutores.SelectedRows[0].DataBoundItem;
                    if (ctrNavigator1.DataSource != null)
                        ctrNavigator1.Indice = DGInstrutores.SelectedRows[0].Index;
                }
            }
            else
            {
                _Instrutor = null;
                _Instrutor = new Dominio.Instrutor();
            }
            this.CamposInterface(_Instrutor, Status.Consultando);
        }
     }
}
