using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioServico: RepositorioBase, IRepositorio<Dominio.Servico>
    {
        #region IRepositorio<Servico> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            string sSqlInsert = "insert into TB_Servico (Descricao, Valor, Observacao)" +
                                " values (@Descricao, @Valor, @Observacao)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Descricao, objeto.Valor, objeto.Observacao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o serviço.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            string sSqlUpdate = "update TB_Servico set Descricao = @Descricao, Valor = @Valor, " +
                                "Observacao = @Observacao where IdServico = @IdServico";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.Descricao, objeto.Valor, objeto.Observacao, objeto.IdServico);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o serviço.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            string sSqlDelete = "update TB_Servico set Ativo = 0 where IdServico = @IdServico";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdServico);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Serviço.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Dominio.Servico BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Servico where IdServico = @IdServico";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.Servico servico = new Dominio.Servico();
                while (reader.Read())
                {
                    servico.IdServico = id;
                    servico.Descricao = (string)reader["Descricao"];
                    servico.Valor = (double)reader["Valor"];
                    servico.Observacao = (string)reader["Observacao"];
                }
                return servico;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Servico> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Servico where Ativo = 1 order by Descricao";
            List<Dominio.Servico> ListServicos = new List<GerenciadorFinanceiro.Dominio.Servico>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.Servico servico;
                while (reader.Read())
                {
                    servico = new Dominio.Servico();
                    servico.IdServico = (int)reader["IdServico"];
                    servico.Descricao = (string)reader["Descricao"];
                    servico.Valor = (double)reader["Valor"];
                    servico.Observacao = (string)reader["Observacao"];
                    ListServicos.Add(servico);
                    servico = null;
                }
                return ListServicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Serviços.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
