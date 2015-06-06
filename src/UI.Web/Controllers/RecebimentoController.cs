using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Web.Models.Recebimento;

//Importamos este namespace para injetarmos as nossas applications services
using LGroup.ControleFinanceiro.Application.Contracts;
using LGroup.ControleFinanceiro.Infra.Common.Resources;

namespace UI.Web.Controllers
{
    public class RecebimentoController : Controller
    {
        //Criamos esta variável para receber a injeção de dependência
        private readonly IRecebimentoApplicationService _recebimentoApplicationService;

        //Injetamos o nosso serviço de aplicação
        public RecebimentoController(IRecebimentoApplicationService recebimentoApplicationService)
        {
            //Repassamos para uma variável interna
            _recebimentoApplicationService = recebimentoApplicationService;
        }

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

            //Colocamos dentro de um try para recuperarmos os erros de negócio
            // ou um erro não previsto
            try
            {
                //Reutilizamos o método de adicionar um recebimento
                _recebimentoApplicationService
                    .Adicionar(model.NomeRecebimento, model.TipoRecebimento, model.CodigoCredito);

                TempData["Message"] = Mensagens.SalvoComSucesso;
            }
            //Se cair em um erro de negócio, irá cair no catch de ApplicationException,
            // que foi o erro forçamos no nosso domínio
            catch (ApplicationException ex)
            {
                TempData["Message"] = ex.Message;
                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Message"] = Mensagens.ErroNaoIdentificado;
                return View(model);
            }

            return RedirectToAction("Adicionar");
        }
    }
}