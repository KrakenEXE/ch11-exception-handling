using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptExceptionTest
{
    class SubscriptExpectionTest
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 5, 6, 8, 9, 10, 12, 13, 15, 16, 17, 19, 20, 22, 24, 26, 27, 29, 30, 31 };
            int result, num = 0;
            try
            {
                if(num <= 0)
                Write("Enter the position of the number >> ");
                num = Convert.ToInt32(ReadLine());
                result = array[num];
                WriteLine(num.ToString()+"'s position has the number "+result);

                WriteLine("Click enter to exit...");
                ReadLine();

            }
            catch(IndexOutOfRangeException error)
            {
                WriteLine(error.Message);
            }

        }
    }
}
