using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produto
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nomeProduto { get; set; }
        public float preco { get; set; }
        public DateTime dataCadastro { get; set; }
        public Marca marca { get; set; }
        public Usuario cadastradoPor { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public string Cadastrar(Produto a){

        }
        public void List(Produto){
            
        }
        public string Deletar(Produto a){

        }

    }
}