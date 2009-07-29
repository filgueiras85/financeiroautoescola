using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioTipoServico :RepositorioBase,  IRepositorio<Dominio.TipoServico>
    {
        #region IRepositorio<TipoServico> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.TipoServico objeto)
        {
            string sqlInsert = "insert into TB_TipoServico (Descricao) values (@descricao)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sqlInsert, objeto.Descricao);
                objeto.IdTipoServico = Convert.ToInt32(Conection.ExecuteScalar("Select @@Identity"));
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o Tipo de serviço solicitado.", ex);                
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.TipoServico objeto)
        {
            string sqlUpdate = "Update TB_TipoServico  set Descricao = @descricao where IdTipoServico = @id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sqlUpdate, objeto.Descricao, objeto.IdTipoServico);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Tipo de serviço solicitado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.TipoServico objeto)
        {
            string sqlDelete = "Update TB_TipoServico set Ativo = 0 where IdTipoServico = @id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sqlDelete, objeto.IdTipoServico);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Tipo de serviço solicitado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.TipoServico BuscarObjetoPorId(int id)
        {
            string sqlSelect = "select * from TB_TipoServico where IdTipoServico = @id";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sqlSelect, id);
                Dominio.TipoServico tipoServico = new GerenciadorFinanceiro.Dominio.TipoServico();
                while (reader.Read())
                {
                    tipoServico.IdTipoServico = (int)reader["IdTipoServico"];
                    tipoServico.Descricao = (string)reader["Descricao"];
                }
                return tipoServico;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Tipo de serviço solicitado.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.TipoServico> BuscarTodos()
        {
            string sqlSelect = "select * from TB_TipoServico where Ativo = 1 order by Descricao";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sqlSelect);
                List<Dominio.TipoServico> lista = new List<GerenciadorFinanceiro.Dominio.TipoServico>();
                while (reader.Read())
                {
                    Dominio.TipoServico tipoServico = new GerenciadorFinanceiro.Dominio.TipoServico();
                    tipoServico.IdTipoServico = (int)reader["IdTipoServico"];
                    tipoServico.Descricao = (string)reader["Descricao"];
                    lista.Add(tipoServico);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Tipos de serviços.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
