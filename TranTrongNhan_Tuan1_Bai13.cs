using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class FileName
    {
        static void Main(string[] args)
        {

            int soT1, soT2,BCNN=0;
            Console.WriteLine("Nhap 2 so nguyen duong tu ban phim :");
            Console.WriteLine("So T1 :");
            soT1 = int.Parse(Console.ReadLine());
            Console.WriteLine("So T2 :");
            soT2 = int.Parse(Console.ReadLine());
            if (soT1 == 0||soT2==0)
            {
                Console.WriteLine("Khong ton tai BCNN");
            }   
            for (int i = 1 ; i <= soT1*soT2; i++)
            {
                 if (i % soT1 == 0 && i % soT2 == 0)
                 {
                    BCNN = i;
                    break;
                 }
            }
            Console.WriteLine("BCNN la : "+BCNN);

            Console.ReadKey();
        }
    }
}
