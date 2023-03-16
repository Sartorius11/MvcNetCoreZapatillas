using Microsoft.AspNetCore.Mvc;
using MvcNetCoreZapatillas.Models;

namespace MvcNetCoreZapatillas.Controllers
{
    public class ZapatillasController : Controller
    {

       
        public IActionResult Detalles()
        {
            return View();
        }


        public IActionResult _ZapatillasPartial()
        {

            return PartialView("__ZapatillasPartial",Zapatilla);
        }



        public IActionResult _DetailsZapatilla(int Idproducto)
        {
            Zapatilla zapatilla = this..FirstOrDefault(x => x.Idproducto == Idproducto);
            return PartialView("_DetailsZapatilla", zapatilla);
        }

       
    }
}
