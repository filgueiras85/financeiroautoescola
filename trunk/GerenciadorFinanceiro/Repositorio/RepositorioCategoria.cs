using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioCategoria : RepositorioBase, IRepositorio<Dominio.Categoria>
    {

        #region IRepositorio<CentroCustos> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Categoria objeto)
        {
            string sSqlInsert = "insert into TB_Categoria (Descricao, IdCentroCusto) values (@Descricao, @idCusto)";
            try
            {
                Conection.AbrirConexao();
                Conection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                Conection.Execute(sSqlInsert, objeto.Descricao, objeto.CategoriaPai.Id);
                objeto.Id = Convert.ToInt32(Conection.ExecuteScalar("Select @@Identity"));
                Conection.Commit();
            }
            catch (Exception ex)
            {
                Conection.Rollback();
                throw new Exception("Não foi possível salvar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Categoria objeto)
        {
            string sSqlUpdate = "Update TB_Categoria set Descricao = @Descricao, IdCentroCusto = @IdCusto where IdCategoria = @Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.Descricao,objeto.CategoriaPai.Id ,objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Categoria objeto)
        {
            string sSqlUpdate = "Update TB_Categoria set Ativo = 0 where IdCategoria = @Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.Descricao, objeto.CategoriaPai.Id, objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.Categoria BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Categoria where IdCategoria = @IdCategoria";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.Categoria cat = new Dominio.Categoria();
                while (reader.Read())
                {
                    cat.Id = id;
                    cat.Descricao = (string)reader["Descricao"];
                    Dominio.CentroCustos catPai = new Repositorio.RepositorioCentroCustos().BuscarObjetoPorId((int)reader["IdCentroCusto"]);
                    cat.CategoriaPai = catPai;                    
                }
                return cat;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Categoria> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Categoria where Ativo = 1";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                List<Dominio.Categoria> lista = new List<GerenciadorFinanceiro.Dominio.Categoria>();
                while (reader.Read())
                {
                    Dominio.Categoria cat = new Dominio.Categoria();
                    cat.Id = (int)reader["IdCategoria"];
                    cat.Descricao = (string)reader["Descricao"];
                    Dominio.CentroCustos catPai = new Repositorio.RepositorioCentroCustos().BuscarObjetoPorId((int)reader["IdCentroCusto"]);
                    cat.CategoriaPai = catPai;
                    lista.Add(cat);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Categoria> BuscarTodasPorCentroCusto(int IdCentroCusto)
        {
            string sSqlSelect = "select * from TB_Categoria where IdCentroCusto = @IdCusto and Ativo = 1";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, IdCentroCusto);
                List<Dominio.Categoria> lista = new List<GerenciadorFinanceiro.Dominio.Categoria>();
                while (reader.Read())
                {
                    Dominio.Categoria cat = new Dominio.Categoria();
                    cat.Id = (int)reader["IdCategoria"];
                    cat.Descricao = (string)reader["Descricao"];
                    Dominio.CentroCustos catPai = new Repositorio.RepositorioCentroCustos().BuscarObjetoPorId((int)reader["IdCentroCusto"]);
                    cat.CategoriaPai = catPai;
                    lista.Add(cat);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar a Categoria.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
