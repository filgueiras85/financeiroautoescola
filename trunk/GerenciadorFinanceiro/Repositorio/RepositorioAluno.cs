using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioAluno: RepositorioBase, IRepositorio<Dominio.Aluno>
    {

        #region IRepositorio<Aluno> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {
            string sSqlInsert = "insert into TB_Aluno (Nome, CPF_CNPJ, RG_InscricaoEstadual, TelefoneResidencial, " +
                                "TelefoneComercial, TelefoneCelular, DataNascimento, Rua, Numero, Complemento, " +
                                "Bairro, CEP, IdCidade, SSP, NomePai, NomeMae, Referencia, Observacao) " +
                                "values (@Nome, @CPF_CNPJ, @RG_InscricaoEstadual, @TelefoneResidencial, @TelefoneComercial, " +
                                "@TelefoneCelular, @DataNascimento, @Rua, @Numero, @Complemento, @Bairro, @CEP, @IdCidade, " +
                                "@SSP, @NomePai, @NomeMae, @Referencia, @Observacao)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.NomeAluno, objeto.CPF_CNPJ, objeto.RG_InscEstadual, objeto.TelefoneResidencial,
                            objeto.TelefoneComercial, objeto.TelefoneCelular, objeto.DataNascimento, objeto.Endereco.Rua,
                            objeto.Endereco.Numero, objeto.Endereco.Complemento, objeto.Endereco.Bairro, objeto.Endereco.CEP,
                            objeto.Endereco.Cidade.IdCidade, objeto.SSP, objeto.NomePai, objeto.NomeMae, objeto.Referencia, objeto.Observacao);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Salvar o Aluno.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {
            string sSqlUpdate = "update TB_Aluno set Nome = @Nome, CPF_CNPJ = @CPF_CNPJ, RG_InscricaoEstadual = @RG_InscricaoEstadual, " +
                                "TelefoneResidencial = @TelefoneResidencial, TelefoneComercial = @TelefoneComercial, TelefoneCelular = " +
                                "@TelefoneCelular, DataNascimento = @DataNascimento, Rua = @Rua, Numero = @Numero, Complemento = @Complemento, " +
                                "Bairro = @Bairro, CEP = @CEP, IdCidade = @IdCidade, SSP = @SSP, NomePai = @NomePai, NomeMae = @NomeMae, " +
                                "Referencia = @Referencia, Observacao = @Observacao where IdAluno = @IdAluno)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.NomeAluno, objeto.CPF_CNPJ, objeto.RG_InscEstadual, objeto.TelefoneResidencial,
                            objeto.TelefoneComercial, objeto.TelefoneCelular, objeto.DataNascimento, objeto.Endereco.Rua,
                            objeto.Endereco.Numero, objeto.Endereco.Complemento, objeto.Endereco.Bairro, objeto.Endereco.CEP,
                            objeto.Endereco.Cidade.IdCidade, objeto.SSP, objeto.NomePai, objeto.NomeMae, objeto.Referencia, 
                            objeto.Observacao, objeto.IdAluno);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Atualizar o Aluno.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {
            string sSqlDelete = "Update TB_Aluno set Ativo = 0 where IdAluno = @IdAluno";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlDelete, objeto.IdAluno);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir o Aluno.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public Dominio.Aluno BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Aluno where IdAluno = @IdAluno";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.Aluno aluno = new Dominio.Aluno();
                Dominio.Endereco endereco = new Dominio.Endereco();
                while (reader.Read())
                {
                    aluno.IdAluno = id;
                    aluno.NomeAluno = (string)reader["Nome"];
                    aluno.CPF_CNPJ = (string)reader["CPF_CNPJ"];
                    aluno.RG_InscEstadual = (string)reader["RG_InscEstadual"];
                    aluno.TelefoneResidencial = (string)reader["TelefoneResidencial"];
                    aluno.TelefoneComercial = (string)reader["TelefoneComercial"];
                    aluno.TelefoneCelular = (string)reader["TelefoneCelular"];
                    aluno.DataNascimento = (DateTime)reader["DataNascimento"];
                    endereco.Rua = (string)reader["Rua"];
                    endereco.Numero = (int)reader["Numero"];
                    endereco.Complemento = (string)reader["Complemento"];
                    endereco.Bairro = (string)reader["Bairro"];
                    endereco.CEP = (string)reader["CEP"];
                    endereco.Cidade = new RepositorioCidade().BuscarObjetoPorId((int)reader["IdCidade"]);
                    aluno.Endereco = endereco;
                    aluno.SSP = (string)reader["SSP"];
                    aluno.NomePai = (string)reader["NomePai"];
                    aluno.NomeMae = (string)reader["NomeMae"];
                    aluno.Referencia = (string)reader["Referencia"];
                    aluno.Observacao = (string)reader["Observacao"];
                }
                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Aluno.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Aluno> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Aluno where Ativo = 1 order by Nome";
            List<Dominio.Aluno> listAlunos = new List<GerenciadorFinanceiro.Dominio.Aluno>();
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                Dominio.Aluno aluno;
                Dominio.Endereco endereco;
                while (reader.Read())
                {
                    aluno = new Dominio.Aluno();
                    aluno.IdAluno = (int)reader["IdAluno"]; ;
                    aluno.NomeAluno = (string)reader["Nome"];
                    aluno.CPF_CNPJ = (string)reader["CPF_CNPJ"];
                    aluno.RG_InscEstadual = (string)reader["RG_InscEstadual"];
                    aluno.TelefoneResidencial = (string)reader["TelefoneResidencial"];
                    aluno.TelefoneComercial = (string)reader["TelefoneComercial"];
                    aluno.TelefoneCelular = (string)reader["TelefoneCelular"];
                    aluno.DataNascimento = (DateTime)reader["DataNascimento"];
                    endereco = new Dominio.Endereco();
                    endereco.Rua = (string)reader["Rua"];
                    endereco.Numero = (int)reader["Numero"];
                    endereco.Complemento = (string)reader["Complemento"];
                    endereco.Bairro = (string)reader["Bairro"];
                    endereco.CEP = (string)reader["CEP"];
                    endereco.Cidade = new RepositorioCidade().BuscarObjetoPorId((int)reader["IdCidade"]);
                    aluno.Endereco = endereco;
                    endereco = null;
                    aluno.SSP = (string)reader["SSP"];
                    aluno.NomePai = (string)reader["NomePai"];
                    aluno.NomeMae = (string)reader["NomeMae"];
                    aluno.Referencia = (string)reader["Referencia"];
                    aluno.Observacao = (string)reader["Observacao"];
                    listAlunos.Add(aluno);
                    aluno = null;
                }
                return listAlunos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Alunos.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion
    }
}
