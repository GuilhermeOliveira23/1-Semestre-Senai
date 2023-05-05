using Sistema_POO_Celular;


Celular cel = new Celular();
string voltar ="";

Console.WriteLine($"Qual é o modelo do seu celular?");
cel.modelo = Console.ReadLine();
Console.WriteLine($"Qual é a cor do seu celular?");
cel.cor = Console.ReadLine();
Console.WriteLine($"Qual é o tamanho do seu celular?");
cel.tamanho = float.Parse(Console.ReadLine());

 bool resultadoDesligar = Celular.Desligar(cel.ligado);
 bool resultadoLigar = Celular.Ligar(cel.ligado);

menu :
Console.WriteLine(@$"O que deseja fazer? Digite[1/2/3/4/5]
---------------------------------
|                               |
|      1)Listar Celular         |      
|      2)Ligar o celular        |
|      3)Telefonar alguém       |
|      4)Enviar uma mensagem    |
|      5)Desligar o Celular     |
|      0)Sair                   |
|                               |
---------------------------------                             
");

string escolha  = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine($"Modelo: {cel.modelo}");
        Console.WriteLine($"Cor: {cel.cor}");
        Console.WriteLine($"Tamanho: {cel.tamanho}");
        break;
    case "2":
    if (cel.ligado == true)
    {
        Console.WriteLine($"Celular já está ligado!!");
        
    }
    else{cel.ligado = resultadoLigar; Console.WriteLine($"Ligando celular");}
   
    break;
        
    case "3":
    if(cel.ligado == true){
        Celular.FazerLigacao(true);
    }
    else
    {
        Celular.FazerLigacao(false);
    }

    break;
        
    case "4":
if(cel.ligado == true){
        Celular.EnviarMensagem(true);
    }
    else
    {
        Celular.EnviarMensagem(false);
    }
    break;

        
    case "5":
    if (cel.ligado == false)
    {
        Console.WriteLine($"Celular já está Desligado!");
        
    }
    else{cel.ligado = resultadoDesligar; Console.WriteLine($"Desligando celular");}

    break;

        
    case "0":
    Environment.Exit(0);
        break;

        
    default:
    Console.WriteLine($"Valor inválido!");
    goto menu;
     
}


Console.WriteLine($"Deseja voltar ao menu?[s/n]");
         voltar = Console.ReadLine().ToUpper();
         if (voltar == "S")
         {
            goto menu;
         }
         else{Environment.Exit(0);}