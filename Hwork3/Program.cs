using System;

namespace Hwork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine($"Число {number} четное.");
            else Console.WriteLine($"Число {number} нечетное.");
            Console.ReadKey();
        }
    }
}
