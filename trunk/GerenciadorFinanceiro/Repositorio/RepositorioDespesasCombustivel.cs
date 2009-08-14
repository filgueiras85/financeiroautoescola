using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioDespesasCombustivel: RepositorioBase , IRepositorio<Dominio.DespesaCombustivel>
    {

        #region IRepositorio<DespesaCombustivel> Members

        public void SalvarObjeto(ref GerenciadorFinanceiro.Dominio.DespesaCombustivel objeto)
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
                objeto.IdDespesaCombustivel = Conection.ExecuteScalar("select @@Identity");
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

        }

        public Dominio.DespesaCombustivel BuscarUltimaDespesaVeiculo()
        {

        }

        #endregion
    }
}
