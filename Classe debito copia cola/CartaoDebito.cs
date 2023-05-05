using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_debito_copia_cola
{
    public class CartaoDebito
    {
    public float valor;
    public bool Debito;

    static float CalculoDebito(float a, float b, bool c){
      float resultado = a - b;
      return  resultado;
    } 
    static void TipoCartao(string cartao, bool debito){
        Console.WriteLine($"Cartão de Crédito ou Débito?");
        cartao = Console.ReadLine()!.ToUpper();
        if (cartao == "D")
        {
          debito = true;
        }else{ debito=false; };
        
        
    }
    }
}