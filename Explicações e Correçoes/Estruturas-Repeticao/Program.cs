// bool idadeCerta = false;

// while (idadeCerta == false) //while
// {
//     Console.WriteLine($"Qual a idade do Adulto Ney ? ");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 31)
//     {
//         idadeCerta = true;
//     }
    
    
// }

bool idadeCerta = false;

do
{

Console.WriteLine($"Qual a idade do Adulto Ney ?");
int idade =int.Parse(Console.ReadLine()!);

if (idade == 31)
{
    Console.WriteLine($"Acertou !!");
    idadeCerta = true;
    
}
else
{
    Console.WriteLine($"Errou feio ! Tente novamente ");
    
}
    


} while (idadeCerta == false);

// while quando  o cliente so vera o menu se tiver as condicoes necessarias
// do while quando deve ser mostrado as opcoes pelo menos uma vez menos se estiver falso