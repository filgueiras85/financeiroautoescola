﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioVeiculo: Repositorio.RepositorioBase, IRepositorio<Dominio.Veiculo>
    {
        #region IRepositorio<Veiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            string sSqlInsert = "insert into TB_Veiculo (Placa, Renavam, Chassi, Ano, Modelo, Cor, Observacao, IdTipoVeiculo, IdModeloVeiculo)" +
                                " values (@Placa, @Renavam, @Chassi, @Ano, @Modelo, @Cor, @Observacao, @IdTipoVeiculo, @IdModeloVeiculo)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Placa, objeto.Renavam, objeto.Chassi, objeto.Ano, objeto.Modelo, objeto.Cor, objeto.TipoVeiculo.IdTipoVeiculo, objeto.ModeloVeiculo.IdModeloVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            string sSqlUpdate = "update TB_Veiculo set Placa = @Placa, Renavam = @Renavam, Chassi = @Chassi, " +
                                "Ano = @Ano, Modelo = @Modelo, Cor = @Cor, Observacao = @Observacao, IdTipoVeiculo = @IdTipoVeiculo " + 
                                "IdModeloVeiculo = @IdModeloVeiculo where IdVeiculo = @IdVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.Placa, objeto.Renavam, objeto.Chassi, objeto.Ano, objeto.Modelo, objeto.Cor, objeto.Observacao, objeto.TipoVeiculo.IdTipoVeiculo, objeto.ModeloVeiculo.IdModeloVeiculo, objeto.IdVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            string sSqlDelete = "delete from TB_Veiculo where IdVeiculo = @IdVeiculo";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Veículo.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Dominio.Veiculo BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Veiculo where IdVeiculo = @IdVeiculo";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.Veiculo veiculo = new Dominio.Veiculo();
                while (reader.Read())
                {
                    veiculo.IdVeiculo = id;
                    veiculo.Placa = (string)reader["Placa"];
                    veiculo.Renavam = (string)reader["Renavam"];
                    veiculo.Chassi = (string)reader["Chassi"];
                    veiculo.Ano = (int)reader["Ano"];
                    veiculo.Modelo = (int)reader["Modelo"];
                    veiculo.Cor = (string)reader["Cor"];
                    veiculo.Observacao = (string)reader["Observacao"];
                    veiculo.TipoVeiculo = new Repositorio.RepositorioTipoVeiculo().BuscarObjetoPorId((int)reader["IdTipoVeiculo"]);
                    veiculo.ModeloVeiculo = new RepositorioModeloVeiculo().BuscarObjetoPorId((int)reader["IdModeloVeiculo"]);
                }
                return veiculo;
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

        public List<GerenciadorFinanceiro.Dominio.Veiculo> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Veiculo";
            List<Dominio.Veiculo> listVeiculos = new List<GerenciadorFinanceiro.Dominio.Veiculo>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.Veiculo veiculo;
                while (reader.Read())
                {
                    veiculo = new Dominio.Veiculo();
                    veiculo.IdVeiculo = (int)reader["IdVeiculo"];
                    veiculo.Placa = (string)reader["Placa"];
                    veiculo.Renavam = (string)reader["Renavam"];
                    veiculo.Chassi = (string)reader["Chassi"];
                    veiculo.Ano = (int)reader["Ano"];
                    veiculo.Modelo = (int)reader["Modelo"];
                    veiculo.Cor = (string)reader["Cor"];
                    veiculo.Observacao = (string)reader["Observacao"];
                    veiculo.TipoVeiculo = new Repositorio.RepositorioTipoVeiculo().BuscarObjetoPorId((int)reader["IdTipoVeiculo"]);
                    veiculo.ModeloVeiculo = new RepositorioModeloVeiculo().BuscarObjetoPorId((int)reader["IdModeloVeiculo"]);
                    listVeiculos.Add(veiculo);
                    veiculo = null;
                }
                return listVeiculos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Veículos.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
