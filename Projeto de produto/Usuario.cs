using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public int senha { get; set; }
        public DateTime DataCadastro { get; set;}

        
    

        public string Cadastrar()

        {

            
            Console.WriteLine($"Digite o seu nome:");
            nome = Console.ReadLine();
            
            

            Console.WriteLine($"Digite o seu email:");
            email = Console.ReadLine();
            

            Console.WriteLine($"Digite a sua senha:");
            senha = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"Digite o seu codigo:");
            codigo = int.Parse(Console.ReadLine());

            
            return "Cadastro com sucesso";
            
            
            
            
        }
        public string Deletar(Usuario a){

            
        }
    }
}