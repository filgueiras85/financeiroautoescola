using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Banco
    {

        public Banco() { IdBanco = 0; CodigoBanco = String.Empty; Descricao = String.Empty; }

        public int IdBanco { get; set; }

        public String CodigoBanco { get; set; }

        public String Descricao { get; set; }

    }
}
