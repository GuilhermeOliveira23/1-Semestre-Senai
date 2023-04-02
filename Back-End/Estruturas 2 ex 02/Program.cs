Console.WriteLine($"Insira o primeiro número");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Insira o segundo número");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Insira o terceiro número");
int n3 = int.Parse(Console.ReadLine()!);

int maior = n1;
int menor = n1;

if (n2 > maior){
    maior=n2;
    
}
if (n2 < menor){
    menor=n2;
    
}

if (n3 > maior){
    maior=n3;
    
}
if (n3 < menor){
    menor=n3;
    
}

Console.WriteLine($"O maior número é " + maior);
Console.WriteLine($"O menor número é " + menor);



 
