using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Login
    {
        List<Produto>
    Produto produto = new Produto();
    Marca marca = new Marca();
    List<Marca> marcas = new List<Marca>();
        public bool logado { get; set; }

        // public Login(string email, string senha){
        //     email = "Free";
        //     senha = "1234";
        // }

        public  Login()
        {
            Console.WriteLine($"Digite o seu email:");
            string email = Console.ReadLine();
            voltar :
            Console.WriteLine($"Digite a sua senha:");
            string senha = Console.ReadLine();

            if (senha != "1234" || email != "Guilherme")
            {
                Console.WriteLine($"Errado, tente novamente");
               goto voltar; 
            }

            Console.WriteLine($@"Escolha o que deseja fazer
            
                [1] Cadastrar Produto
                [2] Listar Produto
                [3] Remover produto
                [4] Cadastrar usuario
                [5] Remover usuario
                [6]

            
            
            
            
            
            ");
            string opcao = Console.ReadLine()!;
            
            switch (opcao)
            {
                case "1":
                Console.WriteLine($"Nome do produto:");
                
                
                Console.WriteLine($"Marca do produto");
                marca.nomeMarca = Console.ReadLine();
                
               marcas.Add(marca.nomeMarca);

                Console.WriteLine($"Preco do produto");
                
                
                
                
                

                

                    break;
                case "2":

                    break;
                case "3":
                
                    break;
                case "4":

                    break;
                default:
                    break;
            }
            
        
            
        }

        public string Logar(Usuario){

        }
        public string Deslogar(Usuario){

        }
    }
}