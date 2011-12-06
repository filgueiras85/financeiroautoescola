using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ncqrs;
using Ncqrs.Commanding.ServiceModel;
using Gerenciador.ExecutorComandos;
using Ncqrs.Eventing.Storage;
using Ncqrs.Eventing.Storage.SQL;
using Ncqrs.Eventing.ServiceModel.Bus;
using Gerenciador.ModeloLeitura;

namespace Gerenciador.ServicoComandos
{
    public static class Bootstrapper
    {
        public static void BootUp()
        {
            NcqrsEnvironment.SetDefault<ICommandService>(InitializeCommandService());
            NcqrsEnvironment.SetDefault<IEventStore>(InitializeEventStore());
            NcqrsEnvironment.SetDefault<IEventBus>(InitializeEventBus());
        }

        private static IEventBus InitializeEventBus()
        {
            var bus = new InProcessEventBus();
            bus.RegisterHandler(new TweetListItemDenormalizer());

            return bus;
        }

        private static IEventStore InitializeEventStore()
        {
            return new SimpleMicrosoftSqlServerEventStore("Data Source=.\\SQLEXPRESS;Integrated Security=SSPI;User Instance=True;AttachDbFilename=|DataDirectory|\\EventStore.mdf;");
        }

        private static ICommandService InitializeCommandService()
        {
            var service = new InProcessCommandService();
            service.RegisterExecutor(new PostNewTweetCommandExecutor());

            return service;
        }
    }
}