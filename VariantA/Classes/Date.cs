using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariantA.SomeEnums; // Свои перечисления.
using VariantA.SomeFunctions; // Вспомогательные функции.

namespace VariantA.Classes
{
    class Date // Класс даты.
    {
        private YearClass _year = new YearClass(); // Год.
        private MonthClass _month = new MonthClass(); // Месяц.
        private DayClass _day = new DayClass(); // День.
        public Date() // Конструктор без параметров.
        {
            Day = 1;
            Month = 1;
            Year = 1;
        }
        public Date(int day, int month, int year) // Конструктор с параметрами. Задать дату. 
        {
            Day = day;
            Month = month;
            Year = year; 
        }
        public DayOfWeek getDayOfWeek() // Вывести на консоль день недели по заданной дате.
        {
            // день недели = (день + код месяца + код года) % 7.
            int kodeOfMonth = Functions.GetKodeOfMonth(_month.MonthOfYear.ToString()); // Высчитывает код месяца, передает название месяца.
            int kodeOfYear = Functions.GetKodeOfYear(Year); // Высчитывает код года в доп. классе.
            int dayOfWeek = ((Day + kodeOfMonth + kodeOfYear) % 7); // Высчитывает день недели.
            // Нумерация начинается с 0 - суббота, 1 воскресенье
            if (dayOfWeek == 0)
                return DayOfWeek.Saturday;
            else if (dayOfWeek == 1)
                return DayOfWeek.Sunday;
            else if (dayOfWeek == 2)
                return DayOfWeek.Monday;
            else if (dayOfWeek == 3)
                return DayOfWeek.Tuesday;
            else if (dayOfWeek == 4)
                return DayOfWeek.Wednesday;
            else if (dayOfWeek == 5)
                return DayOfWeek.Thursday;
            else 
                return DayOfWeek.Friday; // Возвращает день недели.
        }
        public int getDayOfYear() // Рассчет дня года.
        {
            var d = new DateTime(Year, Month, Day);
            return d.DayOfYear;
        }
        public int GetDays()// Получить количество дней в этом месяце
        {
            return _month.GetDaysInMonths((EMonthOfYear)Month, _year.LeapYear); // Передается число дней приведенной к перечислению с номерами месяцев.
        }
        public int daysBetween(Date date) // Рассчитать количество дней, в заданном временном промежутке.
        {
            int daysBetw = 0; // КОличество дней.
            if(Year == date.Year)// Если это один год считать разницу сколько прошло дней с начала года в каждой дате
            {
                daysBetw = Math.Abs(GetDaysofSetDay(Year, Month, Day) - GetDaysofSetDay(date.Year, date.Month, date.Day));
            }
            else if (date.Year > Year) // если передаваемая дата больше этой
            {
                int firstDate = _year.MaxDaysInYear - GetDaysofSetDay(Year, Month, Day);// сколько дней от сегодня до конца этого года
                int secondDate = GetDaysofSetDay(date.Year, date.Month, date.Day); // сколько дней от начала года до заданной даты
                daysBetw = firstDate + secondDate; // сложить 
                for (int i = Year+1; i < date.Year; i++)// если между датами больше одного года- добавлять количество дней в году, високосный проверяется
                {
                    daysBetw += _year.GetMaxDaysInYear(i); // метод с класса года. добавляет количество дней в году
                }
            }
            else
            {
                int firstDate1 = GetDaysofSetDay(Year, Month, Day); // если эта дата больше передаваемой, значения расчитываются в другом порядке 
                int secondDate1 = date._year.MaxDaysInYear - GetDaysofSetDay(date.Year, date.Month, date.Day);
                daysBetw = firstDate1 + secondDate1;
                for (int i = date.Year+1; i < Year; i++)
                {
                    daysBetw += date._year.GetMaxDaysInYear(i);
                }
            }
            return daysBetw;
        }
        public static DayOfWeek valueOf(int index) // преобразование индекса в элемент перечисления
        {
            return (DayOfWeek)index;
        }
        private int GetDaysofSetDay(int year, int month, int day) // Количество дней для определенной даты.
        {
            var d = new DateTime(year, month, day);
            return d.DayOfYear;
        }
        public int Year // Свойсвто года.
        {
            get { return _year.Year; }
            set { _year.Year = value; }
        }
        public int Month // Свойство месяца.
        {
            get { return _month.Month; }
            set { _month.Month = value; }
        }
        public int Day // Свойство дня.
        {
            get { return _day.Day; }
            set { _day.Day = value; }
        }
//////////////////////////////////////////////////////////////////////////////
        public class YearClass // Класс года.
        {
            private int _year; // Год.
            private bool leapYear; // Високосный год.
            private int maxDayInYear; // максимальное количество дней в году.
            private bool IsLeapYear(int year) // Проверка на високосность.
            {
                if (year % 4 == 0)
                    return true;
                else
                    return false;
            }
            private int SetMaxDaysInYear(bool isLeapYear) // Установка количества дней в году в этом году.
            {
                if (isLeapYear)
                    return 366;
                else
                    return 365;
            }
            public int GetMaxDaysInYear(int year)// получить количесвто дней в году по задаваемому году
            {
                if (IsLeapYear(year))
                    return 366;
                else return 365;
            }
            public int Year // Свойство года.
            {
                get { return _year; }
                set
                {
                    if (value > 10000) // Проверка корректности ввода.
                        throw new ArgumentException($"{value}"); // Исключение.
                    leapYear = IsLeapYear(value);
                    maxDayInYear = SetMaxDaysInYear(leapYear);
                    _year = value;
                }
            }
            public bool LeapYear //  Свойство вискоксного года.
            {
                get { return leapYear; }
            }
            public int MaxDaysInYear // свойство значения макс.количества дней в году.
            {
                get { return maxDayInYear; }
            }
        }
//////////////////////////////////////////////////////////////////////////////
        public class MonthClass // Класс месяца.
        {
            private EMonthOfYear monthOfYear; // Перечисление месяца.
            private int _month; // Месяц.
            public int GetDaysInMonths(EMonthOfYear monthName , bool leapYear)// Получить количество дней в месяце.
            {
                string firstname = monthName.ToString(); // Получение имени месяца.
                EDaysInMonths daysInMonths = (EDaysInMonths)Enum.Parse(typeof(EDaysInMonths), firstname); // Преобразование к другому перечислению с количеством дней в месяцах.
                if (daysInMonths == EDaysInMonths.February && leapYear) // Если високосный - вернуть 29.
                    return 29;
                else 
                    return (int)daysInMonths; // Возвращнеие количества дней.
            }
            public int Month // Свойство месяца.
            {
                get { return _month; }
                set
                {
                    if (value < 1 || value > 12)// Проверка корректности ввода.
                        throw new ArgumentException($"{value}"); // Исключение.
                    MonthOfYear = (EMonthOfYear)value;
                    _month = value;
                }
            }
            public EMonthOfYear MonthOfYear // Свойство перечисления месяца.
            {
                get { return (EMonthOfYear)_month; }
                set { monthOfYear = value; }
            }
        }
//////////////////////////////////////////////////////////////////////////////
        public class DayClass // Класс дня.
        {
            private int _day; // День.
            public int Day // Свойство дня.
            {
                get { return _day; }
                set
                {
                    if(value < 1 || value > 32)// Проверка корректности ввода.
                        throw new ArgumentException($"{value}"); // Исключение.
                  //  if()
                    _day = value;
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////
        public override string ToString() // Переопределение метада ToString
        {
            return $"{Day}.{Month}.{Year}";
        }
        public override bool Equals(object obj) // Переопределение метода Equals
        {
            if (!(obj is Date other))
                return false;
            return this.Day == other.Day && this.Month == other.Month && this.Year == other.Year; 
        }
    }
}
