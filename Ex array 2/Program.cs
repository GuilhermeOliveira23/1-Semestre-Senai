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



string []nomePessoas = new string [5];
int []idadePessoas = new int [5];

Console.ForegroundColor = ConsoleColor.Blue;



for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome do {i+1}º participante");
   nomePessoas[i] = Console.ReadLine()!;
   
   Console.WriteLine($"Digite a idade do {i+1}º participante");
   idadePessoas[i] = int.Parse(Console.ReadLine()!);
   
   
   
    
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1} Nome");
    
    
}


