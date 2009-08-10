using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioBanco: RepositorioBase, IRepositorio<Dominio.Banco>
    {
        #region IRepositorio<Banco> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Banco objeto)
        {
            string sSqlInsert = "insert into TB_Banco (CodigoBanco, Descricao) " +
                                "values (@CodigoBanco, @Descricao)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.CodigoBanco, objeto.Descricao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Salvar o Banco.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Banco objeto)
        {
            string sSqlUpdate = "Update TB_Banco set CodigoBanco = @CodigoBanco, Descricao = @Descricao where IdBanco = @IdBanco";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.CodigoBanco, objeto.Descricao, objeto.IdBanco);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Banco.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Banco objeto)
        {
            string sSqlDelete = "Update TB_Banco set Ativo = 0 where IdBanco = @IdBanco";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlDelete, objeto.IdBanco);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir o Banco.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.Banco BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Banco where IdBanco = @id";
            Dominio.Banco banco = new Dominio.Banco();
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                while (reader.Read())
                {
                    banco.IdBanco = (int)reader["IdBanco"]; ;
                    banco.CodigoBanco = (String)reader["CodigoBanco"];
                    banco.Descricao = (String)reader["Descricao"];
                }
                return banco;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o banco.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Banco> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Banco where Ativo = 1 order by Descricao";
            List<Dominio.Banco> ListBanco = new List<GerenciadorFinanceiro.Dominio.Banco>();
            Dominio.Banco banco;
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
               
                while (reader.Read())
                {
                    banco = new Dominio.Banco();
                    banco.IdBanco = (int)reader["IdBanco"]; ;
                    banco.CodigoBanco = (String)reader["CodigoBanco"];
                    banco.Descricao = (String)reader["Descricao"];
                    ListBanco.Add(banco);
                    banco = null;
                }
                return ListBanco;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Bancos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
