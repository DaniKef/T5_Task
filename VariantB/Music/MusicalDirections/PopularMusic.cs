using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres; // Жанры
using VariantB.Music.MusicComposition; // Подключение класса музыкальной композиции.

namespace VariantB.Music.MusicalDirections
{
    class PopularMusic : MusicalComposition
    {
        public PopularMusicGenre MusicGenre { get; init; }// Жанр музыки.
        public PopularMusic(string musicName, double musicDuration, string region,
            string musicAuthor, PopularMusicGenre popularGenre)
            :base(musicName, musicDuration, region, musicAuthor) // Конструктор
        {
            MusicDirection = MusicDirections.PopularMusic;
            MusicGenre = popularGenre;
        }
        public override void SingaSong()
        {
            Console.WriteLine("Пою популярную музыку.");
        }
        public override string ToString()
        {
            return $"\nЖанр: {MusicGenre}.\n" + base.ToString();
        }
    }
}
