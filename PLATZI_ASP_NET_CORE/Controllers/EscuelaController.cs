using System;
using Microsoft.AspNetCore.Mvc;
using PLATZI_ASP_NET_CORE.Models;

namespace  PLATZI_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            Escuela esc = new Escuela();
            esc.añoFundacion= 2005;
            esc.escuelaId=Guid.NewGuid().ToString();
            esc.nombre="Platzi school";
            return View(esc);
        }
    }
}