using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Aluno
    {

        public Aluno() {}

        public int IdAluno { get; set; }

        public String  NomeAluno { get; set; }

        public String CPF_CNPJ { get; set; }

        public String RG_InscEstadual { get; set; }

        public String  TelefoneResidencial { get; set; }

        public String TelefoneComercial { get; set; }

        public String TelefoneCelular { get; set; }

        public DateTime DataNascimento { get; set; }

        public Endereco Endereco { get; set; }

        public String SSP { get; set; }

        public String NomePai { get; set; }

        public String NomeMae { get; set; }

        public String Referencia { get; set; }

        public String Observacao { get; set; }

    }
}
