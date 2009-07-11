using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioCidade: IRepositorio<Dominio.Cidade>
    {
        #region IRepositorio<Cidade> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Cidade objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Cidade> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
