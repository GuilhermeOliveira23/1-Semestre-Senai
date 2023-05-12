using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public interface IContatoComercial
    {
        public  bool ValidarCnpj(string _cpf); // - quantidade caracteres(14)
        
    }
}