using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioModeloVeiculo: Repositorio.RepositorioBase, IRepositorio<Dominio.ModeloVeiculo>
    {

        #region IRepositorio<ModeloVeiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            string sSqlInsert = "insert into TB_Modelo_Veiculo (Descricao, IdFabricanteVeiculo) values (@Descricao, @IdFabricante)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Descricao, objeto.Fabricante.IdFabricanteVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o Modelo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            string sSqlUpdate = "update TB_Modelo_Veiculo set Descricao = @Descricao, IdFabricanteVeiculo = @IdFabricante where IdModeloVeiculo = @IdModeloVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.Descricao, objeto.Fabricante.IdFabricanteVeiculo, objeto.IdModeloVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Modelo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            string sSqlDelete = "delete from TB_Modelo_Veiculo where IdModeloVeiculo = @IdModeloVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdModeloVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Modelo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.ModeloVeiculo BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Modelo_Veiculo where IdModeloVeiculo = @IdModeloVeiculo";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.ModeloVeiculo modeloVeiculo = new Dominio.ModeloVeiculo();
                while (reader.Read())
                {
                    modeloVeiculo.IdModeloVeiculo = id;
                    modeloVeiculo.Descricao = (string)reader["Descricao"];
                    modeloVeiculo.Fabricante = new Repositorio.RepositorioFabricanteVeiculo().BuscarObjetoPorId((int)reader["IdFabricanteVeiculo"]);
                }
                return modeloVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Modelo de Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.ModeloVeiculo> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Modelo_Veiculo order by Descricao";
            List<Dominio.ModeloVeiculo> listaModeloVeiculo = new List<GerenciadorFinanceiro.Dominio.ModeloVeiculo>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.ModeloVeiculo modeloVeiculo;
                while (reader.Read())
                {
                    modeloVeiculo = new Dominio.ModeloVeiculo();
                    modeloVeiculo.IdModeloVeiculo = (int)reader["IdModeloVeiculo"];
                    modeloVeiculo.Descricao = (string)reader["Descricao"];
                    modeloVeiculo.Fabricante = new Repositorio.RepositorioFabricanteVeiculo().BuscarObjetoPorId((int)reader["IdFabricanteVeiculo"]);
                    listaModeloVeiculo.Add(modeloVeiculo);
                    modeloVeiculo = null;
                }
                return listaModeloVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Modelos de Veículos.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
