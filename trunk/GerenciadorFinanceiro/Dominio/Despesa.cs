﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Despesa
    {

        public int IdDespesa { get; set; }

        public Fornecedor PagarPara { get; set; }

        public CentroCustos CentroCustoReceita { get; set; }

        public Categoria CategoriaReceita { get; set; }
        
        public string Observacao { get; set; }

        public int QuantidadeParcela { get; set; }

        public DateTime UltimoPagamento { get; set; }

        public double ValorTotalDespesa { get; set; }

        public List<DespesaParcela> ListaParcelasDespesas { get; set; }

        public DocumentoPagar Documento { get; set; }

    }
}
