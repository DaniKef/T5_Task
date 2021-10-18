using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantA.SomeEnums
{
    enum EMonthOfYear // Перечисление месяцев, их последовательность.
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    };
    enum EDaysInMonths // Перечисление месяцев, количество дней в них. Для високосного проверка в классе Месяца.
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        October = 31,
        November = 30,
        December = 31
    };
}
