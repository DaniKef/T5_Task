using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres; // Жанры
using VariantB.Music.MusicComposition; // Подключение класса музыкальной композиции.

namespace VariantB.Music.MusicalDirections
{
    class SpiritualMusic : MusicalComposition // Духовная музыка
    {
        public SpiritualMusicGenres MusicGenre { get; init; }// Жанр музыки.
        public SpiritualMusic(string musicName, double musicDuration, string region, 
            string musicAuthor, SpiritualMusicGenres spiritualGenre)
            :base(musicName, musicDuration, region, musicAuthor)// Конструктор
        {
            MusicDirection = MusicDirections.SpiritualMusic;
            MusicGenre = spiritualGenre;
        }
        public override void SingaSong()
        {
            Console.WriteLine("Исполняю духовную музыку.");
        }
        public override string ToString()
        {
            return $"\nЖанр: {MusicGenre}.\n" + base.ToString();
        }
    }
}
