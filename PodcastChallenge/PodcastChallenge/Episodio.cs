class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }

    public void AddConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
    public string Resumo => $"{Ordem}. - Título: {Titulo} - Duração: {Duracao} min(s) - Convidado(s): {string.Join(", ", convidados)}";
}