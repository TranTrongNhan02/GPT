using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh");

            for (int i = 10; i < 100; i++)
            {
                    int dv = i % 10;
                    int chuc = i / 10;
                    if (dv*chuc == dv+chuc)
                        Console.WriteLine(i+" ");
            }
            Console.ReadKey();
        }
    }
}
