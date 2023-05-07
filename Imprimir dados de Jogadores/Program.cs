using Imprimir_dados_de_Jogadores;

JogadorDefesa jgd = new JogadorDefesa();
JogadorAtaque jga = new JogadorAtaque();
JogadorMeio_Campo jgm = new JogadorMeio_Campo();

Voltar:
Console.WriteLine($@"Jogador joga em que posição? 

[1]Ataque
[2]Defesa
[3]Meio-Campo

");
string posicao = Console.ReadLine();

switch (posicao)
{
    case "1":

    Console.WriteLine($"Insira o nome do jogador");
    jga.nome = Console.ReadLine();
    Console.WriteLine($"Insira a data de nascimento do jogador");   
    jga.datadenascimento = Console.ReadLine();
    Console.WriteLine($"Insira a nacionalidade do jogador");   
    jga.nacionalidade = Console.ReadLine();
    Console.WriteLine($"Insira a altura do jogador");   
    jga.altura = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira o peso do jogador");   
    jga.peso = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira a idade do jogador");   
    jga.idade = int.Parse(Console.ReadLine());
Console.Clear();
    int resultado1 = jga.calcularIdade(jga.idade);
    jga.TempoAposentar(resultado1);
    Console.WriteLine($"");
    
    jga.ImprimirDados(jga.nome,jga.datadenascimento,jga.nacionalidade, jga.altura, jga.peso, jga.idade);
    Console.WriteLine($"");
    

    
        break;
    case "2":
    Console.WriteLine($"Insira o nome do jogador");
    jgd.nome = Console.ReadLine();
    Console.WriteLine($"Insira a data de nascimento do jogador");   
    jgd.datadenascimento = Console.ReadLine();
    Console.WriteLine($"Insira a nacionalidade do jogador");   
    jgd.nacionalidade = Console.ReadLine();
    Console.WriteLine($"Insira a altura do jogador");   
    jgd.altura = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira o peso do jogador");   
    jgd.peso = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira a idade do jogador");   
    jgd.idade = int.Parse(Console.ReadLine());
Console.Clear();
    int resultado2 = jgd.calcularIdade(jgd.idade);
    jgd.TempoAposentar(resultado2);
    Console.WriteLine($"");
    
     jgd.ImprimirDados(jgd.nome,jgd.datadenascimento,jgd.nacionalidade, jgd.altura, jgd.peso, jgd.idade);;
     Console.WriteLine($"");
     
        break;

    case "3":
    Console.WriteLine($"Insira o nome do jogador");
    jgm.nome = Console.ReadLine();
    Console.WriteLine($"Insira a data de nascimento do jogador");   
    jgm.datadenascimento = Console.ReadLine();
    Console.WriteLine($"Insira a nacionalidade do jogador");   
    jgm.nacionalidade = Console.ReadLine();
    Console.WriteLine($"Insira a altura do jogador");   
    jgm.altura = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira o peso do jogador");   
    jgm.peso = float.Parse(Console.ReadLine());
    Console.WriteLine($"Insira a idade do jogador");   
    jgm.idade = int.Parse(Console.ReadLine());
    Console.Clear();
    

    int resultado3 = jgm.calcularIdade(jgm.idade);
    jgm.TempoAposentar(resultado3);
    Console.WriteLine($"");
    
     jgm.ImprimirDados(jgm.nome,jgm.datadenascimento,jgm.nacionalidade, jgm.altura, jgm.peso, jgm.idade);
     Console.WriteLine($"");
     
        break;
    default:
    Console.WriteLine($"Valor inválido, tente novamente");
    
    goto Voltar;
        
}
