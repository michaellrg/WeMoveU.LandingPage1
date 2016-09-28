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

        [HttpPost]
        public ActionResult Index(DadosCadastro dados)
        {
            if (ModelState.IsValid)
            {
                EnviaEmail Email = new EnviaEmail();
                string retorno = Email.enviaEmailSenha(dados.Email);
                return View();
            }
            else
            {
                return View("Index", dados);
            }
        }
    }
}