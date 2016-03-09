using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сppstudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] numbers = new int[5];
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 4; i >-1; i--)
            {
                numbers[i] = n % 10;
                n = n / 10;
            }
            for (i=0; i<5; i++)
                Console.WriteLine((i + 1) + "цифра числа равна " + numbers[i]);
            Console.ReadKey();
        }
    }
}
