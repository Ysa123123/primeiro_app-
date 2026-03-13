using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "aluno nota 10";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
