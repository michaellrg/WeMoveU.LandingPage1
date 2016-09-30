using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeMoveU.LandingPage.Web.Models;

namespace WeMoveU.LandingPage.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(DadosCadastro dados)
        {
            if (ModelState.IsValid)
            {
                EnviaResposta Email = new EnviaResposta();
                EnviaDadosRelatorio eDados = new EnviaDadosRelatorio();
                string retornoResposta = Email.enviaResposta(dados.Email, dados.Nome);

                string retornoDados = eDados.enviaEmailDadosRelatorio("souzaf.vitor@gmail.com", dados);
                return Redirect("https://pagseguro.uol.com.br/v2/checkout/payment.html?code=1F776CBF2F2FA1A1146CFFA421451EB2");

            }
            else
            {
                return View("Index", dados);
            }
        }
        [HttpGet]
        public ActionResult Ebook()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ebook(DadosEbook dados)
        {
            if (ModelState.IsValid)
            {
                EnviaDadosEbook Email = new EnviaDadosEbook();
                string retorno = Email.enviaEmailDadosEbook("souzaf.vitor@gmail.com", dados);
                return View("Agradecimento");
            }
            else
            {
                return View("Ebook", dados);
            }
        }

    }

}