using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace GerenciadorFinanceiro.Repositorio
{
    public class RepositorioBase: IDisposable 
    {
        private string _StrConexao;
        private System.Data.SqlServerCe.SqlCeConnection _Conexao;

        public RepositorioBase()
        {
            ConfiguraStringConexao();
            _Conexao = new SqlCeConnection(_StrConexao);
        }

        private void ConfiguraStringConexao()
        {
            _StrConexao = "Data Source=" +  System.IO.Path.Combine( System.Windows.Forms.Application.StartupPath  ,  "BancoDados\\DBGerenciador.sdf");             
        }

        public SqlCeConnection Conexao
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


        public void Execute(string sql,params  object[] parametros)
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
                    Indice =i;
                    Encontrou = true;
                }else if (sql[i]== ' ' || sql[i] == ',' || sql[i] == ')'){
                    if (Encontrou)
                    {
                        str = sql.Substring(Indice, i-Indice);
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
            {
                try
                {
                    _Conexao.Close();
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
