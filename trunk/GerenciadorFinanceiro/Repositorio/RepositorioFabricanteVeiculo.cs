using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioFabricanteVeiculo: IRepositorio<Dominio.FabricanteVeiculo>
    {
        #region IRepositorio<FabricanteVeiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.FabricanteVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.FabricanteVeiculo> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
