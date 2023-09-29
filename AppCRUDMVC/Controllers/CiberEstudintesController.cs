using Microsoft.AspNetCore.Mvc;

namespace AppCRUDMVC.Controllers
{
    public class CiberEstudintesController : Controller
    {
        public IActionResult Listado()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }
    }
}
