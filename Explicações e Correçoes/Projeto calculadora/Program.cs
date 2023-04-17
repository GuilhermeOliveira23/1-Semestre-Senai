//calculadora
//algoritmo
//1. informar a operacao
//2. informar o primeiro numero
//3. informar o segundo numero
//4. processar os dados
//5. exibir resultado


//entrada
Console.WriteLine(@$"
 --------------------------
| Programa de calculadora  |
|                          |
|     Informe a Operacao   |
|                          |
|      (+) soma            |
|      (-) subtracao       |
|      (*) multiplicacao   |
|      (/) divisao         |
----------------------------
");
char operacao = char.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o primeiro numero");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o segundo numero");
double num2 = double.Parse(Console.ReadLine()!);
double resultado = 0;


switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"O resultado da soma e igual : {resultado} ");
        break;
    case '-':
        resultado = num1 - num2;
        Console.WriteLine($"O resultado da subtracao e igual: {resultado}");

        break;

    case '*':
        resultado = num1 * num2;
        Console.WriteLine($"O resultado da multiplicacao e igual: {resultado}");
        break;

    case '/':
        resultado = num1 / num2;
        Console.WriteLine($"O resultado da divisao e igual: {resultado}");
        break;

    default:
        Console.WriteLine($"Operacao invalida, repita o processo");

        break;
}








//processamento


//saida
