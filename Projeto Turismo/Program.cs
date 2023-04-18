//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:

//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair
//Observação :  Criar ao menos uma função (Efetuar Login).

//Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N). 

const string senhaCorreta = "123456";
char continuarPrograma =' ';

string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

static bool EfetuarLogin(string senhaDigitada, string senhaCorreta)
{     
    if (senhaDigitada == senhaCorreta)
    {
        return true;
    }
    else
    {
        return false;
    }
};

 bool resultado = false;

do{

Console.WriteLine($"Digite sua senha");
string senha = Console.ReadLine()!;

resultado = EfetuarLogin(senha,senhaCorreta);


if (resultado != true)
{
    Console.WriteLine($"Senha invalida, tente novamente");
    
}



}while(resultado == false);





 menu: Console.WriteLine(@$"Escolha o que deseja fazer:
---------------------------------------------
|                                           |           
|          (1) Cadastrar Passagens          |    
|          (2) Listar Passagens             |
|          (0) Sair                         |
|                                           |
|                                           |
|                                           |
---------------------------------------------


");
int numero = int.Parse(Console.ReadLine()!); 
// era melhor ter usado string aqui, pois a escolha "int" faz com que a placa rode dois calculos ao inves de um





switch (numero)
{
    case 1:

    info:
    for (var i = 0; i < 5; i++)
    {
        
        Console.WriteLine($"Digite seu nome:");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Informe sua origem:");
        origem[i] = Console.ReadLine()!;

        Console.WriteLine($"Informe seu destino:");
        destino[i] = Console.ReadLine()!;

        Console.WriteLine($"Informe a data [dia/mes/ano]:");
        data[i] = Console.ReadLine()!;

        

        
        
              
        
    }
        Console.WriteLine($"Deseja cadastrar uma nova passagem? [s/n]");
        continuarPrograma = char.Parse(Console.ReadLine()!.ToUpper());
     if (continuarPrograma == 'S' ){
            goto info;
        }
        else {goto menu;};
        
        


    case 2:
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine(@$"{i + 1}º Nome: {nomes[i]}");     
        Console.WriteLine($"{i + 1}º Origem: {origem[i]}");   
        Console.WriteLine($"{i + 1}º Destino: {destino[i]}");   
        Console.WriteLine($"{i + 1}º Data: {data[i]}"); 
        Console.WriteLine($"");
        

    }

    break;
    case 0 : 
    Environment.Exit(0);

    break;
        
    default:
        break;
}

