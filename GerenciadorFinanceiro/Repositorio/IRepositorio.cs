using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    public interface IRepositorio<T>
    {
        void SalvarObjeto(T objeto);

        void AtualizarObjeto(T objeto);

        void DeletarObjeto(T objeto);

        T BuscarObjetoPorId(int id);

        List<T> BuscarTodos();
    }
}
