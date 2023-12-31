﻿// Locadora de Games

// Lista de Games e suas notas
Dictionary<string, List<int>> games = new Dictionary<string, List<int>>()
{
    {
        "Fable", new List<int>{ 10, 8, 9, 7 }
    },
    {
        "Skyrim", new List<int> { 10, 10, 7, 6}
    },
    {
        "World of Warcraft", new List<int> { 8, 9, 10, 9}
    },
    {
        "Dragon Age: Inquisition", new List<int> { 7, 10, 7, 9}
    }
};

// Lista dos Games Alugados
List<string> gamesAlugados = new List<string>();

// Lista dos Games Solicitados
List<string> gamesSolicitados = new List<string>();

// Função para utilização do logo
void Logo()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░░█████╗░███╗░░░███╗███████╗  ██╗░░██╗░█████╗░██╗░░░██╗░██████╗███████╗
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██║░░██║██╔══██╗██║░░░██║██╔════╝██╔════╝
██║░░██╗░███████║██╔████╔██║█████╗░░  ███████║██║░░██║██║░░░██║╚█████╗░█████╗░░
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██╔══██║██║░░██║██║░░░██║░╚═══██╗██╔══╝░░
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ██║░░██║╚█████╔╝╚██████╔╝██████╔╝███████╗
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═════╝░╚══════╝");
    Console.WriteLine("\nSeja bem-vindo(a) à nossa locadora de jogos!\n");
}

// Função para utilização do menu
void MenuPrincipal()
{
    Logo();
    Console.WriteLine("Digite 1 para conferir a lista de games.");
    Console.WriteLine("Digite 2 para alugar um game.");
    Console.WriteLine("Digite 3 para conferir a lista de game(s) alugado(s).");
    Console.WriteLine("Digite 4 para solicitar um novo game.");
    Console.WriteLine("Digite 5 para conferir a lista de games solicitados.");
    Console.WriteLine("Digite 6 para avaliar um game.");
    Console.WriteLine("Digite 7 para conferir a média de notas de um game.");
    Console.WriteLine("Digite 0 para sair.");
    Console.Write("\nEscolha uma opção para que possamos ajudá-lo(a): ");
    int opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            ListaDeGames();
            break;
        case 2:
            AlugarGame();
            break;
        case 3:
            GameAlugados();
            break;
        case 4:
            SolicitarGame();
            break;
        case 5:
            GamesSolicitados();
            break;
        case 6:
            AvaliarGame();
            break;
        case 7:
            MediaNotas();
            break;
        case 0:
            Console.WriteLine("\nObrigado por alugar games conosco. Até a próxima!");
            break;
        default:
            Console.WriteLine("\nOpção inválida... Digite outro valor.");
            break;
    }
}

// Função para exibir o título
void Titulo(string titulo)
{
    int tamanho = titulo.Length;
    string borda = string.Empty.PadLeft(tamanho, '-');
    Console.Clear();
    Console.WriteLine(titulo);
    Console.WriteLine($"{borda}\n");
}

// Função para listar os games e suas notas
void ListaDeGames()
{
    Titulo("Lista dos Games");
    foreach (string game in games.Keys)
    {
        Console.WriteLine($"Game: {game}");
        Console.Write("Notas: ");
        foreach (int nota in games[game])
        {
            Console.Write($"{nota} ");
        }
        Console.WriteLine("\n");
    }
    Console.Write("Digite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    MenuPrincipal();

}

// Função para alugar um game
void AlugarGame()
{
    Titulo("Alugar Game");
    Console.Write("Digite o nome do game que deseja alugar: ");
    string nomeDoGame = Console.ReadLine()!;
    if (games.ContainsKey(nomeDoGame))
    {
        gamesAlugados.Add(nomeDoGame);
        Console.WriteLine($"\nO game {nomeDoGame} foi alugado com sucesso!");
        Thread.Sleep(4000);
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine($"\nSinto muito, mas não possuímos o game {nomeDoGame} em nossa locadora...");
        Console.Write("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        MenuPrincipal();
    }
}

// Exibe lista de games alugados
void GameAlugados()
{
    Titulo("Games Alugados");
    Console.WriteLine("Lista de Games Alugados: \n");
    foreach(string game in gamesAlugados)
    {
        Console.WriteLine($"Game: {game}\n");
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    MenuPrincipal();
}

// Solicita um game
void SolicitarGame()
{
    Titulo("Solicitar Game");

    Console.Write("Digite o nome do game que você deseja solicitar: ");
    string gameSolicitado = Console.ReadLine()!;
    gamesSolicitados.Add(gameSolicitado);
    Console.WriteLine($"\nO game {gameSolicitado} foi solicitado com sucesso!");
    Thread.Sleep(4000);
    MenuPrincipal();
}

// Exibe a lista de games solicitados
void GamesSolicitados()
{
    Titulo("Games Solicitados");
    Console.WriteLine("Lista dos Games Solicitados: \n");
    foreach (string game in gamesSolicitados)
    {
        Console.WriteLine($"Game: {game}\n");
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    MenuPrincipal();
}

// Avalia um game
void AvaliarGame()
{
    Titulo("Avaliar Game");
    Console.Write("Digite o nome do game que você deseja avaliar: ");
    string gameAvaliado = Console.ReadLine()!;
    if (games.ContainsKey(gameAvaliado))
    {
        Console.Write($"\nDe 0 à 10, qual nota você deseja atribuir ao game {gameAvaliado}: ");
        int nota = int.Parse(Console.ReadLine()!);
        games[gameAvaliado].Add(nota);
        Console.WriteLine($"\nNota {nota} atribuída com sucesso ao game {gameAvaliado}.");
        Thread.Sleep(4000);
        MenuPrincipal();
    } 
    else
    {
        Console.WriteLine($"\nSinto muito, mas não possuímos o game {gameAvaliado} em nossa locadora...");
        Console.Write("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        MenuPrincipal();
    }
}

void MediaNotas()
{
    Titulo("Média de Notas dos Games");
    foreach (string game in games.Keys)
    {
        double media = games[game].Average();
        Console.Write($"Game: {game} | Média de Notas: {media}\n");
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    MenuPrincipal();
}

// Chama o menu principal
MenuPrincipal();