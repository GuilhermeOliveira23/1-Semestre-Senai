using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nomeProduto { get; set; }
        public float preco { get; set; }
        public DateTime dataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario cadastradoPor { get; set; }
        public List<Produto> listaProdutos = new List<Produto>();

        public string Cadastrar(){

Console.WriteLine($"Insira o nome do produto:");
nomeProduto = Console.ReadLine();

Console.WriteLine($"Insira o código do produto:");
codigo = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o preço do produto:");
preco = float.Parse(Console.ReadLine());

return "Produto cadastrado com sucesso";




        }
        public void Listar(){
            
        }
        public string Deletar(int codigo){
            codigo = 0;
            return "Marca deletada";
        }

    }
}