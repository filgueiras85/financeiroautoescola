using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    public class Categoria
    {

        public Categoria() { }

        public int Id { get; set; }
        
        public CentroCustos CategoriaPai { get; set; }

        public string Descricao { get; set; }

    }
}
