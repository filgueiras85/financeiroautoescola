using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Veiculo
    {
        public Veiculo() { }

        public int IdVeiculo { get; set; }

        public String Placa { get; set; }

        public String Renavam { get; set; }

        public String Chassi { get; set; }

        public int Ano { get; set; }

        public String Cor { get; set; }

        public String Observacao { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

    }
}
