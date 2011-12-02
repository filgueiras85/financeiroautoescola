using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ncqrs.Domain;
using Gerenciador.Eventos;

namespace Gerenciador.Dominio
{
    public class Tweet: AggregateRootMappedByConvention
    {
        private string _mensagem;
        private string _quem;
        private DateTime _timestamp;

        public Tweet(string mensagem, string quem)
        {
            var e = new TweetPostedEvent
            {
                Mensagem = mensagem,
                Quem = quem,
                TimeStamp = DateTime.UtcNow
            };

            ApplyEvent(e);
        }

        protected void OnTweetPosted(TweetPostedEvent e)
        {
            _mensagem = e.Mensagem;
            _quem= e.Quem;
            _timestamp = e.TimeStamp;
        }

    }
}
