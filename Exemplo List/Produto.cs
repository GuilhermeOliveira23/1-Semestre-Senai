using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_List
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        public Produto(){

        }
        public Produto(int Codigo, string Nome, float Preco){
        Console.WriteLine($"Fala dms");
        codigo = Codigo;
        nome = Nome;
        preco = Preco;

        }
    }
}