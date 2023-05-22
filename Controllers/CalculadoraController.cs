using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using CalculadoraCientifica.Models;
using CalculadoraCientifica.Repositories;

namespace CalculadoraCientifica.Controllers
{
    public class CalculadoraController : Controller
    {
        private IWebHostEnvironment _environment;
        private InterfazCalculadoraRepositorio _repositorio;

        public CalculadoraController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HistorialOperaciones()
        {
            return View(_repositorio.GetAll());
        }
    }
}
