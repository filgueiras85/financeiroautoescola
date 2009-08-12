using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class DespesaCombustivel
    {
        public DespesaCombustivel()
        { }

        public DespesaCombustivel(Dominio.Veiculo veiculo, int kmIni, int kmFim, int qtdLitros, double valor, TipoCombustivel combustivel, DateTime data)
        {
            this.Veiculo = veiculo; this.KmInicial = kmIni; this.KmFinal = kmFim;
            this.QtdLitros = qtdLitros; this.ValorTotal = valor; this.Combustivel = combustivel; this.DataAbastecimento = data;
        }

        public Dominio.Veiculo Veiculo { get; set; }

        public int KmInicial { get; set; }

        public int KmFinal { get; set; }

        public int QtdLitros { get; set; }

        public double ValorTotal { get; set; }

        public TipoCombustivel Combustivel { get; set; }

        public DateTime DataAbastecimento { get; set; }

    }
}
