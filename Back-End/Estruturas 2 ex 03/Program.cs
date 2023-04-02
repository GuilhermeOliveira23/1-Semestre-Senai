Console.WriteLine($"Insira o raio da circunferência:");
int raio = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Seu diâmetro é " +(raio * 2));

Console.WriteLine($"Seu comprimento é "+(2 * ((float)Math.PI) * (raio)));
Console.WriteLine($"Sua área é " +(Math.PI * (raio * raio)));


