// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.




int idadeValorFem = 0;
int idadeValorMas = 0;
int sexoValorFem = 0;
int sexoValorMas = 0;

int pesoValor = 0;

for (int i = 0; i <=10; i++)
{
    Console.WriteLine($"Digite sua idade");
int idade = int.Parse(Console.ReadLine()!.ToUpper());
if (idade > 0){
    idadeValor = 1;
}
    

Console.WriteLine(@$"Qual e o seu genero?
Responda(M) para masculino e (F) para feminino");
char genero = char.Parse(Console.ReadLine()!.ToUpper());

if (genero == 'M'){
    sexoValorMas ++;
}
if(genero == 'F'){
    sexoValorFem ++;
}



Console.WriteLine($"Qual e o seu peso?");
 float peso = float.Parse(Console.ReadLine()!.ToUpper());

 
 
}


Console.WriteLine($"O total de homens é {sexoValorMas}, e o de mulheres é {sexoValorfem} ");








// Console.WriteLine($"Digite sua idade?");
// int idade = int.Parse(Console.ReadLine()!.ToUpper());

// Console.WriteLine(@$"Qual e o seu genero?
// Responda(M) para masculino e (F) para feminino");
// char genero = char.Parse(Console.ReadLine()!.ToUpper());

// Console.WriteLine($"Qual e o seu peso?");
//  float peso = float.Parse(Console.ReadLine()!.ToUpper());

// Algoritmo

// Saber idade do entrevistado
// Saber peso do entrevistado
// Saber sexo do entrevistado

// Calcular total de homens
// Calcular idade média dos homens

// Calcular total de mulheres
// Calcular idade média dos mulheres

// Declarar variáveis

// int idade;
// float peso ;
// char sexo ;

// int totalHomem = 0;
// int idadeHomem = 0;

// int totalMulher = 0;
// int idadeMulher = 0;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"Informe sua idade :");
//     idade = int.Parse(Console.ReadLine());

//     Console.WriteLine($"Informe seu peso :");
//     peso = float.Parse(Console.ReadLine());

//     Console.WriteLine(@$"Informe seu sexo:
//     (M) - Masculino
//     (F) - Feminino");
//     // sexo = char.Parse(Console.ReadLine());

// do
// {
//      sexo = char.Parse(Console.ReadLine());
//     if (sexo == 'f')
//     {
//         totalMulher++;
//         idadeMulher+= idade;
//     }
//     else if(sexo == 'm')
//     {
//         totalHomem++;
//         idadeHomem+= idade;
//     }
//     else
//     {
//         Console.WriteLine($"Sexo incorreto ! Informe novamente");
        
//     }

// } while (sexo != 'f' && sexo != 'm');


// }


// Console.WriteLine(@$"
// Total de Homens: {totalHomem}
// Total de Mulheres: {totalMulher}
// ---------------------------------
// Média idade homens : {idadeHomem / totalHomem} anos
// Média idade homens : {idadeMulher / totalMulher} anos

// ");







