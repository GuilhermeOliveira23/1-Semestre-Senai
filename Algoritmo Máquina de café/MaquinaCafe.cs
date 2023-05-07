using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmo_Máquina_de_café
{
    public class MaquinaCafe
    {   public string quantidadeAcucar {get; set;} = "0";
        public int acucarDisponivel { get;  set; } = 200;
        public bool acucarSuficente {get; set;}


    public int FazerCafe(int quantidadeAcucar, int acucarDisponivel){
    
       int resultado = acucarDisponivel - quantidadeAcucar;
    
     
       return acucarDisponivel >= quantidadeAcucar ?  resultado : 0;
    }

    public void FazerCafe(){


    }



 

// int QuantAcucarint = int.Parse(quantidadeAcucar);
    }
}




