using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioFabricanteVeiculo: RepositorioBase, IRepositorio<Dominio.FabricanteVeiculo>
    {
        #region IRepositorio<FabricanteVeiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            string sSqlInsert = "insert into TB_Fabricante_Veiculo (Descricao) values (@Descricao)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.Descricao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o fabricante de Veiculo.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            string sSqlUpdate = "update TB_Fabricante_Veiculo set Descricao = @Descricao where IdFabricanteVeiculo = @IdFabricanteVeiculo";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.Descricao, objeto.IdFabricanteVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o fabricante de veiculo.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            string sSqlDelete = "update TB_Fabricante_Veiculo set Ativo = 0 where IdFabricanteVeiculo = @IdFabricanteVeiculo";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlDelete, objeto.IdFabricanteVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o fabricante.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public Dominio.FabricanteVeiculo BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Fabricante_Veiculo where IdFabricanteVeiculo = @IdFabricanteVeiculo";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.FabricanteVeiculo fabVeiculo = new Dominio.FabricanteVeiculo();
                while (reader.Read())
                {
                    fabVeiculo.IdFabricanteVeiculo = id;
                    fabVeiculo.Descricao = (string)reader["Descricao"];
                }
                return fabVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o fabricante.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Fabricante_Veiculo where Ativo = 1 order by Descricao";
            List<Dominio.FabricanteVeiculo> listaFabVeiculo = new List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo>();
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                Dominio.FabricanteVeiculo fabVeiculo;
                while (reader.Read())
                {
                    fabVeiculo = new Dominio.FabricanteVeiculo();
                    fabVeiculo.IdFabricanteVeiculo = (int)reader["IdFabricanteVeiculo"];
                    fabVeiculo.Descricao = (string)reader["Descricao"];
                    listaFabVeiculo.Add(fabVeiculo);
                    fabVeiculo = null;
                }
                return listaFabVeiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Fabricantes de Veículos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
