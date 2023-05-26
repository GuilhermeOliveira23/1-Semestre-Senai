using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastrar_Eventos_MVC.Model;
using Cadastrar_Eventos_MVC.View;

namespace Cadastrar_Eventos_MVC.Controller
{
    public class EventosController
    {
        Eventos evento = new Eventos();
        EventosView eventoView = new EventosView();
        public void ListarEventos(){

            List<Eventos> eventos = evento.Ler();

            eventoView.Listar(eventos);

        }

        public void Cadastrar(){ 
            Eventos  novoEvento = eventoView.Cadastrar();
            evento.Inserir(novoEvento);

        }

        public void MostrarMenu(){
            
        }

    }
}