//exercicio de fixacao

//escreva um programa que receba e imprima o nome e idade de 5 pessoas

//personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//exemplo de exibicao:

//1) nome : Carlos
//idade : 36 anos

//2) nome : Eduardo
//idade: 40 anos

//3) nome : Allan
//idade : 40 anos

//4) nome: Julia
//idade : 18 anos

// Escreva um programa que receba e imprima o nome e idade de 5 pessoas (mude a cor do resultado)

string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++) {
    Console.Write($"Digite o nome da {i + 1}º pessoa: ");
    nomes[i] = Console.ReadLine()!;

    Console.Write($"Digite a idade da {i + 1}º pessoa: ");
    idades[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++) {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{i + 1}) Nome: {nomes[i]}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Idade: {idades[i]} anos");
}

