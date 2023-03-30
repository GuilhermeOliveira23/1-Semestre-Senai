// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());
int meses = idade * 12;
int dias = meses * 30;
int horas = dias * 24;
int minutos = horas * 60;

Console.WriteLine($"Voce tem {idade} anos, {meses} meses, {dias} dias, {horas} horas, {minutos} minutos.");

