using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres; // Жанры
using VariantB.Music.MusicComposition; // Подключение класса музыкальной композиции.

namespace VariantB.Music.MusicalDirections
{
    class AcademicMusic : MusicalComposition // Академическая музыка
    {
        public AcademicMusicGenre MusicGenre { get; init; }// Жанр музыки.
        public AcademicMusic(string musicName, double musicDuration, string region,
            string musicAuthor, AcademicMusicGenre academicGenre)
            :base(musicName, musicDuration, region, musicAuthor)// Конструктор
        {
            MusicDirection = MusicDirections.AcademicMusic;
            MusicGenre = academicGenre;
        }
        public override void SingaSong()
        {
            Console.WriteLine("Исполняю академическую музыку.");
        }
        public override string ToString()
        {
            return $"\nЖанр: {MusicGenre}.\n" + base.ToString();
        }
    }
}
