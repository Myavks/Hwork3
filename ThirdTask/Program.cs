using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool k=false;
            int i = 2;
            Console.WriteLine("Введите натуральное целое число (>0):");
            int a = Convert.ToInt32(Console.ReadLine());
            while (i < a)
            {
                if (a % i == 0)
                {
                    k = true;
                    break;
                }
                i++;
            }
            if (k) Console.WriteLine($"Число {a} не является простым");
            else Console.WriteLine($"Число {a} является простым");
            Console.ReadKey();
        }
    }
}
