// string nome = "";
// float preco = 0;
// bool promocao = false;



// static void Menu(){

    
// }

//Criar funcao MostrarMenu
//Criar funcao CadastrarProduto
//Criar funcao ListarProduto


Console.WriteLine(MostrarMenu());




string[] Nomes = new string[10];
float[] Precos = new float[10];
string[] Marca = new string[10];
int[] Quantidade = new int[10];

static void MostrarMenu(){

    Console.WriteLine(@$"Escolha o que deseja fazer : [Digite : 1/2/3]
----------------------------------  
|                                |
|       (1)Cadastrar Produto     |
|       (2)Listar Produto        |
|       (3)Sair                  |              
|                                |        
|                                |                                                                                                      
----------------------------------
");

string escolha = Console.ReadLine()!;

 }



static void CadastrarProduto(string escolha, string[]Nomes,float[] Precos , float[] Quantidade){


switch (escolha)
{
    case "1":
    for (var i = 0; i < 10; i++)
    {
        Console.WriteLine($"Nome do produto:");
        Nomes[i]= Console.ReadLine()!;
        
        Console.WriteLine($"Preco do produto:");
        Precos[i] = float.Parse(Console.ReadLine()!);    
        
        Console.WriteLine($"Quantia do produto:");
        Quantidade[i] = int.Parse(Console.ReadLine()!);     
        
        
    }
        break;
        case "2":
        for (int i = 0; i < 15; i++)
        {   
            Console.WriteLine($"{1 + i}º Produto:");
            Console.WriteLine($" Nome: {Nomes[i]}");
            Console.WriteLine($"Preco: {Precos[i]}");
            Console.WriteLine($"Quantidade: {Quantidade[i]}");
            
        }
        
        break;
        case "3": 
        break;
    default:
        break;
}



}

// if ternário



    

// string bola = "";
// string mamute = "a";



// static bool ValorMasculino(string a , string b){


// if (a == b)
// {
//     return true;
// }
// else{
//     Console.WriteLine($"Incorreto!!!");
    
//     return false;
// }

// };

// bool senhaValida =  ValorMasculino(mamute, bola);

