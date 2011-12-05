using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ncqrs;
using Ncqrs.Commanding.ServiceModel;
using Gerenciador.ExecutorComandos;
using Ncqrs.Eventing.Storage;
using Ncqrs.Eventing.Storage.SQL;

namespace Gerenciador.ServicoComandos
{
    public static class Bootstrapper
    {
        public static void BootUp()
        {
            NcqrsEnvironment.SetDefault<ICommandService>(InitializeCommandService());
            NcqrsEnvironment.SetDefault<IEventStore>(InitializeEventStore());
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