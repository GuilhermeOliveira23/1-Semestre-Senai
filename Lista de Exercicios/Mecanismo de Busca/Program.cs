// //6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] listaNomes = new string[10];
int Encontrado = 0;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i+1}º Nome:");
    listaNomes[i] = Console.ReadLine()!.ToUpper();
    
    
    
}

Console.WriteLine($"Digite o nome que deseja encontrar:");
string nomeBusca = Console.ReadLine()!.ToUpper();



for (int i = 0; i < 10; i++)
{
    
    if (nomeBusca == listaNomes[i])
    {
        Encontrado ++; 
        
    } 
}


switch (Encontrado)
{
   case 1:
   
    Console.WriteLine($"ACHEII!!!");
    Environment.Exit(0);
   
   break;

    default:
    if(Encontrado > 1){
    Console.WriteLine($"Encontrei {Encontrado} nomes correspondentes");
    }
    else
    {
        Console.WriteLine($"Não encontrei nenhum nome correspondente!!!");
        
    }
    break;
}








