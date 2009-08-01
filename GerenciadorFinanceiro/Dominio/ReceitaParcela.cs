using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class ReceitaParcela
    {
        public ReceitaParcela() { IdParcela = 0; NumeroDaParcela = 0; Vencimento = System.DateTime.Now; ValorParcela = 0.0; }

        public int IdParcela { get; set; }

        public int NumeroDaParcela { get; set; }

        public DateTime Vencimento { get; set; }

        public double ValorParcela { get; set; }

        public int StatusParcela { get; set; }

        //public Receita ReceitaParc { get; set; }

    }
}
