// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  array uma  variavel que pode guardar varios valores

// string[] carros = new string [4];
// Console.WriteLine($"Digite o nome do carro:");

// carros[0] = Console.ReadLine();
// Console.WriteLine($"Primeiro carro da lista :{carros[0]}");
// carros[1] = Console.ReadLine();
// Console.WriteLine($"Segundo carro da lista :{carros[1]}");
// carros[2] = Console.ReadLine();
// Console.WriteLine($"Terceiro carro da lista :{carros[2]}");
// carros[3] = Console.ReadLine();
// Console.WriteLine($"Ultimo carro da lista :{carros[3]}");



string[]carros = new string [3];

for (int i = 0; i < 3 ; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome do carro:");
   carros[i] = Console.ReadLine()!;

  
    
}
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
    
}

// foreach (string carro in carros)
// {
//     Console.WriteLine($"Nome do carro: {carro}");
    
// }  

// O primeiro carro e : corsa








