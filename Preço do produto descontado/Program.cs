// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade  > 10 o desconto será de 5%
// Dica: utilize if / else if / else



// int resultado = Soma(6,7);

// Console.WriteLine(resultado);

//  static int Soma(int a, int b)
//     {
//         int resultado = a + b;
//         return resultado;
//     }

// static float ValorTotal(float a, float b){

//     float resultado1 = a - b;

//     return resultado1;



// }
Console.ForegroundColor = ConsoleColor.Blue;
float Desconto = 0f;
Console.WriteLine($"Insira o nome do produto:");
string Nome = Console.ReadLine()!;



Console.WriteLine($"Insira a quantidade adquirida do produto:");
int Quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o valor unitário do produto:");
float Preco = float.Parse(Console.ReadLine()!);
Console.ResetColor();

float resultado = Total(Quantidade , Preco);

static float Total(float a, float b){

    float resultado = a * b;

    return resultado;
}



float resultado2 = ValorTotal(resultado,Desconto);
static float ValorTotal(float a, float b){

float resultado2 = a - (a * b) ;

return resultado2;


}


if(Quantidade <= 5){
    Desconto = 0.02f;
}
else if(Quantidade >5 && Quantidade <=10){
    Desconto = 0.03f;
}
else
{
    Desconto = 0.05f;
}
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"O nome do seu produto: {Nome}
A quantidade do seu produto: {Quantidade}
O seu valor unitário: {Preco} R$
O valor final da sua compra: {resultado2}R$  ");
Console.ResetColor();

Console.WriteLine();


