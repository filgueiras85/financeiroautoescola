using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Aluno
    {

        public Aluno() 
        {
            TelefoneCelular = string.Empty; TelefoneComercial = string.Empty; TelefoneResidencial = string.Empty;
            DataNascimento = DateTime.Now; Endereco = new Endereco(); SSP = string.Empty; NomeMae = string.Empty;
            NomePai = string.Empty; Referencia = string.Empty; Observacao = string.Empty;
        }

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
