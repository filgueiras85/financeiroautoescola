using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace GerenciadorFinanceiro.BancoDados
{
    public class Conexao: IDisposable
    {

        private string _StrConexao;
        private System.Data.SqlServerCe.SqlCeConnection _Conexao;
        private System.Data.SqlServerCe.SqlCeTransaction _Transaction;
        
        public Conexao()
        {
            ConfiguraStringConexao();
            _Conexao = new System.Data.SqlServerCe.SqlCeConnection(_StrConexao);
        }

        private void ConfiguraStringConexao()
        {
            //_StrConexao = "Data Source=" + System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "BancoDados\\DBGerenciador.sdf");
            _StrConexao = "Data Source=" +  System.IO.Path.Combine( GerenciadorFinanceiro.Properties.Settings.Default.LocalDB ,  "DBGerenciador.sdf");
        }

        public SqlCeConnection getConexao
        {
            get { return _Conexao; }
        }

        public void AbrirConexao()
        {
            if (_Conexao.State != System.Data.ConnectionState.Open)
                _Conexao.Open();
        }

        public void FecharConexao()
        {
            if (_Conexao.State != System.Data.ConnectionState.Closed)
                _Conexao.Close();
        }

        public void BeginTransaction(System.Data.IsolationLevel isolation)
        {
            try
            {
                _Transaction = _Conexao.BeginTransaction(isolation);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível iniciar a transação.", ex);
            }           
        }


        public void Commit()
        {
            try
            {
                _Transaction.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível executar o commit da transação.", ex);
            }
        }
        
        public void Rollback()
        {
            try
            {
                _Transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível executar o rollback da transação.", ex);
            }
        }

        public void Execute(string sql, params  object[] parametros)
        {
            SqlCeCommand comando = new SqlCeCommand(sql, _Conexao);
            List<string> lista = BuscaParametros(sql);
            try
            {
                if (lista.Count != parametros.Length)
                {
                    throw new Exception("Contagem de Parametros incorreto.");
                }
                AdicionaParametros(comando, lista, parametros);
                comando.ExecuteNonQuery();
            }
            finally
            {
                comando.Dispose();
            }
        }

        public object ExecuteScalar(string sql, params object[] parametros)
        {
            SqlCeCommand comando = new SqlCeCommand(sql, _Conexao);
            List<string> lista = BuscaParametros(sql);
            try
            {
                if (lista.Count != parametros.Length)
                {
                    throw new Exception("Contagem de Parametros incorreto.");
                }
                AdicionaParametros(comando, lista, parametros);
                return comando.ExecuteScalar();
            }
            finally
            {
                comando.Dispose();
            }
        }

        public SqlCeDataReader ExecuteReader(string sql, params object[] parametros)
        {
            SqlCeCommand comando = new SqlCeCommand(sql, _Conexao);
            List<string> lista = BuscaParametros(sql);
            try
            {
                if (lista.Count != parametros.Length)
                {
                    throw new Exception("Contagem de Parametros incorreto.");
                }
                AdicionaParametros(comando, lista, parametros);
                return comando.ExecuteReader();
            }
            finally
            {
                comando.Dispose();
            }
        }

        private void AdicionaParametros(SqlCeCommand comando, List<string> parametros, params object[] valores)
        {
            for (int i = 0; i < parametros.Count; i++)
            {
                comando.Parameters.Add(new SqlCeParameter(parametros[i], valores[i]));
            }
        }

        private List<String> BuscaParametros(string sql)
        {
            List<string> lista = new List<string>();
            int Indice = 0;
            bool Encontrou = false;
            int i;
            string str = "";
            for (i = 0; i < sql.Length; i++)
            {
                if (sql[i] == '@')
                {
                    Indice = i;
                    if (Encontrou)
                        Encontrou = false;
                    else
                        Encontrou = true;
                }
                else if (sql[i] == ' ' || sql[i] == ',' || sql[i] == ')')
                {
                    if (Encontrou)
                    {
                        str = sql.Substring(Indice, i - Indice);
                        lista.Add(str);
                        Encontrou = false;
                    }
                }
            }
            if (Encontrou)
            {
                str = sql.Substring(Indice, i - Indice);
                lista.Add(str);
            }
            return lista;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_Conexao != null)
                _Conexao.Dispose();
        }

        #endregion
    }
}
