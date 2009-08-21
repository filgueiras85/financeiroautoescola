using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    public class Fornecedor
    {

        public Fornecedor()
        {
            Telefone = string.Empty;
        }

        public int IdFornecedor { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }        

    }
}
