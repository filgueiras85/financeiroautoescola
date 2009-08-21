using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class ReceitaParcela
    {
        public ReceitaParcela() { IdParcela = 0; Vencimento = System.DateTime.Now; ValorParcela = 0.0;
        StatusParcela = 0; NumeroDaParcela = 0; DataQuitado = System.DateTime.Now; ValorPago = 0.0; Documento = new Dominio.DocumentoReceber();
        }

        public int IdParcela { get; set; }

        public DateTime Vencimento { get; set; }

        public double ValorParcela { get; set; }

        public int StatusParcela { get; set; }

        public int NumeroDaParcela { get; set; }

        public DateTime DataQuitado { get; set; }

        public double ValorPago { get; set; }

        public DocumentoReceber Documento { get; set; }

    }
}
