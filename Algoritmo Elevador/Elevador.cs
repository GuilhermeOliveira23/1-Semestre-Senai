using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoritmoElevador
{
    public class Elevador
    {
        public int terreo { get; set; } = 0;
        public int totalAndares { get; private set; } = 10;
        public int capacidadePessoas { get; private set; } = 6;
        public int PessoasElevador { get; set; }
        public int andarAtual { get; set; } = 0;
    public void Inicializa(int capacidadeElevador , int totalAndares){
      
        Console.WriteLine($"Existem {totalAndares} andares neste predio, e o elevador possui capacidade máxima de {capacidadeElevador} pessoas");
        
    }

    
       public void Sair(){

        if (PessoasElevador != 0)
        {
            PessoasElevador -=1;
        }
        else{
            Console.WriteLine($"Não tem ninguém no elevador");
            
       }
        

        }
      public void Subir(){
       if (andarAtual <10)
       {
        andarAtual +=1;
       }
       else{Console.WriteLine($"Você já está no último andar!!!");
       }
        

        }
      public void Descer(){
        if (andarAtual != 0)
        {
            andarAtual -=1;
        }
        else{
            Console.WriteLine($"Não há como descer mais do que isso");
            
        }
        
        

        }
      public void Entrar(){

     
    if (PessoasElevador < 6)
        {
            PessoasElevador +=1;
        }
        else{
            Console.WriteLine($"Elevador está cheio!!!");
            
       }
    
      
      } 
        
        
    }
        
      


    }
