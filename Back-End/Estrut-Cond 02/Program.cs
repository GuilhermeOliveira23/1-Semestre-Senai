
Console.WriteLine($"Digite o placar do primeiro time");

int n1 = int.Parse(Console.ReadLine());


Console.WriteLine($"Digite o placar do segundo time");

int n2 = int.Parse(Console.ReadLine());


if (n1 == n2)
{
    Console.WriteLine($"Opa, parece que foi um empate");
    
}
else if (n1 > n2)
{


    Console.WriteLine($"O Primeiro time VENCEUUUU!!!");
    }
else {
    Console.WriteLine($"A Vitória é do SEGUNDO TIMEEEE!!!!");
    
}


