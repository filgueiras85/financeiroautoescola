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

                    break;
                case TipoErro.BancoDados:

                    break;
                case TipoErro.NaoTratado:

                    break;
                default:
                    break;

            }
            if (reThrow)
                throw new Exception(mensagem, ex);
        
        }

    }
}
