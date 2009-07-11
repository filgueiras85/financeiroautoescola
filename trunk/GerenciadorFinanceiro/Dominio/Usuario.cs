using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Usuario
    {
        public Usuario() 
        {
            Email = "";
            Telefone = "";
            Celular = "";
        }

        public int IdUsuario { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public String Celular { get; set; }

        public String UserName { get; set; }

        public String Senha { get; set; }
    }
}
