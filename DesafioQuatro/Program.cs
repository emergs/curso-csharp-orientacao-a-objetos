Produto produto = new();
produto.Nome = "Bolacha";
produto.Valor = 30.00;

Produto produto1 = new();
produto1.Nome = "Pão";
produto1.Valor = 2.50;

Estoque estoque = new();
estoque.AdicionarProduto(produto);
estoque.AdicionarProduto(produto1);
estoque.ExibeProdutos();