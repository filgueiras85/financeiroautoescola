using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    public class CentroCustos
    {
        public enum Tipo { Receita = 0, Despesa = 1}

        public CentroCustos() { }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public Tipo ReceitaOuDespesa { get; set; }

    }
}
