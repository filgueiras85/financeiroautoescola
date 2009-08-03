using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioCentroCustos : RepositorioBase, IRepositorio<Dominio.CentroCustos>
    {

        #region IRepositorio<CentroCustos> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.CentroCustos objeto)
        {
            string sSqlInsert = "insert into TB_Centro_Custos (Descricao, DespesaOuReceita) values (@Descricao, @Tipo)";
            try
            {
                Conection.AbrirConexao();
                Conection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                Conection.Execute(sSqlInsert, objeto.Descricao, objeto.ReceitaOuDespesa);
                objeto.Id =Convert.ToInt32(Conection.ExecuteScalar("Select @@Identity"));
                Conection.Commit();
            }
            catch (Exception ex)
            {
                Conection.Rollback();
                throw new Exception("Não foi possível salvar o Centro de Custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.CentroCustos objeto)
        {
            string sSqlInsert = "Update TB_Centro_Custos set Descricao = @Descricao, DespesaOuReceita = @tipo where IdCentroCustos = @Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.Descricao, objeto.ReceitaOuDespesa, objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Centro de Custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.CentroCustos objeto)
        {
            string sSqDelete = "Update TB_Centro_Custos set Ativo = 0 where IdCentroCustos = @Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqDelete, objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Centro de Custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.CentroCustos BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Centro_Custos where IdCentroCustos = @Idcusto";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.CentroCustos custos = new Dominio.CentroCustos();
                while (reader.Read())
                {
                    custos.Id = id;
                    custos.Descricao  = (string)reader["Descricao"];
                    custos.ReceitaOuDespesa = (Dominio.CentroCustos.Tipo)reader["DespesaOuReceita"];
                }
                return custos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Centro de custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.CentroCustos> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Centro_Custos where Ativo = 1";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                List<Dominio.CentroCustos> lista = new List<GerenciadorFinanceiro.Dominio.CentroCustos>();
                while (reader.Read())
                {
                    Dominio.CentroCustos custos = new Dominio.CentroCustos();
                    custos.Id = (int)reader["IdCentroCustos"];
                    custos.Descricao = (string)reader["Descricao"];
                    custos.ReceitaOuDespesa = (Dominio.CentroCustos.Tipo)reader["DespesaOuReceita"];
                    lista.Add(custos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar os Centros de custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.CentroCustos> BuscarTodosPorTipo(Dominio.CentroCustos.Tipo tipo)
        {
            string sSqlSelect = "select * from TB_Centro_Custos where DespesaOuReceita = @tipo and Ativo = 1";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, tipo);
                List<Dominio.CentroCustos> lista = new List<GerenciadorFinanceiro.Dominio.CentroCustos>();
                while (reader.Read())
                {
                    Dominio.CentroCustos custos = new Dominio.CentroCustos();
                    custos.Id = (int)reader["IdCentroCustos"];
                    custos.Descricao = (string)reader["Descricao"];
                    custos.ReceitaOuDespesa = (Dominio.CentroCustos.Tipo)reader["DespesaOuReceita"];
                    lista.Add(custos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar os Centros de custos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
