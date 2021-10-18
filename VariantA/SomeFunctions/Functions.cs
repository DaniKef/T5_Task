using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantA.SomeFunctions
{
    public static class Functions 
    {
        public static int GetKodeOfMonth(string monthName) // Рассчитывает Код месяца, который нужен для формулы подсчета дня ненели по дате.
        {
            int kodMonth = -1; // Код месяца, возвращаемое значение. Для каждого месяца свой код.
            if (monthName == "January" || monthName == "October")
                kodMonth = 1;
            else if (monthName == "May")
                kodMonth = 2;
            else if (monthName == "August")
                kodMonth = 3;
            else if (monthName == "February" || monthName == "March" || monthName == "November")
                kodMonth = 4;
            else if (monthName == "June")
                kodMonth = 5;
            else if (monthName == "December" || monthName == "September")
                kodMonth = 6;
            else
                kodMonth = 0;
            return kodMonth; // Возвращает код месяца по названию.
        }
        public static int GetKodeOfYear(int year)// Рассчитывает Код Года, который нужен для формулы подсчета дня ненели по дате.
        {
            //код года = (6 + последние две цифры года + последние две цифры года / 4) % 7
            int centure = (year / 100) + 1; // Вычисляет век.
            int kodOfCenture = -1; // Код для века.
            int kodOfYear = -1; // Код года, возвращаемое значение.
            if (centure % 4 == 3) // Для каждого века свой код.
                kodOfCenture = 0;
            else if (centure % 4 == 2)
                kodOfCenture = 2;
            else if (centure % 4 == 1)
                kodOfCenture = 4;
            else
                kodOfCenture = 6;
            if (kodOfCenture == 0)
                kodOfYear = (6 + (year % 100) + (year % 100)) % 7;
            else
                kodOfYear = (6 + (year % 100) + ((year % 100) / kodOfCenture)) % 7; // Рассчет кода года.
            return kodOfYear;
        }
    }
}
