Console.WriteLine($"Digite o ano de nascimento da pessoa: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

//modulo para receber a data atual
int anoAtual = DateTime.Now.Year;

Console.WriteLine(anoAtual);

//Calcular a idade da pessoa
int idade = anoAtual - anoNascimento;
int idadeSemana = idade * 52; // 52 numero de semanas 

Console.WriteLine(@$"Idade: {idade} anos
Idade em semanas: {idadeSemana} semanas");