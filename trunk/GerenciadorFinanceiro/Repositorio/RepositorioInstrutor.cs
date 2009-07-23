using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioInstrutor : Repositorio.RepositorioBase, IRepositorio<Dominio.Instrutor>
    {

        #region IRepositorio<Instrutor> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            string sSqlInsert = "insert into TB_Instrutor (Nome, TelefoneResidencial, TelefoneCelular, RG, " +
                                "CPF, Rua, Numero, Complemento, Bairro, CEP, IdCidade, PathFoto, Observacao) " +
                                "values (@Nome, @TelefoneResidencial, @TelefoneCelular, @RG, @CPF, " +
                                "@Rua, @Numero, @Complemento, @Bairro, @CEP, @IdCidade, @PathFoto, @Observacao)";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlInsert, objeto.Nome, objeto.TelefoneResidencial, objeto.TelefoneCelular,
                             objeto.RG, objeto.CPF, objeto.Endereco.Rua, objeto.Endereco.Numero, 
                             objeto.Endereco.Complemento, objeto.Endereco.Bairro, objeto.Endereco.CEP,
                             objeto.Endereco.Cidade.IdCidade, objeto.PathFoto, objeto.Observacao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Salvar o Instrutor.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            string sSqlUpdate = "update TB_Instrutor set Nome = @Nome, TelefoneResidencial = @TelefoneResidencial, " + 
                                "TelefoneCelular = @TelefoneCelular, RG = @RG, CPF = @CPF, Rua = @Rua, Numero = @Numero, " + 
                                "Complemento = @Complemento, Bairro = @Bairro, CEP = @CEP, IdCidade = @IdCidade, " +
                                "Observacao = @Observacao, PathFoto = @PathFoto where IdInstrutor = @IdInstrutor";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlUpdate, objeto.Nome, objeto.TelefoneResidencial, objeto.TelefoneCelular, objeto.RG,
                            objeto.CPF, objeto.Endereco.Rua, objeto.Endereco.Numero, objeto.Endereco.Complemento, 
                            objeto.Endereco.Bairro, objeto.Endereco.CEP, objeto.Endereco.Cidade.IdCidade,
                            objeto.Observacao, objeto.PathFoto, objeto.IdInstrutor);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Atualizar o Instrutor.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            string sSqlDelete = "delete from TB_Instrutor where IdInstrutor = @IdInstrutor";
            try
            {
                this.AbrirConexao();
                this.Execute(sSqlDelete, objeto.IdInstrutor);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir o Instrutor.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public GerenciadorFinanceiro.Dominio.Instrutor BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Instrutor where IdInstrutor = @IdInstrutor";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect, id);
                Dominio.Instrutor instrutor = new Dominio.Instrutor();
                while (reader.Read())
                {
                    instrutor.IdInstrutor = id;
                    instrutor.Nome = (string)reader["Nome"];
                    instrutor.TelefoneResidencial = (string)reader["TelefoneResidencial"];
                    instrutor.TelefoneCelular = (string)reader["TelefoneCelular"];
                    instrutor.RG = (string)reader["RG"];
                    instrutor.CPF = (string)reader["CPF"];
                    Dominio.Endereco endereco = new Dominio.Endereco();
                    endereco.Rua = (string)reader["Rua"];
                    endereco.Numero = (int)reader["Numero"];
                    endereco.Complemento = (string)reader["Complemento"];
                    endereco.Bairro = (string)reader["Bairro"];
                    endereco.CEP = (string)reader["CEP"];
                    instrutor.PathFoto = (string)reader["PathFoto"];
                    instrutor.Observacao = (string)reader["Observacao"];
                    endereco.Cidade = new Repositorio.RepositorioCidade().BuscarObjetoPorId((int)reader["IdCidade"]);
                    instrutor.Endereco = endereco;
                    endereco = null;
                }
                return instrutor;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o instrutor.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Instrutor> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Instrutor order by Nome";
            List<Dominio.Instrutor> listaInstrutor = new List<GerenciadorFinanceiro.Dominio.Instrutor>();
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sSqlSelect);
                Dominio.Instrutor instrutor;                
                while (reader.Read())
                {
                    instrutor = new Dominio.Instrutor();
                    instrutor.IdInstrutor  = (int)reader["IdInstrutor"];
                    instrutor.Nome = (string)reader["Nome"];
                    instrutor.TelefoneResidencial = (string)reader["TelefoneResidencial"];
                    instrutor.TelefoneCelular = (string)reader["TelefoneCelular"];
                    instrutor.RG = (string)reader["RG"];
                    instrutor.CPF  = (string)reader["CPF"];
                    Dominio.Endereco endereco = new Dominio.Endereco();
                    endereco.Rua = (string)reader["Rua"];
                    endereco.Numero = (int)reader["Numero"];
                    endereco.Complemento = (string)reader["Complemento"];
                    endereco.Bairro = (string)reader["Bairro"];
                    endereco.CEP = (string)reader["CEP"];
                    endereco.Cidade = new Repositorio.RepositorioCidade().BuscarObjetoPorId((int)reader["IdCidade"]);
                    instrutor.Endereco = endereco;
                    instrutor.PathFoto = (string)reader["PathFoto"];
                    instrutor.Observacao = (string)reader["Observacao"];
                    endereco = null;    
                    listaInstrutor.Add(instrutor);
                    instrutor = null;
                }
                return listaInstrutor;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os instrutores.", ex);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        #endregion
    }
}
