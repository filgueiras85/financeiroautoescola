using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class ModeloVeiculo
    {

        public int IdModeloVeiculo { get; set; }

        public String Descricao { get; set; }

        public Dominio.FabricanteVeiculo Fabricante { get; set; }

    }
}
