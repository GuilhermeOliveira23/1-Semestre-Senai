using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastrar_Eventos_MVC.Model;

namespace Cadastrar_Eventos_MVC.View
{
    public class EventosView
    {
        public void Listar(List<Eventos> evento){

foreach (var item in evento)
{
    Console.WriteLine($"Código: {item.Nome}");
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
    }
}