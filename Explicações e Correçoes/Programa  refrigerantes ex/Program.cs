//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

//porcionato lovers <3




Console.WriteLine(@$"

Insira a bebida que deseja:

-------------------------
|                       |
|                       |
|        Pepsi          |
|        Coca-cola      |
|        Monster        |
|        Fanta          |
|                       |
|                       |
-------------------------
");


string resposta1 = Console.ReadLine()!.ToUpper();


switch (resposta1)
{


    case "FANTA":
        Console.WriteLine($"Gostaria de adicionar gelo a sua fanta?");
        string resposta2 = Console.ReadLine()!.ToUpper();

        if (resposta2 == "SIM")
        {
            Console.WriteLine($"Sua bebida será adicional com gelo");

        }
        else
        {
            Console.WriteLine($"Sua bebida é sem gelo adicional");

        }



        break;

    case "COCA-COLA":

        Console.WriteLine($"Gostaria de adicionar gelo a sua Coca-cola?");
        string resposta3 = Console.ReadLine()!.ToUpper();
        if (resposta3 == "SIM")
        {
            Console.WriteLine($"Sua Coca-cola será adicional com gelo");

        }
        else
        {
            Console.WriteLine($"Sua Coca-cola é sem gelo adicional");

        }



        break;

    case "MONSTER":

        Console.WriteLine($"Gostaria de adicionar gelo ao seu Monster?");
        string resposta4 = Console.ReadLine()!.ToUpper();
        if (resposta4 == "SIM")
        {
            Console.WriteLine($"Seu Monster será adicional com gelo");

        }
        else
        {
            Console.WriteLine($"Seu Monster é sem gelo adicional");

        }


        break;

    case "PEPSI":

        Console.WriteLine($"Gostaria de adicionar gelo a sua Pepsi?");
        string resposta5 = Console.ReadLine()!.ToUpper();

        if (resposta5 == "SIM")
        {
            Console.WriteLine($"Sua Pepsi será adicional com gelo");

        }
        else
        {
            Console.WriteLine($"Sua Pepsi é sem gelo adicional");

        }


        break;




}

