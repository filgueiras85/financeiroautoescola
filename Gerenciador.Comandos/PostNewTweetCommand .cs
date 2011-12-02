using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ncqrs.Commanding;

namespace Gerenciador.Comandos
{
    public class PostNewTweetCommand :CommandBase
    {
        public string Mensagem { get; set; }

        public string Quem { get; set; }
    }
}
