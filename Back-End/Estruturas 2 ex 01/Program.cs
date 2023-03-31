Console.WriteLine($"Digite o dia do seu aniversário");
int dias = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mês do seu aniversário");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite o ano do seu aniversário");
int ano = int.Parse(Console.ReadLine());


if (dias > 31){
    Console.WriteLine($"Data inválida");
    
}
 else if (mes>13){
    Console.WriteLine($"Data inválida");
    

}
else if (ano>2013){
    Console.WriteLine($"Data inválida");
    
}
else {
    Console.WriteLine($"Sua data é válida");
    
}