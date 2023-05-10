using Exercicio_lista;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a marca do carro: ");
    carro.marca = Console.ReadLine();
    Console.WriteLine($"Informe a cor do carro: ");
    carro.cor = Console.ReadLine();
    
   carros.Add(carro); 
}


foreach (var item in carros)
{
    Console.WriteLine($"Marca: {item.marca}, Cor: {item.cor}");
    
}