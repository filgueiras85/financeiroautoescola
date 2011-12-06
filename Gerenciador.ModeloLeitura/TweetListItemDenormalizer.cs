using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerenciador.ModeloLeitura
{
    public class TweetListItemDenormalizer : Ncqrs.Eventing.Denormalization.IDenormalizer<Eventos.TweetPostedEvent>
    {

        public void DenormalizeEvent(Eventos.TweetPostedEvent evnt)
        {
            throw new NotImplementedException();
        }

        public void Handle(Eventos.TweetPostedEvent evnt)
        {
            var context = new ReadModeloDataContext();

            var newItem = new TweetIndexItem ();
            newItem.Id = evnt.AggregateRootId;
            newItem.Message = evnt.Mensagem;
            newItem.Who = evnt.Quem;
            newItem.TimeStamp = evnt.TimeStamp;

            context.TweetIndexItems.InsertOnSubmit(newItem);
            context.SubmitChanges();
        }
    }
}
