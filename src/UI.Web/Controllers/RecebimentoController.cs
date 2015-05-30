using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Web.Models.Recebimento;

namespace UI.Web.Controllers
{
    public class RecebimentoController : Controller
    {
        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Models.Recebimento.AdicionarModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //Processamento do POST

            TempData["Message"] = "O recebimento foi adicionado com sucesso!";

            return RedirectToAction("Adicionar");
        }
    }
}