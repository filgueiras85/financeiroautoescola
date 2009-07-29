using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.TratamentoErros
{
    class TratadorErro
    {

        public void TrataErro(TipoErro tipo, Exception ex, bool reThrow, string mensagem)
        {
            switch (tipo)
            {
                case TipoErro.InterfaceGrafica:
                    string msg = "Interface Grafica: " + mensagem;
                    LogarErro(msg, ex);
                    break;
                case TipoErro.BancoDados:
                    msg = "Banco de dados: " + mensagem;
                    LogarErro(msg, ex);
                    break;
                case TipoErro.NaoTratado:
                    msg = "Erro não tratado: " + mensagem;
                    LogarErro(msg, ex);
                    break;
                default:
                    break;

            }
            if (reThrow)
                throw new Exception(mensagem, ex);
        
        }


        private void LogarErro(string mensagem, Exception ex)
        {
            string pasta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Log");
            // se não existe a pasta cria a ela no startap da aplicação
            if (!System.IO.Directory.Exists(pasta)) {
                System.IO.Directory.CreateDirectory(pasta);
            }
            // recebe a data atual para gravar o log
            System.DateTime dt = DateTime.Now;
            // define o nome do arqui DATA.txt
            string file = dt.Day + "-" + dt.Month + "-" + dt.Year + ".txt";
            
            pasta = System.IO.Path.Combine(pasta, file);            
            System.IO.StreamWriter strw = new System.IO.StreamWriter(pasta, true);

            try
            {
                strw.WriteLine(mensagem);
                strw.Write(ex.ToString());
            }
            catch (Exception) { }
            finally
            {
                strw.Close();
            }
        }
    }
}
