using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime DataCadastro { get; set;}

        // List<Usuario> usuario  = new List<Usuario>();
        public Usuario()
        {
            Cadastrar();
        }
    

        public void Cadastrar()

        {
            Usuario user = new Usuario();


            this.nome = "Guilherme";
            this.email = "oliver";
            this.senha = "1234";
            this.codigo = 223;
            DataCadastro = DateTime.Now;
            

            
            
        }
        public string Deletar(Usuario a){

            nome = " ";
            email = " ";
            senha = " ";
            codigo = 0;
            DataCadastro = DateTime.Parse("000-00-00T00:00");
            
            return "Informações removidas";
        }
    }
}