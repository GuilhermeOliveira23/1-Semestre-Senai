using Sistema_POO_Calculadora;
float n1 = 0f;
 float n2 = 0f;
 Calculadora cl = new Calculadora();
 

Console.WriteLine($"Digite o primeiro Valor:");
n1 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o primeiro Valor:");
n2 = float.Parse(Console.ReadLine()!);

float resultadoDividir = Calculadora.Dividir(n1,n2);
float resultadoSomar = Calculadora.Somar(n1,n2);
float resultadoMultiplicar = Calculadora.Multiplicar(n1,n2);
float resultadoSubtrair = Calculadora.Subtrair(n1,n2);



    Console.WriteLine(@$"Insira a operação que deseja realizar:
-------------------------------------  
|                                   |   
|           [+]Soma                 |
|           [-]Subtração            |
|           [x]Multiplicação        |
|           [/]Divisão              |
|                                   |
|                                   |
-------------------------------------

    ");

// Rótulo do Goto
MostrarMenu:

string  operacao =   Console.ReadLine()!;
switch (operacao)
{
    case "+":
    Console.WriteLine($"O resultado dessa Soma é {resultadoSomar}");
    
        break;
    case "x":
    Console.WriteLine($"O resultado dessa multiplicação é {resultadoMultiplicar}");
    
        break;
    case "-":
    Console.WriteLine($"O resultado dessa Subtração é {resultadoSubtrair}");
    
        break;
    case "/":
   Console.WriteLine($"O Resultado dessa divisão é {resultadoDividir}");
   
        break;
    default:
    Console.WriteLine($"Valor inválido!!! Digite novamente:");
    goto MostrarMenu;
      
}

