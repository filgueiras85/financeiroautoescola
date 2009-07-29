using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace GerenciadorFinanceiro.Repositorio
{
    public class RepositorioBase: IDisposable 
    {
        private BancoDados.Conexao _Conexao;

        public RepositorioBase()
        {
            _Conexao = new GerenciadorFinanceiro.BancoDados.Conexao();
        }

        public BancoDados.Conexao Conection
        {
            get { return _Conexao; }
        }
                              

        #region IDisposable Members

        public void Dispose()
        {
            if (_Conexao != null)
            {
                try
                {
                    _Conexao.FecharConexao();
                    _Conexao.Dispose();
                }
                catch (Exception)
                {                 
                }
            }
        }

        #endregion
    }
}
