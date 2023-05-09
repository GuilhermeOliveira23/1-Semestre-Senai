using System.Globalization;
using Classe_Estática_Dinheiro;


Console.WriteLine($"Insira um valor:");
ConversorDinheiro.valor = int.Parse(Console.ReadLine()!);

float resultado1 = ConversorDinheiro.ConversorMoedas(ConversorDinheiro.valor, 4.99f );
float resultado2 = ConversorDinheiro.ConversorMoedasReal(ConversorDinheiro.valor, 4.99f );

Retornar:
Console.WriteLine($@"Escolha a moeda que deseja converter: 
-------------------------
|                       |
|   [1]Dolar para Real  |
|   [2]Real para dolar  |
|                       |
-------------------------
");
string escolha = Console.ReadLine()!;
Console.Clear();

switch (escolha)
{
    case "1":

Console.WriteLine($"Valor em reais: " + resultado1.ToString("C"));
        break;
    case "2":

    Console.WriteLine($"Valor em dolares: " + resultado2.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
    

        break;
    default:

    Console.WriteLine($"Valor inválido, tente novamente");
    goto Retornar;
    
        
}



