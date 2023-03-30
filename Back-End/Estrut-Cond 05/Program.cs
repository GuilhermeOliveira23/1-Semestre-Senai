float preco = 0.30f;
int quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12 )
{
  preco = 0.25f;
}

Console.WriteLine($"(quantidade * preco)");

