// deve ter um nome, um metodo para adicionar banda e exibir a discografia

class Banda
{
    private List<Album> albuns = new List<Album>();
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine("\n");
        foreach (var discografia in albuns)
        {
            System.Console.WriteLine(discografia.Nome);
        }
    }
}