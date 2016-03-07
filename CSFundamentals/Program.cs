using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool leapYear = IsLeapYear(0);
            Console.WriteLine(leapYear);
            Console.ReadLine();

        }
        public static bool IsLeapYear(int year)
        {
            if (year <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                Console.ReadLine();
            }
            if (year%4 == 0)
            {
                if (year%100 != 0)
                {
                    return true;
                }
                else if (year%400 == 0)
                {
                    return true;
                }
            }
            
                return false;
            
        }



    }
}
