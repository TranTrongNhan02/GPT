using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class DinhNhatThuc_Tuan01_Bai02
    {
        static void Main(string[] args)
        {
            int largest1 = 0;
            int largest2 = 0;
            int number;
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.Write($"So thu {counter}:");
                number = int.Parse(Console.ReadLine());
                if (counter == 0 || number > largest1)
                {
                    largest2 = largest1;
                    largest1 = number;
                }
                else if(counter == 1 || number > largest2)
                {
                    largest2 = number;
                }
            }
            Console.Write($"So lon nhat la: {largest1} va so lon nhi: {largest2}");
            Console.ReadKey();
        }
    }
}
