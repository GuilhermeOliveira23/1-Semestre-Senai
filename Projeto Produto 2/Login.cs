using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_2
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
                 
            Usuario user = new Usuario();
            
            Console.WriteLine($"Deseja Deletar o seu Cadastro?[s/n]");
            string DeletarCadastro = Console.ReadLine().ToUpper();
            

           if (DeletarCadastro == "S" )
           {
            user.Deletar();

            user.Cadastrar();
            
            Console.WriteLine($"Cadastre-se novamente!");

            
           }
           
            

            

            
            Logar(user);
        
            

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            
            Console.WriteLine($"Insira seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar !");
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {

            // Usuario user = new Usuario("aa");
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca
            ---------------------
            [7] Remover Cadastro

            [0] - Sair
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        
                        produto.Cadastrar();
                        break;
                    case "2":
                        
                        produto.Listar();
                        break;
                    case "3":
                        
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        
                        marca.Cadastrar();
                        break;
                    case "5":
                        
                        marca.Listar();
                        break;
                    case "6":
                        
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;

                        // case "7":
                        // user.Deletar();

                        // break;
                    case "0":
                        
                        Console.WriteLine($"App encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao != "0");

        }
    }
}