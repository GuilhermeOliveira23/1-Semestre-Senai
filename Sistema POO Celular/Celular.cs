using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_POO_Celular
{
    public class Celular
    {
    public string cor = "";
    public string modelo = "";
    public float tamanho = 0f;
    public bool ligado = false;


    public  static bool Ligar(bool a){
        
        return true;
        
    }
    public static bool Desligar(bool a){
        
      if (a == true)
      {
        Console.WriteLine($"Desligando o celular");
        a = false;
        return a;
        
      }
      else{

        Console.WriteLine($"Celular já está ligado");
        return a;
      }
       
        
    }
    public static  void FazerLigacao(bool a){
       Console.WriteLine(a == true? "Fazendo a ligação": "Celular esta desligado!!");
        
        
        
    }
    public static void EnviarMensagem(bool a ){
        Console.WriteLine(a == true? "Mensagem foi enviada": "Celular esta desligado!!");
        
        
    }

    }
}