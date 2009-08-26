using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioDespesasCombustivel: RepositorioBase , IRepositorio<Dominio.DespesaCombustivel>
    {

        #region IRepositorio<DespesaCombustivel> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.DespesaCombustivel objeto)
        {
            string sSqlInsert = "insert into TB_Despesa_Combustivel (IdVeiculo, KmInicial, KmFinal, QtdLitros, " +
                                "ValorTotal, TipoCombustivel, DataAbastecimento) " +
                                 "values (@IdVeiculo, @KmInicial, @KmFinal, @QtdLitros, @Valor, @Combustivel, @DataAbastecimento)";
            try
            {
                Conection.AbrirConexao();
                Conection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                Conection.Execute(sSqlInsert, objeto.Veiculo.IdVeiculo, objeto.KmInicial, objeto.KmFinal ,
                                objeto.QtdLitros, objeto.ValorTotal , objeto.Combustivel, objeto.DataAbastecimento );
                objeto.IdDespesaCombustivel =Convert.ToInt32(Conection.ExecuteScalar("select @@Identity"));
                Conection.Commit();
            }
            catch (Exception ex)
            {
                Conection.Rollback();
                throw new Exception("Não foi possível Salvar as Despesas de combustivel.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.DespesaCombustivel objeto)
        {
            string sqlUpdate = "update TB_Despesa_Combustivel set KmInicial=@KmIni, KmFinal=@kmFinal, " +
                               "QtdLitros=@litros, ValorTotal=@Valor, TipoCombustivel=@Comb, " +
                               "DataAbastecimento=@Data where IdDespesaCombustivel=@Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sqlUpdate, objeto.Veiculo.IdVeiculo, objeto.KmInicial, objeto.KmFinal,
                                objeto.QtdLitros, objeto.ValorTotal, objeto.Combustivel, objeto.DataAbastecimento, objeto.IdDespesaCombustivel);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar as Despesas de Combustivel.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.DespesaCombustivel objeto)
        {
            string sqlDelete = "delete from TB_Despesa_Combustivel where IdDespesaCombustivel=@id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sqlDelete, objeto.IdDespesaCombustivel);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar a Despesa de combustivel.", ex);
            }
            finally 
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.DespesaCombustivel BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.DespesaCombustivel> BuscarTodos()
        {
          

            throw new NotImplementedException();

        }

        public List<Dominio.DespesaCombustivel> BuscarTodasPorVeiculo()
        {
            throw new NotImplementedException();
        }

        public Dominio.DespesaCombustivel BuscarUltimaDespesaVeiculo(Dominio.Veiculo veiculo)
        {
            string sqlBusca = "SELECT TOP (1) IdDespesaCombustivel, IdVeiculo, KmInicial, KmFinal,"
                              + "QtdLitros, ValorTotal, TipoCombustivel, DataAbastecimento FROM "
                              + "TB_Despesa_Combustivel WHERE IdVeiculo = @IdVeiculo ORDER BY KmFinal DESC";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sqlBusca, veiculo.IdVeiculo);
                Dominio.DespesaCombustivel despesa = new GerenciadorFinanceiro.Dominio.DespesaCombustivel();
                while (reader.Read())
                {
                    despesa.IdDespesaCombustivel = (int)reader["IdDespesaCombustivel"];
                    despesa.Veiculo = veiculo;
                    despesa.KmInicial = (int)reader["KmInicial"];
                    despesa.KmFinal = (int)reader["KmFinal"];
                    despesa.QtdLitros = (int)reader["QtdLitros"];
                    despesa.ValorTotal = (double)reader["ValorTotal"];
                    despesa.Combustivel = (TipoCombustivel)reader["TipoCombustivel"];
                    despesa.DataAbastecimento = (DateTime)reader["DataAbastecimento"];
                }
                return despesa;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar a Ultima quilometragem do Carro.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion

    }
}
