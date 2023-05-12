using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public class ContatoComercial : Contato , IContatoComercial
    {
        public string CNPJ { get; set; }

        public  bool ValidarCnpj(string _cpf){
            return false;
        }
        
    }
}