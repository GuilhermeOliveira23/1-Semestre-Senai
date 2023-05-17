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

           
           Console.WriteLine($"Digite o nome da marca:");
            NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"Digite o codigo da marca:");
            Codigo = int.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;

            Marca marca = new Marca();
            
            marca.NomeMarca = NomeMarca;
            marca.Codigo = Codigo;

            listaDeMarcas.Add(marca);
            
            return "Marca Registrada";
        }

        public void Listar()
        {
            foreach (var item in listaDeMarcas)
            {
                Console.WriteLine($"Nome da marca: {item.NomeMarca}");
                Console.WriteLine($"Código da marca: {item.Codigo}");
            }
        }

        public void Deletar(int codigo)
        {
        Marca p = listaDeMarcas.Find(x => x.Codigo == Codigo);

            listaDeMarcas.Remove(p);


            
        }
    }
}