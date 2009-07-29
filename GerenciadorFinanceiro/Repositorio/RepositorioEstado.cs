using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioEstado: Repositorio.RepositorioBase, IRepositorio<Dominio.Estado>
    {

        #region IRepositorio<Estado> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            string sSqlInsert = "insert into TB_Estado (NomeEstado, Sigla) values (@NomeEstado, @Sigla)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.NomeEstado, objeto.SiglaEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o estado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            string sSqlUpdate = "update TB_Estado set NomeEstado = @NomeEstado, Sigla = @Sigla where IdEstado = @IdEstado";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.NomeEstado, objeto.SiglaEstado, objeto.IdEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o estado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            string sSqlDelete = "update TB_Estado set Ativo = 0 where IdEstado = @IdEstado";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlDelete, objeto.IdEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o estado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public Dominio.Estado BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Estado where Ativo = 1 and IdEstado = @IdEstado";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.Estado Est = new Dominio.Estado();
                while (reader.Read())
                {
                    Est.IdEstado = id;
                    Est.NomeEstado = (string)reader["NomeEstado"];
                    Est.SiglaEstado = (string)reader["Sigla"];
                }
                return Est;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o estado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Estado> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Estado where Ativo = 1 order by NomeEstado";
            List<Dominio.Estado> listaEst = new List<GerenciadorFinanceiro.Dominio.Estado>();
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                Dominio.Estado Est;
                while (reader.Read())
                {
                    Est = new Dominio.Estado();
                    Est.IdEstado = (int)reader["IdEstado"];
                    Est.NomeEstado = (string)reader["NomeEstado"];
                    Est.SiglaEstado = (string)reader["Sigla"];
                    listaEst.Add(Est);
                    Est = null;
                }
                return listaEst;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os estados.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
