using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class DespesaParcela
    {

        public int IdParcela { get; set; }

        public int NumeroDaParcela { get; set; }

        public DateTime Vencimento { get; set; }

        public double ValorParcela { get; set; }

        public StatusParcela Status { get; set; }

        public DocumentoPagar Documento { get; set; }

    }
}
