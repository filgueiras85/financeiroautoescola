using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ncqrs.Domain;

namespace Gerenciador.Eventos
{
    [Serializable]
    public class TweetPostedEvent: DomainEvent
    {
        public string Mensagem { get; set; }
        public string Quem { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
