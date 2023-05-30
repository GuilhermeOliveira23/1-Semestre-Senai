using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer.Infra;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

// Instância do objeto da classe contexto : acessa o BD

        Context c = new Context();




                            //             controller/action
             [Route("Listar")]//http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            // "mochila" que contém a lista das equipes
            // podemos usar essa "mochila" na view de equipe
            ViewBag.Equipe = c.Equipe.ToList();
            // retorna a view de equipe
            return View();
        }

        // formulário
        public IActionResult Cadastrar(IFormCollection form){
            Equipe novaEquipe = new Equipe();
            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Imagem = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);

            c.SaveChanges();
            ViewBag.Equipe = c.Equipe.ToList();
            return LocalRedirect("~/Equipe/Listar");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}