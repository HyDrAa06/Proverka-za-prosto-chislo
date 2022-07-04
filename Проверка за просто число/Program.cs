using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_за_просто_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int br = 0;

            Console.Write("Въведете число: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1;i <= n; i++)
            {
                if (n % i == 0)
                {
                    br++;
                }
            }

            if (br == 2)
            {
                Console.WriteLine("Числото е просто");
            }

            else
            {
                Console.WriteLine("Числото не е просто");
            }

            Console.ReadLine();
        }
    }
}
