using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    public class RepositorioInstrutor : RepositorioBase, IRepositorio<Dominio.Instrutor>
    {

        #region IRepositorio<Instrutor> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Instrutor objeto)
        {
            throw new NotImplementedException();
        }

        public GerenciadorFinanceiro.Dominio.Instrutor BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Instrutor> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
