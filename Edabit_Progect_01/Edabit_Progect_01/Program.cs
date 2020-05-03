using System;

namespace Edabit_Progect_01
{
    class Program
    {
        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            return (day == 24 && month == 11);
        }
    }
}
/*Christmas Eve is almost upon us, so naturally we need to prepare some 
 * milk and cookies for Santa! Create a function that accepts year, month 
 * and day as integers and returns true if it's Christmas Eve (December 24th) 
 * and false otherwise.
