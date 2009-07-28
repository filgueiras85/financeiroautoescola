using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioTipoVeiculo:Repositorio.RepositorioBase, IRepositorio<Dominio.TipoVeiculo>
    {
        #region IRepositorio<TipoVeiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.TipoVeiculo objeto)
        {
            string sSqlInsert = "insert into TB_Tipo_Veiculo (Descricao) values (@Descricao)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Descricao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o Tipo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.TipoVeiculo objeto)
        {
            string sSqlUpdate = "update TB_Tipo_Veiculo set Descricao = @Descricao where IdTipoVeiculo = @IdTipoVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.Descricao, objeto.IdTipoVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Tipo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.TipoVeiculo objeto)
        {
            string sSqlDelete = "update TB_Tipo_Veiculo set Ativo = 0 where IdTipoVeiculo = @IdTipoVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdTipoVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Tipo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Dominio.TipoVeiculo BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Tipo_Veiculo where IdTipoVeiculo = @IdTipoVeiculo";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.TipoVeiculo tipoVeiculo = new Dominio.TipoVeiculo();
                while (reader.Read())
                {
                    tipoVeiculo.IdTipoVeiculo = id;
                    tipoVeiculo.Descricao = (string)reader["Descricao"];
                }
                return tipoVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Tipo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.TipoVeiculo> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Tipo_Veiculo where Ativo = 1 order by Descricao";
            List<Dominio.TipoVeiculo> listaTipoVeiculo = new List<GerenciadorFinanceiro.Dominio.TipoVeiculo>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.TipoVeiculo tipoVeiculo;
                while (reader.Read())
                {
                    tipoVeiculo = new Dominio.TipoVeiculo();
                    tipoVeiculo.IdTipoVeiculo = (int)reader["IdTipoVeiculo"];
                    tipoVeiculo.Descricao = (string)reader["Descricao"];
                    listaTipoVeiculo.Add(tipoVeiculo);
                    tipoVeiculo = null;
                }
                return listaTipoVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Tipos de Veículos.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
