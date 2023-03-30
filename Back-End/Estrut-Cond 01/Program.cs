// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Digite o orçamento que recebeu");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o quanto quer gastar");
float n2 = float.Parse(Console.ReadLine());

float eq = (n1-n2);


if (n1 < n2) {

    Console.WriteLine($"Orçamento estourado, faltará {-(n1-n2)}");
    
}
else if (n1 > n2) {
    Console.WriteLine($"Gastos dentro do orçamento, sobrará {(n1-n2)}");

}





