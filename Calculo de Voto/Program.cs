// Condicionais:
// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
int Ano = 0;
int anoAtual = DateTime.Now.Year;


Console.WriteLine($"Digite o ano em que nasceu");
Ano =  int.Parse(Console.ReadLine()!);

if((anoAtual - Ano) >= 18){
    Console.WriteLine($"Você pode votar esse ano!!!");
    

}
else{
    Console.WriteLine($"Você não pode votar esse ano!!!");
    
}

    
    


