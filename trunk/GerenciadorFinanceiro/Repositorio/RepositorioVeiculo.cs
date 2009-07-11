using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioVeiculo: IRepositorio<Dominio.Veiculo>
    {
        #region IRepositorio<Veiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Veiculo objeto)
        {
            throw new NotImplementedException();
        }

        public Dominio.Veiculo BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Veiculo> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
