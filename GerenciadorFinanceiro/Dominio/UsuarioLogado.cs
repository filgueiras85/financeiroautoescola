using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class UsuarioLogado
    {
        private static Usuario _User;
        public static Usuario User
        {
            get { return _User; }
            set { _User = value; }
        }
    }
}
