using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string CPF { get; set; }
        public bool  IContatoPessoal(string _cnpj){
            return false;
        }
    }
}