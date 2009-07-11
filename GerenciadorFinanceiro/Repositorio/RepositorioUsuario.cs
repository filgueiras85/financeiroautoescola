using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioUsuario: IRepositorio<Dominio.Usuario>
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

        public void BuscarObjetoPorId(int id)
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
            throw new NotImplementedException();
        }
    }
}
