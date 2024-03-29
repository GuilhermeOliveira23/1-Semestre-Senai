using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_tarde.Infra;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Controllers
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
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
           Jogador jogadorBuscado = c.Jogador.First(j => j.IdJogador == id);

           c.Jogador.Remove(jogadorBuscado);
           c.SaveChanges();

           return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            
            Jogador jogadorBuscado = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Jogador = jogadorBuscado;
            ViewBag.Equipe = c.Equipe.ToList();

            return View("Edit");
        } 

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            Jogador jogadorSelecionado = c.Jogador.First(x => x.IdJogador == novoJogador.IdJogador);

            if (!string.IsNullOrEmpty(form["JogadorNome"].ToString()))
            {
                novoJogador.Nome = form["JogadorNome"].ToString();
                jogadorSelecionado.Nome = novoJogador.Nome;
            }

            if (!string.IsNullOrEmpty(form["JogadorEmail"].ToString()))
            {
                novoJogador.Email = form["JogadorEmail"].ToString();
                jogadorSelecionado.Email = novoJogador.Email;
            }

            if (string.IsNullOrEmpty(form["JogadorSenha"].ToString()))
            {
                novoJogador.Senha = form["JogadorSenha"].ToString();
                jogadorSelecionado.Senha = novoJogador.Senha;
            }

            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            jogadorSelecionado.IdEquipe = novoJogador.IdEquipe;
            jogadorSelecionado.Equipe = c.Equipe.First(x => x.IdEquipe == jogadorSelecionado.IdEquipe);

            c.Jogador.Update(jogadorSelecionado);
            c.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");

        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
             Jogador novoJogador = new Jogador();

            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            novoJogador.Equipe = c.Equipe.First(x => x.IdEquipe == int.Parse(form["Equipe"]));
            novoJogador.Nome = form["JogadorNome"].ToString();
            novoJogador.Email = form["JogadorEmail"].ToString();
            novoJogador.Senha = form["JogadorSenha"].ToString();

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