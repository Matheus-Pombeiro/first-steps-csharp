using System.Threading.Channels;

class Musica
{
    public string nome, artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}