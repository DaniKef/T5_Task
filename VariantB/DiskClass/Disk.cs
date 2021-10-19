using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantB.Music.MusicComposition;
namespace VariantB.DiskClass
{
    interface IDisk // Интерфейс диска
    {
        void ShowDisk();// Показать все песни на диске
    }
    interface IRecorder// Интерфейс рекордера
    {
        void RecordOneSong(MusicalComposition newSong);// Записать одну песню, принимает песню.
        void DeleteSongsByName(string songName);// Удалить песни с таким именем, принимает имя песни.
        void RecordAssembly(MusicalComposition[] assembly); // //Записать сборку, принимает массив песен.
        double CalculateDuration(); // Продолжительность всех песен на диске
        void SortCompositionByStyle(); // Перестановка композиций на основе принадлежности к стилю
        void FindSongByDurationDiapazon(double begin, double end); // Найти композицию, соответствующую заданному диапазону длины треков.
    }

    class Disk : IDisk, IRecorder  // Диск.
    {
        private MusicalComposition[] _storage = new MusicalComposition[0]; // Все песни на диске
        public void ShowDisk() // Показать все песни на диске
        {
            foreach (var item in _storage)
                Console.WriteLine(item); // Вывод информации о каждой песне
        }
        public void RecordOneSong(MusicalComposition newSong)// Записать одну песню
        {
            Array.Resize<MusicalComposition>(ref _storage, _storage.Length + 1); // Изменение длины массива
            _storage[_storage.Length - 1] = newSong;
        }
        public void DeleteSongsByName(string songName) // Удалить песни с таким именем
        {
            _storage = _storage.Where(val => val.MusicName != songName).ToArray(); // Удалить песни с таким именем
        }
        ////////////////////////////////////// 
        ///////////////////////////////////////// Методы с задания
        public void RecordAssembly(MusicalComposition[] assembly) //Записать сборку
        {
            int oldLenght = _storage.Length; // Старая длина
            int index = 0; // индекс  0, чтоб присваивать песни в массив
            Array.Resize<MusicalComposition>(ref _storage, _storage.Length + assembly.Length); //Изменение длины
            for (int i = oldLenght; i < _storage.Length; i++)// Присвоение доп. элементов
            {
                _storage[i] = assembly[index];
                index++;
            }
        }
        public double CalculateDuration() // Продолжительность
        {
            double duration = 0;
            foreach (var song in _storage)
                duration += song.MusicDuration;
            return duration;
        }
        public void SortCompositionByStyle() // Перестановка
        {
            MusicalComposition temp;
            for (int i = 0; i < _storage.Length - 1; i++) // Сортировка по стилю
            {
                for (int j = i + 1; j < _storage.Length; j++)
                {
                    if ((int)_storage[i].MusicDirection > (int)_storage[j].MusicDirection)
                    {
                        temp = _storage[i];
                        _storage[i] = _storage[j];
                        _storage[j] = temp;
                    }
                }
            }
        }
        public void FindSongByDurationDiapazon(double begin, double end) // Найти по диапазону длины
        {
            Console.WriteLine($"Песни в диапазоне от {begin} до {end}:");
            foreach (var song in _storage)
            {
                if (song.MusicDuration >= begin && song.MusicDuration <= end)
                    Console.WriteLine(song);
            }
        }

    }
}
