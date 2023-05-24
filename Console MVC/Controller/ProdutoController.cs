using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void ListaProdutos(){
        // chamada da model trazendo a lista
        List<Produto> produtos = produto.Ler();
        // chamada da view passando a lista
        produtoView.Listar(produtos);

        }
    }
}