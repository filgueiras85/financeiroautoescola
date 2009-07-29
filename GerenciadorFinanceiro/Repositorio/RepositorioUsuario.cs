using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioUsuario: Repositorio.RepositorioBase,  IRepositorio<Dominio.Usuario>
    {

        #region IRepositorio<Usuario> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {
            string sSqlInsert = "insert into TB_Usuario (Nome, Email, Telefone, Celular, Username, Senha)" +
                               " values (@Nome, @Email, @Telefone, @Celular, @Username, @Senha)";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlInsert, objeto.Nome, objeto.Email, objeto.Telefone, objeto.Celular, objeto.UserName, objeto.Senha);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Salvar o Usuário.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {
            string sSqlUpdate = "update TB_Usuario set Nome = @Nome, Email = @Email, Telefone = @Telefone, " +
                                "Celular = @Celular, Username = @Username, Senha = @Senha " +
                                "where IdUsuario = @IdUsuario";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlUpdate, objeto.Nome, objeto.Email, objeto.Telefone, objeto.Celular, 
                             objeto.UserName, objeto.Senha, objeto.IdUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Usuário.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {
            string sSqlDelete = "update TB_Usuario set Ativo = 0 where IdUsuario = @IdUsuario";
            try
            {
                Conection.AbrirConexao();
                Conection.Execute(sSqlDelete, objeto.IdUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o Usuário.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public Dominio.Usuario BuscarObjetoPorId(int id)
        {
            string sSqlSelect = "select * from TB_Usuario where IdUsuario = @IdUsuario";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect, id);
                Dominio.Usuario usuario = new Dominio.Usuario();
                while (reader.Read())
                {
                    usuario.IdUsuario = id;
                    usuario.Nome = (string)reader["Nome"];
                    usuario.Email = (string)reader["Email"];
                    usuario.Telefone = (string)reader["Telefone"];
                    usuario.Celular = (string)reader["Celular"];
                    usuario.UserName = (string)reader["Username"];
                    usuario.Senha = (string)reader["Senha"];
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar o Usuário.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        public List<GerenciadorFinanceiro.Dominio.Usuario> BuscarTodos()
        {
            string sSqlSelect = "select * from TB_Usuario where Ativo = 1 order by Nome";
            List<Dominio.Usuario> ListUsuarios = new List<GerenciadorFinanceiro.Dominio.Usuario>();
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sSqlSelect);
                Dominio.Usuario usuario;
                while (reader.Read())
                {
                    usuario = new Dominio.Usuario();
                    usuario.IdUsuario = (int)reader["IdUsuario"];
                    usuario.Nome = (string)reader["Nome"];
                    usuario.Email = (string)reader["Email"];
                    usuario.Telefone = (string)reader["Telefone"];
                    usuario.Celular = (string)reader["Celular"];
                    usuario.UserName = (string)reader["Username"];
                    usuario.Senha = (string)reader["Senha"];
                    ListUsuarios.Add(usuario);
                    usuario = null;
                }
                return ListUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Buscar todos os Usuários.", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }
        }

        #endregion


        internal GerenciadorFinanceiro.Dominio.Usuario ObterUsuarioPorUsernameAndPassword(string username, string password)
        {
            string sqlConsulta = "select * from TB_Usuario where Ativo = 1 and Username = @Username and Senha = @Senha";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sqlConsulta, username, password);
                Dominio.Usuario usuario = new Dominio.Usuario();
                int flag = 0;
                while (reader.Read())
                {
                    flag = 1;
                    usuario.IdUsuario = (int)reader["IdUsuario"];
                    usuario.Nome = (string)reader["Nome"];
                    usuario.Email = (string)reader["Email"];
                    usuario.Telefone = (string)reader["Telefone"];
                    usuario.Celular = (string)reader["Celular"];
                    usuario.UserName = username;
                    usuario.Senha = password;
                }
                if (flag == 1)
                    return usuario;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel verificar o Usuario e Senha! Tente novamente!", ex);
            }
            finally
            {
                Conection.FecharConexao();
            }

        }
            internal GerenciadorFinanceiro.Dominio.Usuario ObterUsuarioPorEmail(string email)
        {
            string sqlConsulta = "select * from TB_Usuario where Ativo = 1 and Email = @Email";
            try
            {
                Conection.AbrirConexao();
                var reader = Conection.ExecuteReader(sqlConsulta, email);                
                Dominio.Usuario usuario = new Dominio.Usuario();
                int flag = 0;
                while (reader.Read())
                {
                    flag = 1;
                    usuario.IdUsuario = (int)reader["IdUsuario"];
                    usuario.Nome  = (string)reader["Nome"];
                    usuario.Email  = (string)reader["Email"];
                    usuario.Telefone = (string)reader["Telefone"];
                    usuario.Celular = (string)reader["Celular"];
                    usuario.UserName = (string)reader["Username"]; ;
                    usuario.Senha = (string)reader["Senha"]; ;                        
                }
                if (flag ==1)
                    return usuario;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel verificar o Usuario ! Tente novamente!", ex);
            }
            finally {
                Conection.FecharConexao();
            } 
        }
    }
}
