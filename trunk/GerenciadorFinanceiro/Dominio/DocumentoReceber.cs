using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class DocumentoReceber
    {

        public int IdDocumentoReceber { get; set; }

        public float Valor { get; set; }

        public StatusParcela Status { get; set; }

        public DateTime DataQuitacao { get; set; }       

    }
}
