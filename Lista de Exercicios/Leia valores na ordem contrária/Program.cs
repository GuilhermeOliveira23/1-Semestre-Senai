// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

int[] Numeros = new int[15];

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Insira o {i+1}º número:");
    Numeros[i] = int.Parse(Console.ReadLine()!);
    
}
Console.WriteLine("");

Console.WriteLine($"Na ordem reversa:");




for (int i = 14; i >= 0; i--)
{
    Console.WriteLine(Numeros[i]);
    
}