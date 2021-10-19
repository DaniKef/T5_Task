using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicalGenres;
using VariantB.Music.MusicalDirections;

namespace VariantB.Music.ModernPopularMusic
{
    class ModernMusic : PopularMusic // Современная музыка
    {
        private bool _singWithWords; // Петь или просто исполнять на инструментах
        private double _howMuchCostOnITunes; // Сколько стоит прослушивание в интернете
        private double sum; // Сбережения
        public ModernMusic(string musicName, double musicDuration, string region,
            string musicAuthor, PopularMusicGenre popularGenre) 
            : base(musicName, musicDuration, region, musicAuthor, popularGenre)
        {
        }
        public override void SingaSong()
        {
            Console.WriteLine("Пою современную современную популярную музыку.");
        }
        public void SingWithWords(bool yesOrNot)
        {
            _singWithWords = yesOrNot;
        }
        public void SetAPriceOnITunes(double cost)
        {
            _howMuchCostOnITunes = cost;
        }
        public void GetMoneyInAMonth(int howMuchLissenInADay)
        {
            if (_singWithWords)
                sum += (30 * (howMuchLissenInADay * _howMuchCostOnITunes)) * 1.5;
            else
                sum += (30 * (howMuchLissenInADay * _howMuchCostOnITunes)) * 1.2;
        }
        public double GetSum()
        {
            return sum;
        }
    }
}
