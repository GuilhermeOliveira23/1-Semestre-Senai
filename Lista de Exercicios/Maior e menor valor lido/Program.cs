int []valorUsuario = new int[10];
int maiorValor = Math.Max(valorUsuario[0], valorUsuario[1]);
int menorValor = Math.Min(valorUsuario[0], valorUsuario[1]);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º valor");
    valorUsuario[i]  =  int.Parse(Console.ReadLine()!);
}


for (int i = 0; i < 10; i++)
{
    menorValor = Math.Min(menorValor, valorUsuario[i]);
    maiorValor = Math.Max(maiorValor, valorUsuario[i]);
}

Console.WriteLine($" Menor valor:{+ menorValor} e Maior valor: {+ maiorValor}");





//Função Math.Min/Max já faz a maior parte do trabalho, só é necessário declará-la no início


