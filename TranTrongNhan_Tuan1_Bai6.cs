using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class DinhNhatThuc_Tuan01_Bai06
    {
        static void Main(string[] args)
        {
            int a, tuso, b, mauso, temp = 0;
            do
            {
                Console.WriteLine("Nhap mo phan so(-1 de ket thuc):");
                tuso = a = int.Parse(Console.ReadLine());
                if(tuso == -1)
                    break;
                mauso = b = int.Parse(Console.ReadLine());
                if(mauso == -1)
                    break;
                while (a != b)
                {
                    if (a > b)
                    {
                        temp = (a -= b);
                    }
                    else
                    {
                        temp = (b -= a);
                    }
                }
                if(tuso%temp == 0 && mauso%temp == 0)
                {
                    tuso /= temp;
                    mauso /= temp;
                }
                if(mauso == 1)
                {
                    Console.WriteLine($"Phan so rut gon:{tuso}");
                }
                else
                {
                    Console.WriteLine($"Phan so rut gon:{tuso}/{mauso}");
                }
            }
            while (true);
        }
    }
}
