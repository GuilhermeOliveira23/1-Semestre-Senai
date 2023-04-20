
//variáveis
char continuarPrograma =' ';
string[] nomes = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];

MostrarMenu:
Console.ForegroundColor = ConsoleColor.DarkBlue;

  Console.WriteLine(@$"Escolha o que deseja fazer:
---------------------------------------------
|                                           |           
|          (1) Cadastrar Produtos           |    
|          (2) Listar Produtos              |
|          (0) Sair                         |
|                                           |
|                                           |
|                                           |
---------------------------------------------


");
Console.ResetColor();
string numero = Console.ReadLine()!; 

switch (numero)
{
    case "1":

    CadastrarDenovo:
    for (var i = 0; i < 1; i++)
    {
        
        Console.WriteLine($"Digite o nome de seu produto:");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Digite o valor unitário do seu produto:");
        preco[i] = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"Informe se ele terá promoção ou não: [s/n]");
        char aplicaPromocao = char.Parse(Console.ReadLine()!.ToUpper());  
        promocao[i] = aplicaPromocao == 'S' ?  true :  false;
              
        
    }
        Console.WriteLine($"Deseja cadastrar um novo produto? [s/n]");
        continuarPrograma = char.Parse(Console.ReadLine()!.ToUpper());

     if (continuarPrograma == 'S' ){
            goto CadastrarDenovo;
        }
        else {goto MostrarMenu;};
        
        
        
   

    case "2":
     Console.Clear();
    for (var i = 0; i < 10; i++)
    {
       
        Console.WriteLine($"{i + 1}º)Nome do produto: {nomes[i]}");     
        Console.WriteLine($"Preço: {preco[i]}R$");

        Console.WriteLine(promocao[i] == true? "Promoção: Terá promoção": "Promoção: Não terá promoção");
        Console.WriteLine($"");
        
             
    }

    break;
    case "0" : 
    Environment.Exit(0);

    break;
        
    default:
    Console.WriteLine($"Valor inválido");
    
    goto MostrarMenu;        
}