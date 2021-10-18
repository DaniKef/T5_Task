//Гуренко Даниил
//Вариант общий
//Создать объект класса Date, используя вложенные классы Год, Месяц, День. Методы: задать дату, вывести на консоль день недели по заданной дате. День недели представить в виде перечисления. Рассчитать количество дней, в заданном временном промежутке.
//Т.е. в классе Date реализовать следующее:
//public Date(int day, int month, int year)
//public DayOfWeek getDayOfWeek()
//public int getDayOfYear()
//public int daysBetween(Date date)
//В классе Year должна осуществляться проверка на високосность (можно реализовать в конструкторе) в результате, установить значение для соотв. атрибута года.
//В классе Month можно сделать метод который позволит узнать количество дней для того или иного месяца [1-12]. Метод можно использовать для подсчета дней в других методах: public int getDays(int monthNumber, boolean leapYear)
//Создать статический метод: public static DayOfWeek valueOf(int index)
//Для того чтобы можно было после математических расчетов использовать данный метод для преобразования индекса дня недели в соотв. элемент перечисления.
//Переопределите методы toString() и equals().

using System;
using VariantA.Classes;

namespace VariantA
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var date = new Date(1, 4, 2021); // Создание даты.
            Console.WriteLine(date.getDayOfWeek()); // День недели по дате 
            Console.WriteLine(date.getDayOfYear()); // День года по дате
            Console.WriteLine(date.daysBetween(new Date(2, 4, 2021))); // Количество дней в заданном временном промежутке
            Console.WriteLine(date.GetDays()); // Количество дней в этом месяце
            Console.WriteLine(date); // Вывод даты
            Console.WriteLine(date.Equals(new Date(15, 7, 2020))); // Проверка 
            Console.ReadKey();
        }
    }
}
