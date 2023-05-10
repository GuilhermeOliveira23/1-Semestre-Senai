using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_lista
{
    public class Carro
    {
        public string marca { get; set; }
        public string cor { get; set; }
        public Carro()
        {
        
        }    
        public Carro(string Marca , string Cor)
        {
            marca = Marca;
            cor = Cor;
        }
        //ao usar esse comando eu chamo as variaveis junto com a funcao
    }
}