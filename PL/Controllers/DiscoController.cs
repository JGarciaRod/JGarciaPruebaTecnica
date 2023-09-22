using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class DiscoController : Controller
    {
        // GET: Disco
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Disco disco = new ML.Disco();

            ML.Result result = BL.Musica.GetAll();

            if (result.Correct)
            {
                disco.Discos = result.Objects;
            }
            else
            {
                ViewBag.Message = result.ErrorMessage;
            }

            return View();
        }
    }
}