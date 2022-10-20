using Microsoft.AspNetCore.Mvc;

namespace MaPremiereAppMVC.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Math/Carre/{nombre}")]
        [Route("Math/{nombre}/auCarre")]
        public int Carre(int nombre)
        {
            return nombre*nombre;
        }

        [Route("Math/Multiple/{nombre}")]
        [Route("Math/Table/{nombre}")]
        public string[] Multiplication(int nombre)
        {
            string[] results = new string[10];
            for (int i = 0; i < results.Length; i++)
            {
                int result = (i + 1) * nombre;
                results[i] = $"{i + 1} X {nombre} = {result}";
            }
            return results;
        }

        [Route("Math/Division/{nombre1}/{nombre2}")]
        [Route("Math/Division")]
        [Route("Math/{nombre1}/divisePar/{nombre2}")]
        public IActionResult Division(int nombre1, int nombre2) {
            if (nombre2 == 0) return RedirectToAction("PrintInfini");
            double result =  (double)nombre1 / nombre2;
            return RedirectToAction("PrintResult",new { result = result });
        }

        public string PrintInfini()
        {
            return "Vers l'infini et au delà!";
        }

        public double PrintResult(double result)
        {
            return result;
        }
    }
}
