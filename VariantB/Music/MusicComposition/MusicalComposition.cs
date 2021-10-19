using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres; // Жанры

namespace VariantB.Music.MusicComposition
{
    public abstract class MusicalComposition // Музыкальная композиция.
    {
        public string MusicName { get; init; } // Название музыкальной композиции.
        public double MusicDuration { get; set; } // Длительность музыки.
        public string MusicAuthor { get; init; } // Автор произведения.
        public string Region { get; init; } // Регион, где музыку создали и место её наибольшей популярности.
        public MusicDirections MusicDirection { get; init; } // Направление музыки.
        protected MusicalComposition(string musicName, double musicDuration, string region, string musicAuthor) // Конструктор, устанавливает...
        {
            MusicName = musicName; // Название.
            MusicDuration = musicDuration; // Длительность.
            Region = region; // Регион.
            MusicAuthor = musicAuthor; // Автор.
        }
        public abstract void SingaSong(); // Петь песню.
        public override string ToString() // Переопределение.
        {
            return $"Направление музыки: {MusicDirection}.\n"+
               $"Название музыкальной композиции: {MusicName}.\nДлительность: {MusicDuration} мин.\n" +
               $"Регион: {Region}.\nАвтор: {MusicAuthor}.";
        }
    }
}
