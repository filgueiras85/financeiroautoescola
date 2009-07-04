using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Identificacao
    {
        public Identificacao() { }

        public String Username { get; set; }

        public String Password { get; set; }

        public Usuario Usuario { get; set; }
    }
}
