using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    public class Veiculo
    {
        public Veiculo() 
        {
            Renavam = string.Empty; Chassi = string.Empty; Combustivel = string.Empty; Cor = string.Empty;
            Observacao = string.Empty; PathFoto = string.Empty; TipoVeiculo = new TipoVeiculo(); ModeloVeiculo = new ModeloVeiculo();
        }

        public int IdVeiculo { get; set; }

        public String Placa { get; set; }

        public String Renavam { get; set; }

        public String Chassi { get; set; }

        public String Combustivel { get; set; }

        public int Ano { get; set; }

        public int Modelo { get; set; }

        public String Cor { get; set; }

        public String Observacao { get; set; }

        public String PathFoto { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public ModeloVeiculo  ModeloVeiculo { get; set; }

        public override string ToString()
        {
            if (ModeloVeiculo != null)
                return this.ModeloVeiculo.Descricao + " - " + this.Placa;
            else
                return base.ToString();
        }
    }
}
