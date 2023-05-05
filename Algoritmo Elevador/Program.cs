


using AlgoritmoElevador;

Elevador elevador = new Elevador();
Console.WriteLine("");

elevador.Inicializa(elevador.capacidadePessoas,elevador.totalAndares);








retornar:

Console.WriteLine($@"Bem vindo ao Elevador!!! Escolha o que deseja fazer:
---------------------------------      
|                               |
|         [1] Subir             |
|         [2] Descer            |
|         [3] Entrar            |               
|         [4] Sair              |
|                               |
---------------------------------

Você está no andar {elevador.andarAtual}
e existem {elevador.PessoasElevador} pessoas neste elevador
        ");



    string escolha = Console.ReadLine();
        

        
        



        switch (escolha)
        {
            case "1":

            
            elevador.Subir();
            
                break;
                case "2":
                elevador.Descer();
                break;
                case "3":
                elevador.Entrar();
                break;
                case "4":
                elevador.Sair();
                break;
            default:
                break;
                
        }
        Console.WriteLine($"Continuar no elevador?[s/n]");
       string continuar = Console.ReadLine().ToUpper();
        
    if (continuar == "S")
    {
        goto retornar;
    }
    Console.WriteLine($"Saindo do elevador...");
    



        
        