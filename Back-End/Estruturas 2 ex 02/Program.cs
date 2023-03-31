
Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o terceiro numero:");
float n3 =  float.Parse(Console.ReadLine());


if (n1 > n2 && n1 > n3){
    Console.WriteLine($"O primeiro número é o maior entre eles");
    
}
else if (n2 > n1 && n2 > n3){
    Console.WriteLine($"O segundo número é o maior entre eles");
    
}
else if (n3 > n1 && n3 > n2){
    Console.WriteLine($"O terceiro número é o maior entre eles");
    
}
else {
    Console.WriteLine($"Todos os números são iguais");
    
}

