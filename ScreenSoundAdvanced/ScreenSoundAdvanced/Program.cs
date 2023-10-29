Banda alineBarros = new Banda("Aline Barros");

Album AlbumAlineBarros = new Album("Som de Adoradores");

Genero gospel = new Genero("Gospel");

Musica musica1 = new Musica(alineBarros, "Casa de Deus", gospel)
{
    Duracao = 340,
    Disponivel = true,

};

Musica musica2 = new Musica(alineBarros, "Águas do Trono", gospel)
{
    Duracao = 287,
    Disponivel = false,
};

AlbumAlineBarros.AddMusica(musica1);
AlbumAlineBarros.AddMusica(musica2);
alineBarros.AddAlbum(AlbumAlineBarros);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
AlbumAlineBarros.ExibirMusicasDoAlbum();
alineBarros.ExibirDiscografia();