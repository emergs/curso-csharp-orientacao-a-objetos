class Estoque
{
  private readonly List<Produto> produtos = new List<Produto>();

  public void AdicionarProduto(Produto produto)
  {
    produtos.Add(produto);
  }

  public void ExibeProdutos()
  {
    foreach (var prod in produtos)
    {
      System.Console.WriteLine($"Produto: {prod.Nome}");
      System.Console.WriteLine($"Valor: {prod.Valor}");
    }
  }
}