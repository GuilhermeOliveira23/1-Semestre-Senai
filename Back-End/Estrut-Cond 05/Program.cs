float preco = 0.30f;
Console.WriteLine($"Quantas maças você deseja comprar?");

int quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12 )
{
  preco = 0.25f;
}

float compra = (quantidade * preco);
Console.WriteLine($"Sua compra vai custar {compra}R$");





