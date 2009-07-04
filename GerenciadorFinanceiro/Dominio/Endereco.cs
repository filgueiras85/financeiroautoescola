using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Endereco
    {
        public Endereco() { }

        public String Rua { get; set; }

        public int Numero { get; set; }

        public String Complemento { get; set; }

        public String Bairro { get; set; }

        public String CEP { get; set; }

        public Cidade Cidade { get; set; }
    }
}
