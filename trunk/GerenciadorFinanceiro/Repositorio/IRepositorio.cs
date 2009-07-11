using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    interface IRepositorio<T>
    {
        void SalvarObjeto(T objeto);

        void AtualizarObjeto(T objeto);

        void DeletarObjeto(T objeto);

        void BuscarObjetoPorId(int id);

        List<T> BuscarTodos();
    }
}
