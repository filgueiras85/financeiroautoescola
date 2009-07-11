using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioModeloVeiculo: IRepositorio<Dominio.ModeloVeiculo>
    {

        #region IRepositorio<ModeloVeiculo> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.ModeloVeiculo objeto)
        {
            throw new NotImplementedException();
        }

        public void BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.ModeloVeiculo> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
