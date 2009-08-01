using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioReceita: RepositorioBase, IRepositorio<Dominio.Receita>
    {
        #region IRepositorio<Receita> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Receita objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Receita objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Receita objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.Receita BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Receita> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
