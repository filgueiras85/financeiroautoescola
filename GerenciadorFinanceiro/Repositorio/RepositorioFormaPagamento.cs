using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioFormaPagamento : RepositorioBase , IRepositorio<Dominio.FormaPagamento>
    {

        #region IRepositorio<FormaPagamento> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.FormaPagamento objeto)
        {
            string sSqlInsert = "insert into TB_Forma_Pagamento (Descricao, QuantidadeParcelas) values (@descr, @qnt)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.Descricao, objeto.QuantidadeParcela);
                objeto.Id = (int)Conection.ExecuteScalar("Select @@identity");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir a Forma de pagamento solicitada.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.FormaPagamento objeto)
        {
            string sSqlUpdate = "update TB_Forma_Pagamento set Descricao = @Descricao , QuantidadeParcelas = @qnt where IdFormaPagamento = @Id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.Descricao, objeto.QuantidadeParcela, objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar a Forma de pagamento solicitada.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.FormaPagamento objeto)
        {
            string sSqlUpdate = "update TB_Forma_Pagamento set Ativo = 0 where IdFormaPagamento = @id";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate,  objeto.Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir a Forma de pagamento solicitada.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.FormaPagamento BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Forma_Pagamento where IdFormaPagamento = @Id";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.FormaPagamento pagamento = new GerenciadorFinanceiro.Dominio.FormaPagamento();
                while (reader.Read())
                {
                    pagamento.Id = (int)reader["IdFormaPagamento"];
                    pagamento.Descricao = (string)reader["Descricao"];
                    pagamento.QuantidadeParcela = (int)reader["QuantidadeParcelas"];
                }
                return pagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar a Forma de pagamento solicitada.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.FormaPagamento> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Forma_Pagamento where Ativo = 1";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                List<Dominio.FormaPagamento> lista = new List<GerenciadorFinanceiro.Dominio.FormaPagamento>();
                while (reader.Read())
                {
                    Dominio.FormaPagamento pagamento = new GerenciadorFinanceiro.Dominio.FormaPagamento();
                    pagamento.Id = (int)reader["IdFormaPagamento"];
                    pagamento.Descricao = (string)reader["Descricao"];
                    pagamento.QuantidadeParcela = (int)reader["QuantidadeParcelas"];
                    lista.Add(pagamento);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar as Formas de pagamento solicitadas.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion

    }
}
