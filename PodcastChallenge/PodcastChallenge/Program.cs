Episodio ep1 = new Episodio("História dos Games", 1, 132);
ep1.AddConvidado("William Higinbotham");

Episodio ep2 = new Episodio("Gêneros dos Games", 2, 89);
ep2.AddConvidado("Jovem Nerd");
ep2.AddConvidado("Azaghal");

Podcast gamesWorld = new Podcast("Game's World", "Matheus Pombeiro");
gamesWorld.AddEpisodio(ep1);
gamesWorld.AddEpisodio(ep2);

gamesWorld.ExibirDetalhes();