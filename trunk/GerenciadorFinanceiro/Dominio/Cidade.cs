using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Cidade
    {
        public Cidade() { }

        public int IdCidade { get; set; }

        public String NomeCidade { get; set; }

        public Estado Estado { get; set; }
    }
}
