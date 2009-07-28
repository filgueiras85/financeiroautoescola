using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioCidade: Repositorio.RepositorioBase, IRepositorio<Dominio.Cidade>
    {
        #region IRepositorio<Cidade> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            string sSqlInsert = "insert into TB_Cidade (NomeCidade, IdEstado) values (@NomeCidade, @IdEstado)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.NomeCidade, objeto.Estado.IdEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir a cidade.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            string sSqlUpdate = "update TB_Cidade set NomeCidade = @NomeCidade, IdEstado = @IdEstado where IdCidade = @IdCidade";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.NomeCidade, objeto.Estado.IdEstado, objeto.IdCidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar a cidade.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            string sSqlDelete = "Update TB_Cidade set Ativo = 0 where IdCidade = @IdCidade";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdCidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar a cidade.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Dominio.Cidade BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Cidade where IdCidade = @IdCidade";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.Cidade Cid = new Dominio.Cidade();
                while (reader.Read())
                {
                    Cid.IdCidade = id;
                    Cid.NomeCidade = (string)reader["NomeCidade"];
                    Cid.Estado = new RepositorioEstado().BuscarObjetoPorId((int)reader["IdEstado"]);
                }
                return Cid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar a Cidade.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Cidade> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Cidade where Ativo = 1 order by NomeCidade";
            List<Dominio.Cidade> listaCid = new List<GerenciadorFinanceiro.Dominio.Cidade>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.Cidade Cid;
                RepositorioEstado repEstado = new RepositorioEstado();
                while (reader.Read())
                {
                    Cid = new Dominio.Cidade();
                    Cid.IdCidade = (int)reader["IdCidade"];
                    Cid.NomeCidade  = (string)reader["NomeCidade"];
                    Cid.Estado = repEstado.BuscarObjetoPorId((int)reader["IdEstado"]);
                    listaCid.Add(Cid);
                    Cid = null;
                }
                return listaCid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todas as Cidades.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<Dominio.Cidade> BuscarCidadesPorEstado(Dominio.Estado estado)
        {
            string sSqlSelect = "select * from TB_Cidade where Ativo = 1 and IdEstado = @IdEstado";
            List<Dominio.Cidade> listaCid = new List<GerenciadorFinanceiro.Dominio.Cidade>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, estado.IdEstado);
                Dominio.Cidade Cid;
                while (reader.Read())
                {
                    Cid = new Dominio.Cidade();
                    Cid.IdCidade = (int)reader["IdCidade"];
                    Cid.NomeCidade = (string)reader["NomeCidade"];
                    Cid.Estado = estado;
                    listaCid.Add(Cid);
                    Cid = null;
                }
                return listaCid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar todas as Cidades do estado.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
