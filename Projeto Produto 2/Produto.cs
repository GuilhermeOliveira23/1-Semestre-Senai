using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_2
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }        
        public Marca Marca = new Marca();        
        public Usuario CadastroPor { get; set; }
        
        List<Produto> listaDeProdutos = new List<Produto>();
        
        public void Cadastrar()
        {
            Produto p = new Produto();
        Console.WriteLine($"Insira o nome do produto:");
        p.NomeProduto = Console.ReadLine();

        Console.WriteLine($"Insira o código do produto:");
        p.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Insira o preço do produto:");
        p.Preco = float.Parse(Console.ReadLine());
        listaDeProdutos.Add(p);



        }

        public void Listar()
        {
            foreach (var item in collection)
            {
                //aqui vai a lógica
                //exibir os objetos cadastrados na lista
            }
        }
        
        public void Deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
    }
}