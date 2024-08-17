// deve ter um nome, Banda, duração, disponivel, descrição resumida, e metodos para Exibir a ficha técnica

class Musica
{
    public Musica(Banda banda, string nome)
    {
        Banda = banda;
        Nome = nome;
    }
    public Banda Banda { get; }
    public string Nome { get; }    
    public int Duracao { get; set; }
    public bool disponivel { get; set; }    
    public string DescicaoResumida => $"Banda: {this.Banda.Nome}, Música: {this.Nome}";

    public void ExibirFichaTecnica()
    {
        System.Console.WriteLine(this.DescicaoResumida);
    }
}