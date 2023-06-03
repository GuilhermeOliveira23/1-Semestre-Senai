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
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
        ViewBag.Jogador = c.Jogador.ToList();
        ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

    


        [Route("Cadastrar")]
         public IActionResult Cadastrar(IFormCollection form, string a){
            Jogador novoJogador = new Jogador();
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();


            
            
            
            
            
            
            // novoJogador.IdEquipe = form["Times"];
            
            


            c.Jogador.Add(novoJogador);
            c.SaveChanges();
            
            
            


            return LocalRedirect("~/Jogador/Listar");
         }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}