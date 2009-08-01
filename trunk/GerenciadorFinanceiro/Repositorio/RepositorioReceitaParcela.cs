using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioReceitaParcela: RepositorioBase, IRepositorio<Dominio.ReceitaParcela>
    {
        #region IRepositorio<ReceitaParcela> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.ReceitaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.ReceitaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.ReceitaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.ReceitaParcela BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.ReceitaParcela> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
