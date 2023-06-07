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
            ViewBag.UserName= HttpContext.Session.GetString("UserName");
            ViewBag.Equipe = c.Equipe.ToList();
            // retorna a view de equipe
            return View();
        }

        // formulário
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            // vem como string, o que precisamos é a imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            // aqui começa a lógica do upload de imagem

            //se quantidade de arquivos for maior que 0
            if (form.Files.Count > 0)
            {
                // file é igual a posição zero dos arquivos de form
                var file = form.Files[0];
                // folder é igual ao caminho combinado do diretório atual + o caminho da root até Equipes
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
                // se diretório existir 
                 if (!Directory.Exists(folder))
                 {
                    Directory.CreateDirectory(folder);
                 }
                 var path = Path.Combine(folder, file.FileName);

                 using (var stream = new FileStream(path, FileMode.Create))
                 {
                    file.CopyTo(stream);
                 }

                 novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

        // Fim da lógica de upload de imagem

            c.Equipe.Add(novaEquipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }
       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
       Equipe e = c.Equipe.First( e => e.IdEquipe == id);

       c.Equipe.Remove(e);

       c.SaveChanges();

       //vai dar "refresh" na página
       return LocalRedirect("~/Equipe/Listar");

        }
        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName= HttpContext.Session.GetString("UserName");

            Equipe e = c.Equipe.First(e => e.IdEquipe == id);

            ViewBag.Equipe = e;
            
            return View("Edit");
        }

            [Route("Atualizar")]
            public IActionResult Atualizar(IFormCollection form, Equipe e)
            {
                Equipe novaEquipe = new Equipe();
                novaEquipe.Nome = e.Nome;

                //upload da imagem na equipe nova(atualizada)
                if (form.Files.Count > 0)
                {
                    var file = form.Files[0];
                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "www.root/img/Equipes");

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    var path = Path.Combine(folder, file.FileName);
                    
                    
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    novaEquipe.Imagem = file.Name;
                    }
                    else
                    {
                        novaEquipe.Imagem = "padrao.png";
                    }

                    Equipe equipe = c.Equipe.First(x => x.IdEquipe == e.IdEquipe);

                equipe.Nome = novaEquipe.Nome;
                equipe.Imagem = novaEquipe.Imagem;

                c.Equipe.Update(equipe);

                c.SaveChanges();
                

                return LocalRedirect("~/Equipe/Listar");
            }
        
    }
}