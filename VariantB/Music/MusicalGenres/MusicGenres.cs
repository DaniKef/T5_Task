using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantB.Music.MusicalGenres
{
    public enum MusicDirections // Музыкальные направления.
    {
        FolkMusic, // Народная музыка.
        SpiritualMusic, // Духовная музыка.
        AcademicMusic, // Академическая музыка.
        PopularMusic // Популярная музыка.
    }
    enum FolkMusicGenres // Жанры народной музыки.
    {
        Kaiso,
        Kuduro,
        Rai,
        UkrainianFolkMusic,
        Manele,
        Makam,
        Boedra,
        Flamenko
    };
    enum SpiritualMusicGenres // Жанры духовной музыки.
    {
        Psalm,
        Messa,
        Recviem,
        Strasti,
        Molitva
    }
    enum AcademicMusicGenre // Жанры академической музыки.
    {
        Opera,
        Operetta,
        Marsh,
        SimfoniMusic,
        Minimalizm,
        Impressionizm,
        Motet,
        Postmodernizm
    }
    enum PopularMusicGenre
    {
        Estrada,
        RockNRoll,
        ElectroMusic,
        Disko,
        Reggi,
        Dab,
        HipHop,
        Pop
    }
}
