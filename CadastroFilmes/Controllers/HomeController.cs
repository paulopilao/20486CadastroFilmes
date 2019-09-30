using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CadastroFilmes.Data;
using Microsoft.AspNetCore.Mvc;
using CadastroFilmes.Models;
using Microsoft.Extensions.Configuration;

namespace CadastroFilmes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IFilmeData _filmeData;

        public HomeController(IConfiguration config,IFilmeData filmeData)
        {
            _config = config;
            _filmeData = filmeData;
        }
        public IActionResult Index()
        {
            ViewBag.mensagem = _config["Mensagem"];

            var filmes = _filmeData.GetAll();
            return View();
        }

        public IActionResult Privacy()
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
