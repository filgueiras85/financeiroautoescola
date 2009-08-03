using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioDespesa: RepositorioBase, IRepositorio<Dominio.Despesa>
    {

        #region IRepositorio<Despesa> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.Despesa BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Despesa> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
