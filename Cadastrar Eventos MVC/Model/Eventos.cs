using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastrar_Eventos_MVC.Model
{
    public class Eventos
    {
    
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }

private const string PATH = "Database/Eventos.csv";
public Eventos(){
    string pasta = PATH.Split("/")[0];
    if (!Directory.Exists(pasta))
    {
        Directory.CreateDirectory(pasta);
    }
    if (!File.Exists(PATH))
    {
        File.Create(PATH);
    }
}
    
public List<Eventos> Ler(){
List<Eventos> eventos = new List<Eventos>();

string[] linhas = File.ReadAllLines(PATH);

foreach (var item in linhas)
{
    string[] atributos = item.Split(";");
    Eventos evento = new Eventos();

    evento.Nome = atributos[0];
    evento.Data = DateTime.Parse(atributos[1]);
    evento.Descricao = (atributos[2]);

    eventos.Add(evento);
    
}
return eventos;
}


public string PrepararLinhasCSV(Eventos evento){

    return $"{evento.Nome}; {evento.Data}; {evento.Descricao}";

}

public void Inserir(Eventos evento){
string[] linhas = {PrepararLinhasCSV(evento)};
File.AppendAllLines(PATH,linhas);

}





    }
}