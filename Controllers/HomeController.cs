﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var nome = "Cristina freitas";
            ViewBag.nome = nome;

            ViewBag.Pagina = new Pagina().Lista();
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}