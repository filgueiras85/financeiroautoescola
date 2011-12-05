using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ncqrs;
using Ncqrs.Commanding.ServiceModel;

namespace Gerenciador.ServicoComandos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleTwitterCommandService" in code, svc and config file together.
    public class SimpleTwitterCommandService : ISimpleTwitterCommandService
    {
        static SimpleTwitterCommandService()
        {
            Bootstrapper.BootUp();
        }

        public void Execute(Comandos.PostNewTweetCommand command)
        {
            var service = NcqrsEnvironment.Get<ICommandService>();
            service.Execute(command);
        }

    }
}
