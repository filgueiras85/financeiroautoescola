using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Instrutor
    {
        public Instrutor() { }

        public int IdInstrutor { get; set; }

        public String Nome { get; set; }

        public String TelefoneResidencial { get; set; }

        public String TelefoneCelular { get; set; }

        public String RG { get; set; }

        public String CPF { get; set; }

        public String Categorias { get; set; }

        public Endereco Endereco { get; set; }

    }
}
