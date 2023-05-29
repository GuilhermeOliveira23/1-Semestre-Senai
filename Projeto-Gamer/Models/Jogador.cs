using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Gamer.Models
{
    public class Jogador
    {
        //chave é um identificador
        [Key]
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        // chave de outra classe, com o valor "Equipe" - indicando a classe de onde veio a chave
        [ForeignKey("Equipe")]
        public int IdEquipe { get; set; }
        public Equipe Equipe { get; set; }



    }
}