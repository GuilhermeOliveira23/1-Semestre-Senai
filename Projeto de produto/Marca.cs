using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Marca
    {
        public int codigo { get; set; }
        public string nomeMarca { get; set; }
        public DateTime dataCadastro { get; set; }
        List<Marca> listaMarcas = new List<Marca>();
        public string Cadastrar(){


            Console.WriteLine($"Digite o nome da marca:");
            nomeMarca = Console.ReadLine();
            
            Console.WriteLine($"Digite o codigo da marca:");
            codigo = int.Parse(Console.ReadLine());
            dataCadastro = DateTime.Now;

            Marca marca = new Marca();
            
            marca.nomeMarca = nomeMarca;
            marca.codigo = codigo;

            listaMarcas.Add(marca);
            
            return "Marca Registrada";

            
            
        }
        public void Listar(){
            foreach (var item in listaMarcas)
            {
                Console.WriteLine($"Nome da marca: {item.nomeMarca}");
                Console.WriteLine($"Código da marca: {item.codigo}");
            }
            
            
        }
        public string Deletar(int Codigo){
      

            Marca p = listaMarcas.Find(x => x.codigo == Codigo);

            listaMarcas.Remove(p);


            return "Marca deletada com sucesso";


            
        }
        





    }
}