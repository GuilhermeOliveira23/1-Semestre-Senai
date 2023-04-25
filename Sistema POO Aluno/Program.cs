// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.
// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
// Crie uma classe Aluno com as seguintes propriedades:
// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 
// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade.
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade.
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
// Acrescente o que achar necessário.

 using Sistema_Orientado_a_objeto;
 float desconto = 1f;

 Aluno al = new Aluno();

Console.WriteLine($"Digite o nome do aluno");
 al.nome = Console.ReadLine();
 Console.WriteLine($"Digite o Curso do aluno");
 al.curso = Console.ReadLine();
 Console.WriteLine($"Digite a idade do aluno");
 al.idade = int.Parse(Console.ReadLine());
 Console.WriteLine($"Digite o RG do aluno");
 al.Rg = Console.ReadLine();
 Console.WriteLine($"Digite a média do aluno");
 al.media = int.Parse(Console.ReadLine());
 Console.WriteLine($"Digite o valor da mensalidade do aluno:");
  al.valorMensalidade = float.Parse(Console.ReadLine());

bool bolsista = Aluno.VerMediaFinal(al.media,al.bolsista);

if (al.media >= 8){
    desconto = 0.50f;
}
else if(al.media == 7){
    desconto = 0.30f;
}
float resultado = Aluno.VerMensalidade(al.valorMensalidade, desconto);


MostrarMenu:
 Console.WriteLine(@$"Insira o que deseja fazer:
-------------------------------------  
|                                   |   
|     [1]Visualizar Média           |
|     [2]Visualizar Mensalidade     |                                  |
|                                   |
-------------------------------------

    ");

// Rótulo do Goto


string  escolha =   Console.ReadLine()!;
switch (escolha)
{
    case "1":
    
    Console.WriteLine($"A sua média é {al.media}");
    
    
        break;
    case "2":
    Console.WriteLine($"O valor da sua mensalidade é {resultado}R$");
    
        break;
    case "0":
    Environment.Exit(0);
    break;
   
    default:
    Console.WriteLine($"Valor inválido!!! Digite novamente");
    
      break;
}
Console.WriteLine($"Deseja voltar ao menu? Digite [S/N]");
string menu = Console.ReadLine().ToUpper();


if(menu == "S"){
    goto MostrarMenu;
}
else
{
    Environment.Exit(0);
}































 

 
 
 
 










