using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres; // Жанры
using VariantB.Music.MusicComposition; // Подключение класса музыкальной композиции.

namespace VariantB.Music.MusicalDirections
{
    class FolkMusic : MusicalComposition // Народная музыка
    {
        public FolkMusicGenres MusicGenre { get; init; } // Жанр музыки.
        public FolkMusic(string musicName, double musicDuration, string region, FolkMusicGenres folkGenre, 
            string musicAuthor = "Народная")
            :base(musicName, musicDuration, region, musicAuthor)// Конструктор
        {
            MusicAuthor = "Народная";
            MusicDirection = MusicDirections.FolkMusic; // Направление устанавливается само.
            MusicGenre = folkGenre; // Жанр по параметру.
        }
        public override void SingaSong()
        {
            Console.WriteLine("Пою народную музыку.");
        }
        public override string ToString()
        {
            return $"\nЖанр: {MusicGenre}.\n" + base.ToString();
        }
    }
}
