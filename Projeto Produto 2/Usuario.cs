using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_2
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario()
        {
            Cadastrar();
        }
        public Usuario(string b){

        }

        public void Cadastrar()
        {   

        

            Console.WriteLine($"Insira o seu nome:");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"Insira o seu email:");
            this.Email= Console.ReadLine();
            
            Console.WriteLine($"Insira a sua senha:");
            this.Senha = Console.ReadLine();

            
            
            this.DataCadastro = DateTime.UtcNow;
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email= "";
            this.Senha = "";
            

        }       
    }
}