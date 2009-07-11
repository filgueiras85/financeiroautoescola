using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioServico: IRepositorio<Dominio.Servico>
    {
        #region IRepositorio<Servico> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Servico objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Servico> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
