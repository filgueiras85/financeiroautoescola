using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class FormaPagamento
    {
        public FormaPagamento()
        {
        }


        public int Id { get; set; }

        public string Descricao { get; set; }

        public int QuantidadeParcela { get; set; }

        public int MyProperty { get; set; }

    }
}
