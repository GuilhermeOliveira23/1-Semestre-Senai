using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Estática_Dinheiro
{
    public static class ConversorDinheiro
    {
     public static float valor { get; set; }

    public static float ConversorMoedas(float MoedaASerConvertida,float MoedaEmQueVaiConverter){

      float resultado =  MoedaASerConvertida / MoedaEmQueVaiConverter;
      return resultado;

    }
    public static float ConversorMoedasReal(float a , float b){

        float resultado = a * b;
        return resultado;
    }

    }
}