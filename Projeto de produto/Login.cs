using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Login
    {


        Marca marca = new Marca();
        List<Marca> marcas = new List<Marca>();
        public bool logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);





        }
    

    public void Logar(Usuario usuario)
    {
        Console.WriteLine($"Informe o email:");
        string emailDigitada = Console.ReadLine();
       
        Console.WriteLine($"Informe a senha:");
        string senhaDigitada = Console.ReadLine();

        if (emailDigitada == usuario.email && senhaDigitada == usuario.senha)
        {   
            this.logado = true;
            Console.WriteLine($"Login efetuado com sucesso");
            
        }
        else{
            logado = false;
            Console.WriteLine($"Falha ao logar");
            
        }
        

    }
    public void Deslogar()
    {
        logado = false;
    }
    public void MostrarMenu(Usuario a)
    {
       
    string opcao;
        Produto produto = new Produto();
        Marca marca = new Marca();
    do{
        Console.WriteLine($@"Escolha o que deseja fazer
            
                [1] Cadastrar Produto
                [2] Listar Produto
                [3] Remover produto
                -------------------
                [4] Cadastrar Marca
                [5] Listar Marca
                [6] Remover Marca            
            
            ");
        opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":

            produto.Cadastrar();







                break;
            case "2":
            produto.Listar();

                break;
            case "3":
            Console.WriteLine($"Informe o codigo a ser excluido:");
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
            Console.WriteLine($"Informe o codigo a ser excluido:");
            int codigoMarca = int.Parse(Console.ReadLine());
            
            marca.Deletar(codigoMarca);

                break;
                case "0":
                Console.WriteLine($"App encerrado");

                break;
                
            default:
            Console.WriteLine($"Opção inválida!!");
            
                break;
        }
    }while( opcao != "0");
    }
}
}