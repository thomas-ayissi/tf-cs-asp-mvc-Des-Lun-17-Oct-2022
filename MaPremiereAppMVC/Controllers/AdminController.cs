using Microsoft.AspNetCore.Mvc;

namespace MaPremiereAppMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/new")]
        [Route("NewAdmin")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Admin/Bienvenu/{name}")]
        [Route("Admin/Bienvenu")]
        public string Bienvenu(string name)
        {
            return $"Bienvenu administrateur {name}";
        }

        public string codehtml()
        {
            return @"<!DOCTYPE HTML>
<html>
    <head>
        <title>Exemple de code html</title>
    </head>
    <body>
        <h1>Exemple de code html</h1>
    </body>
</html>";
        }

        public int[] tableauEntier(int id=10)
        {
            int[] ints = new int[id];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }
            return ints;
        }
    }
}
