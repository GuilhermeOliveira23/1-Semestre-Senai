using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_2
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }        
        List<Marca> listaDeMarcas = new List<Marca>();
        

        public string Cadastrar()
        {
            Marca marca = new Marca();            
           
            Console.WriteLine($"Digite o nome da marca:");
            marca.NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"Digite o codigo da marca:");
            marca.Codigo = int.Parse(Console.ReadLine());
            
            marca.DataCadastro = DateTime.UtcNow;

            listaDeMarcas.Add(marca);
            
            return "Marca Registrada";
        }

        public void Listar()
        {
            foreach (var item in listaDeMarcas)
            {
                
                Console.WriteLine($"Nome da marca: {item.NomeMarca}");
                Console.WriteLine($"Código da marca: {item.Codigo}");
                Console.WriteLine($"Data do cadastro: {item.DataCadastro}");
                
            }
        }

        public void Deletar(int codigo)
        {
        Marca m = listaDeMarcas.Find(x => x.Codigo == codigo);
        
        listaDeMarcas.Remove(m);
        


            
        }
    }
}