using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ncqrs.Commanding.CommandExecution;
using Gerenciador.Dominio;
using Gerenciador.Comandos;
using Ncqrs.Domain;

namespace Gerenciador.ExecutorComandos
{
    public class PostNewTweetCommandExecutor: CommandExecutorBase<PostNewTweetCommand>
    {
        protected override void ExecuteInContext(IUnitOfWorkContext context, PostNewTweetCommand command)
        {
            var newTweet = new Tweet(command.Mensagem, command.Quem);
            context.Accept();
        }

    }
}
