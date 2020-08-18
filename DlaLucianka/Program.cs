using System;

namespace DlaLucianka
{
    public class Program
    {
        public static string GetOutPut(int number)
        {
            string output;

            if ((number % 3 == 0) && (number % 5 == 0))
            {
                output = "Lucian";
            }
            else if (number % 3 == 0)
            {
                output = "Fellatio";
            }
            else if (number % 5 == 0)
            {
                output = "Ligawkurwia";
            }
            else
            {
                output = number.ToString();
            }

            return output;
        }
    }
}