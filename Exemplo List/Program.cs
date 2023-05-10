using Exemplo_List;

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add(
    new Produto(1025,"Tenis Naiki", 50f)
);

Produto calcaDiesel = new Produto(1526,"calca Disel Calo", 15f);
produtos.Add(calcaDiesel);
foreach (var item in produtos)
{
    Console.WriteLine($"{item.codigo}, {item.nome}, {item.preco} {produtos.IndexOf(item)}");
    
}


 Produto produtoBuscado = produtos.Find(x => x.codigo == 2536)!;

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);
Console.WriteLine($"Lista atualizada");


foreach (var item in produtos)
{
    Console.WriteLine($"{item.codigo}, {item.nome}, {item.preco} {produtos.IndexOf(item)}");
    
}

// Produto produto = new Produto();
// Produto pr = new Produto(produto.codigo,produto.nome, produto.preco);