using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioAluno: IRepositorio<Dominio.Aluno>
    {

        #region IRepositorio<Aluno> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {


            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Aluno objeto)
        {
            throw new NotImplementedException();
        }

        public Dominio.Aluno BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Aluno> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
