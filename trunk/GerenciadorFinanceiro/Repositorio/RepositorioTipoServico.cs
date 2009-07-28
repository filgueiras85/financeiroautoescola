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
                this.AbrirConexao();
                this.Execute(sqlInsert, objeto.Descricao);
                objeto.IdTipoServico = (int)this.ExecuteScalar("Select @@Identity");

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o Tipo de serviço solicitado.", ex);                
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.TipoServico objeto)
        {
            string sqlUpdate = "Update TB_TipoServico  set Descricao = @descricao where IdTipoServico = @id";
            try
            {
                this.AbrirConexao();
                this.Execute(sqlUpdate, objeto.Descricao, objeto.IdTipoServico );
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Tipo de serviço solicitado.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.TipoServico objeto)
        {
            string sqlDelete = "Update TB_TipoServico set Ativo = 0 where IdTipoServico = @id";
            try
            {
                this.AbrirConexao();
                this.Execute(sqlDelete, objeto.IdTipoServico);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Tipo de serviço solicitado.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.TipoServico BuscarObjetoPorId(int id)
        {
            string sqlSelect = "select * from TB_TipoServico where IdTipoServico = @id";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sqlSelect, id);
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
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.TipoServico> BuscarTodos()
        {
            string sqlSelect = "select * from TB_TipoServico where Ativo = 1 order by Descricao";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sqlSelect);
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
                this.FecharConexao();
            }
        }

        #endregion
    }
}
