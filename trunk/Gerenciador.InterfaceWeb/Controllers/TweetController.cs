using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gerenciador.Comandos;
using Gerenciador.InterfaceWeb.Commanding;
using Gerenciador.ModeloLeitura;

namespace Gerenciador.InterfaceWeb.Controllers
{
    public class TweetController : Controller
    {
        //
        // GET: /Tweet/

        public ActionResult Index()
        {
            var context = new ReadModeloDataContext();
            var query = from item in context.TweetIndexItems
                        orderby item.TimeStamp descending
                        select item;

            return View(query);            
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(PostNewTweetCommand command)
        {
            var service = new SimpleTwitterCommandServiceClient();
            service.Execute(command);

            return View();
        }

    }
}
