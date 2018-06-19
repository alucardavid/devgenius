using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevGenius.Models;

namespace DevGenius.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string SalvarContato(Contato m)
        {
            try
            {
                return m.SalvarContato();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}