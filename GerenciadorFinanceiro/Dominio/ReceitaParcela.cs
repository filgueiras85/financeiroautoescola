using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class ReceitaParcela
    {
        public ReceitaParcela() { IdParcela = 0; NumeroDaParcela = 0; Vencimento = System.DateTime.Now; ValorParcela = 0.0;
        NumeroDoTitulo = String.Empty; TipoDocumento = 0; DataCompetencia = System.DateTime.Now;
        NumeroDoDocumento = String.Empty; Serie = String.Empty; Identificacao = String.Empty; ObservacaoIndividual = String.Empty;
        }

        public int IdParcela { get; set; }

        public int NumeroDaParcela { get; set; }

        public DateTime Vencimento { get; set; }

        public double ValorParcela { get; set; }

        public int StatusParcela { get; set; }

        public String NumeroDoTitulo { get; set; }

        public int TipoDocumento { get; set; }

        public DateTime DataCompetencia { get; set; }

        public String NumeroDoDocumento { get; set; }

        public String Serie { get; set; }

        public String Identificacao { get; set; }

        public String ObservacaoIndividual { get; set; }

        public DocumentoReceber Documento { get; set; }

    }
}
