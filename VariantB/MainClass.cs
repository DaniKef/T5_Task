//Гуренко даниил
//Вариант 5
//Создать консольное приложение, удовлетворяющее следующим требованиям:
//• Использовать возможности ООП: классы, наследование, полиморфизм, инкапсуляция.
//• Реализовать несколько уровней абстракции (интерфейсы, абстрактные классы).
//• Каждый класс должен иметь отражающее смысл название и информативный состав.
//• Для хранения коллекций объектов предметной области использовать массивы.
//• Наследование должно применяться только тогда, когда это имеет смысл.
//• При кодировании должны быть использованы соглашения об оформлении
//кода: code convention.
//• Консольное меню должно быть минимальным.

//5.Звукозапись.Определить иерархию музыкальных композиций. Записать на диск сборку.
//Подсчитать продолжительность. Провести перестановку композиций диска на основе принадлежности к стилю. 
//Найти композицию, соответствующую заданному диапазону длины треков.

using System;
using VariantB.Music.MusicalDirections; // Направления
using VariantB.Music.MusicalGenres; // Жанры
using VariantB.Music.ModernPopularMusic;
using VariantB.DiskClass;
using VariantB.Music.MusicComposition;


namespace VariantB
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var folk = new FolkMusic("Несе Галя воду", 2.30, "Украина", FolkMusicGenres.UkrainianFolkMusic);
            var spiritual = new SpiritualMusic("Ave Maria", 7.40, "Австрия", "Франц Шуберт", SpiritualMusicGenres.Molitva);
            var academic = new AcademicMusic("Времена года", 16, "Италия", "Антонио Вивальди", AcademicMusicGenre.SimfoniMusic);
            var popular = new PopularMusic("Rap God", 4.20, "США", "Эминем", PopularMusicGenre.HipHop);
            var modern = new ModernMusic("MyMusic", 2.33, "Украина", "Даниил", PopularMusicGenre.HipHop);
            var disk = new Disk();
            MusicalComposition[] assembly = new MusicalComposition[5] { folk, spiritual, folk, academic, folk };

            disk.RecordOneSong(modern); // Записать одну песню
            disk.RecordAssembly(assembly); // Записать сборник песен
            //disk.ShowDisk(); // Вывести все песни
            Console.WriteLine(disk.CalculateDuration()); // Посчитать продолжительность
            disk.SortCompositionByStyle(); // Перестановка по стилям
            //disk.ShowDisk();
            disk.FindSongByDurationDiapazon(2, 2.40); //Найти композицию по диапазону длины треков.
            Console.ReadKey();
        }
    }
}
