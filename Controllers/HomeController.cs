using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pi3.Models;

namespace pi3.Controllers
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
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }
        public IActionResult Empresa()
        {
            return View();
        }
        public IActionResult Fotos()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Korn()
        {
            return View();
        }
        public IActionResult Metallica()
        {
            return View();
        }
        public IActionResult Slayer()
        {
            return View();
        }
        public IActionResult Slipknot()
        {
            return View();
        }
        public IActionResult Almofada()
        {
            return View();
        }
        public IActionResult Caneca()
        {
            return View();
        }

        public IActionResult Info()
        {
            List<Contato> contato = InfoContato.Lista();
            return View(contato);
        }


        [HttpPost]
        public IActionResult Contato(Contato novoContato)
        {
            ContatoRepository cr = new ContatoRepository();
            cr.TestarConexao();
            InfoContato.Incluir(novoContato);
            return View();
        }
         public IActionResult Contato()
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
