using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioDespesaParcela: RepositorioBase, IRepositorio<Dominio.DespesaParcela>
    {

        #region IRepositorio<DespesaParcela> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.DespesaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.DespesaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.DespesaParcela objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.DespesaParcela BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.DespesaParcela> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
