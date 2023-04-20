using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Início
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura ;
        public string ia;
        //metodos
        //Atacar,Defender, Restaurar, Armadura
        public void Atacar()
        {
            Console.WriteLine($"O Personagem atacou !!!");
            
        }

        public void Defender(){
            Console.WriteLine($"O Personagem Defendeu!!!");
            
        }
        public void RestaurarArmadura(){
            Console.WriteLine($"Armadura restaurada !!!");
            
            
        }
    }
}