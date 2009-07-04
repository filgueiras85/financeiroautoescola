using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioEstado: IRepositorio<Dominio.Estado>
    {

        #region IRepositorio<Estado> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarObjetoPorId(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarTodos(GerenciadorFinanceiro.Dominio.Estado objeto)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
