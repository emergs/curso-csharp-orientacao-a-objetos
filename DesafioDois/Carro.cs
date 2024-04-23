public class Carro
{
  private int ano;
  public string? Fabricante { get; set; }
  public string? Modelo { get; set; }
  public int Ano
  {
    get => ano;
    set
    {
      if (value < 1960 || value > 2023)
      {
        Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
      }
      else
      {
        ano = value;
      }
    }
  }
  public string? DescricaoDetalhada => $"Fabricante: {this.Fabricante}, Modelo: {this.Modelo}, Ano: {this.Ano}";
}