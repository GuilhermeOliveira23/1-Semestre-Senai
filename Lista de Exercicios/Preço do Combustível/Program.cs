// // 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.




// float Litros = 0.0f;
// char Combustivel = 'a';
// int descontoCalculo = 0;
// float Alcool = 4.90f;
// float Gasolina = 5.30f;
// float Gasolina6 =(Gasolina-(0.06f * Gasolina)) ;
// float Gasolina4 =(Gasolina-(0.04f * Gasolina)) ;
// float Alcool5 = (Alcool-(0.05f * Alcool));
// float Alcool3 = (Alcool-(0.03f * Alcool));





// Console.WriteLine($"Digite a quantia de litros de combustível que deseja comprar:");

// Litros = int.Parse(Console.ReadLine()!);



// Console.WriteLine(@$"Escolha o tipo de combustível que deseja comprar: Digite (G/A)
// ------------------------------------
// |                                  |
// |           G-Gasolina             |
// |           A-Álcool               |
// |                                  |
// |                                  |
// ------------------------------------
// ");
// Combustivel = char.Parse(Console.ReadLine()!.ToUpper());
// if(Combustivel == 'G'){descontoCalculo ++;}
// else if(Combustivel == 'A'){descontoCalculo +=2;}

// // if(Litros>20){descontoCalculo ++;}

// switch (descontoCalculo)
// {
//     case 1:
//     if(Litros>20){
//         Console.WriteLine($"O valor da sua compra é de : {Litros * Gasolina6}");
        
//     }
//     else{
//         Console.WriteLine($"O valor da sua compra é: {Litros * Gasolina4}");
        
//     }

//     break;

//     case 2:

//     if(Litros > 20){

//     Console.WriteLine($"O valor da sua compra é : {Litros * Alcool5}");
//     }
//     else{

//         Console.WriteLine($"O valor da  sua compra é {Litros * Alcool3}");
        
//     }

//     break;
// }




using System.Globalization;

static float CalcularCombustivel(int opcaoCombustivel, int litros) {
    float precoLitro = 0;
    float desconto = 0;
    switch (opcaoCombustivel) {
        // Caso seja álcool
        case 1:
            precoLitro = 4.9F;
            desconto = precoLitro * (litros < 20 ? 0.03F : 0.05F);
            break;
        // Caso seja gasolina
        case 2:
            precoLitro = 5.3F;
            desconto = precoLitro * (litros < 20 ? 0.04F : 0.06F);
            break;
        default:
            break;
    }
    return (litros * (precoLitro - desconto));
}

Console.WriteLine($"    POSTO DE COMBUSTÍVEL");
Console.WriteLine(@$"
    Selecione um combustível:

    [1] Álcool
    [2] Gasolina
");

opcaoCombustivel:
Console.Write("Selecione uma opção: ");
int opcao = int.Parse(Console.ReadLine()!);

if (opcao != 1 && opcao != 2) {
    Console.WriteLine($"Opção inválida! Tente novamente.");
    goto opcaoCombustivel;
}

litros:
Console.Write($"Digite quantos litros de combustível você deseja: ");
int litros = int.Parse(Console.ReadLine()!);

if (litros < 0) {
    Console.WriteLine("Valor inválido! Tente novamente.");
    goto litros;
}

Console.WriteLine($"Valor total a se pagar: {CalcularCombustivel(opcao, litros).ToString("C", new CultureInfo("pt-BR"))}");



