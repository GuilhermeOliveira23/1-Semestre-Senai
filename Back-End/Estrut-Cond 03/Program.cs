Console.WriteLine($"Digite o primeiro lado do triângulo");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo lado do triângulo");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro lado do triângulo");
int n3 = int.Parse(Console.ReadLine());

if (n1 == n2 && n2 == n3){
    Console.WriteLine($"É um triângulo Equilátero");
    
}
else if (n1 == n2 || n2 == n3){
Console.WriteLine($"É um triangulo Isósceles");

}
else {
    Console.WriteLine($"É um triângulo Escaleno");
    
}


