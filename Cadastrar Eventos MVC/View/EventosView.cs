using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastrar_Eventos_MVC.Controller;
using Cadastrar_Eventos_MVC.Model;

namespace Cadastrar_Eventos_MVC.View
{
    public class EventosView
    {
        public void Listar(List<Eventos> evento){
Console.Clear();
foreach (var item in evento)
{
    Console.WriteLine($"Nome: {item.Nome}");
    Console.WriteLine($"Data: {item.Data}");
    Console.WriteLine($"Descrição: {item.Descricao}");
    Console.WriteLine($"");
    
    
}

        }


        public Eventos Cadastrar(){
            Eventos novoEvento = new Eventos();
            Console.WriteLine($"Insira o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            
            Console.WriteLine($"Insira a data do evento:");
            novoEvento.Data = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine($"Insira a Descrição do evento:");
            novoEvento.Descricao = Console.ReadLine();
            
            return novoEvento;
            
        }
        public void GerarMenu(){
            EventosController eventosController = new EventosController();

            Console.WriteLine($"O que deseja fazer?");
            Console.WriteLine($@"
          ------------MENU------------
        ||                           ||
        ||   [1]Cadastrar Evento     ||
        ||   [2]Listar Eventos       ||
        ||   [0]Sair do programa     ||
        ||                           ||
          ----------------------------
                ");
             string opcao =    Console.ReadLine();
             switch (opcao)
             {
                case "1":
                eventosController.Cadastrar();
                    break;
                case "2":
                eventosController.ListarEventos();
                    break;
                case "0":
                Environment.Exit(0);
                    break;
                default:
                Console.WriteLine($"Valor inválido!!");
                
                    break;
             }
             GerarMenu();
             
                
           
            
            

        }
    }
}