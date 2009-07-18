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
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.Instrutor BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Instrutor> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Instrutor";
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
                    instrutor.CPF  = (string)reader["CPF"];
                    Dominio.Endereco endereco = new Dominio.Endereco();
                    endereco.Cidade = new Repositorio.RepositorioCidade().BuscarObjetoPorId((int)reader["IdCidade"]);
                    endereco.Bairro = (string)reader["Bairro"];
                    endereco.CEP = (string)reader["CEP"];
                    endereco.Complemento = (string)reader["Complemento"];
                    endereco.Numero = (int)reader["Numero"];
                    endereco.Rua = (string)reader["Rua"];
                    instrutor.Endereco = endereco;
                    instrutor.Nome = (string)reader["Nome"];
                    instrutor.RG  = (string)reader["RG"];
                    instrutor.TelefoneCelular = (string)reader["TelefoneCelular"];
                    instrutor.TelefoneResidencial  = (string)reader["TelefoneResidencial"];                    
                    listaInstrutor.Add(instrutor);
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
