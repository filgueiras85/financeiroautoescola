using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioUsuario: Repositorio.RepositorioBase ,  IRepositorio<Dominio.Usuario>
    {

        #region IRepositorio<Usuario> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {            
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public Dominio.Usuario BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion

        
        internal GerenciadorFinanceiro.Dominio.Usuario ObterUsuarioPorUsernameAndPassword(string username, string password)
        {
            string sqlConsulta = "select * from TB_Usuario where Username = @Username and Senha = @Senha";
            try
            {
                this.AbrirConexao();
                var reader = this.ExecuteReader(sqlConsulta, username, password );                
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
                    usuario.UserName = username;
                    usuario.Senha = password;                        
                }
                if (flag ==1)
                    return usuario;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel verificar o Usuario e Senha! Tente novamente!", ex);
            }
            finally {
                this.FecharConexao();
            }          
        }
    }
}
