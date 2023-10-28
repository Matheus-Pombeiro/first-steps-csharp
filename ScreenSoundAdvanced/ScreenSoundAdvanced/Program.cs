Album AlbumAlineBarros = new Album();
AlbumAlineBarros.Nome = "Som de Adoradores";

Musica musica1 = new Musica();
musica1.Nome = "Casa de Deus";
musica1.Duracao = 340;
musica1.Genero = new Genero();
musica1.Genero.Nome = "Gospel";

Musica musica2 = new Musica();
musica2.Nome = "Águas do Trono";
musica2.Duracao = 287;
musica2.Genero = new Genero();
musica2.Genero.Nome = "Louvor e Adoração";

AlbumAlineBarros.AddMusica(musica1);
AlbumAlineBarros.AddMusica(musica2);


AlbumAlineBarros.ExibirMusicasDoAlbum();