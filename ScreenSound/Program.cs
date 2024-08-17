using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

void ExibirLogo()
{
    Console.WriteLine("Screen Sound\n");
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar uma nova banda/artista");
    Console.WriteLine("2 - Exibir uma banda/artista\n");
}

void EscolherOpcao()
{
    string optionDomain = AppDomain.CurrentDomain.BaseDirectory;
    string optionFile = Path.Combine(optionDomain, "Resource", "options.json");

    if (File.Exists(optionFile))
    {
        var optionsContent = File.ReadAllText(optionFile);
        var optionDisserialized = JsonConvert.DeserializeObject<JObject>(optionsContent);

        foreach (var item in optionDisserialized)
        {
            Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
        }
    }
}

void CadastrarBanda()
{
    Console.WriteLine("Digite o nome da banda:");
    var banda = Console.Read();
}

ExibirMenu();
EscolherOpcao();

// Banda banda = new Banda("J Quest");
// Album album = new Album("Acústico J Quest");
// Musica musica = new Musica(banda, "Só Hoje");
// Musica musica2 = new Musica(banda, "Amor Maior");

// banda.AdicionarAlbum(album);

// banda.ExibirDiscografia();

// musica.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();