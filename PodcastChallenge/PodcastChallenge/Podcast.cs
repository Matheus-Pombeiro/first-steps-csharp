﻿class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count();

    public void AddEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} - Apresentado por: {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Ep.: {episodio.Resumo}\n");
        }
        Console.WriteLine($"\nTotal de Episódios: {TotalEpisodios}");
    }
}