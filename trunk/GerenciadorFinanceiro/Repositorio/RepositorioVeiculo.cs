using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioVeiculo: Repositorio.RepositorioBase, IRepositorio<Dominio.Veiculo>
    {
        #region IRepositorio<Veiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            string sSqlInsert = "insert into TB_Veiculo (Placa, Renavam, Chassi, Ano, Modelo, Cor, Observacao, IdTipoVeiculo, IdModeloVeiculo)" +
                                " values (@Placa, @Renavam, @Chassi, @Ano, @Modelo, @Cor, @Observacao, @IdTipoVeiculo, @IdModeloVeiculo)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Placa, objeto.Renavam, objeto.Chassi, objeto.Ano, objeto.Modelo, objeto.Cor, objeto.TipoVeiculo.IdTipoVeiculo, objeto.ModeloVeiculo.IdModeloVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            throw new NotImplementedException();
        }

        public Dominio.Veiculo BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Veiculo> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
