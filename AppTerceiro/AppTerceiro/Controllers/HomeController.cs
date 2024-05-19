using AppTerceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppTerceiro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Fisica fisica = new Fisica
            {
                Id = 10,
                Nome = " Thallya Eduarda ", 
                Sexo = 'F',
                CPF = 12345678910,
                RG= 12345678,
                Dig_RG = '7'
            };
            ViewData["Id"] = fisica.Id;
            ViewData["Nome"] = fisica.Nome;
            ViewData["Sexo"] = fisica.Sexo;
            ViewData["CPF"] = fisica.CPF;
            ViewData["RG"] = fisica.RG;
            ViewData["Dig_RG"] = fisica.Dig_RG;

            return View(fisica);
        }
        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12;
            pessoa.Nome = "Arthur";
            pessoa.Sexo = 'M';

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;

            return View(pessoa);
        }
        public IActionResult Juridico() {
            Juridico juridica = new Juridico();
            juridica.Id = 1074;
            juridica.Nome = "Alexandre e Arthur";
            juridica.CNPJ = 123123123213123123;
            juridica.IE = 12321312312321312;
            return View(juridica);
        }
        public IActionResult ExemploTempData()
        {
            Juridico juridico = new Juridico();
            juridico.Id = 2005;
            juridico.Nome = "Nilson Tecnology";
            juridico.CNPJ = 12321313123;
            juridico.IE = 3132131312;

            TempData["Id"] = Convert.ToString(juridico.Id);
            TempData["Nome"] = juridico.Nome;
            TempData["CNPJ"] = Convert.ToString(juridico.CNPJ);
            TempData["IE"] = Convert.ToString(juridico.IE);


            return RedirectToAction("Juridico");

        }
        public IActionResult Pessoa() 
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
