using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Repositorio
{
    class RepositorioDespesa: RepositorioBase, IRepositorio<Dominio.Despesa>
    {

        #region IRepositorio<Despesa> Members

        public void SalvarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {            
            throw new NotImplementedException();
        }

        public void DeletarObjeto(GerenciadorFinanceiro.Dominio.Despesa objeto)
        {
            string sqlUpdate = "delete from TB_Despesa where IdDespesa=@Id and Status=@status";
            try
            {
                this.Conection.AbrirConexao();
                this.Conection.Execute(sqlUpdate, objeto.IdDespesa, StatusParcela.Aberta);
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public GerenciadorFinanceiro.Dominio.Despesa BuscarObjetoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GerenciadorFinanceiro.Dominio.Despesa> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
