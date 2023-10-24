// Locadora de Games

void Logo()
{
    Console.Clear();
    Console.WriteLine("🇬​​​​​🇦​​​​​🇲​​​​​🇪​​​​​ 🇭​​​​​🇴​​​​​🇺​​​​​🇸​​​​​🇪​​​​​");
    Console.WriteLine("Seja bem-vindo(a) à nossa locadora de jogos!\n");
}

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
            ListaDeGamesAlugados();
            break;
        case 4:
            SolicitarNovoGame();
            break;
        case 5:
            ListaDeGamesSolicitados();
            break;
        case 6:
            AvaliarGame();
            break;
        case 7:
            MediaNotas();
            break;
        case 0:
            Console.WriteLine("Obrigado por alugar games conosco. Até a próxima!");
            break;
        default:
            Console.WriteLine("Opção inválida... Digite outro valor.");
            break;
    }
}