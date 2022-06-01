using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumCards = 0;
            Console.WriteLine("Привет! Сколько у тебя на руках карт?");
            int cards = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cards; i++)
            {
                Console.WriteLine($"Используя обозначения: Валет(J), Дама(Q), Король(K),Туз(T)\nВведите номинал {i} карты: ");
                var cardIndex = Console.ReadLine();
                switch (cardIndex)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                    case "10":
                        sumCards += 10;
                        break;
                    case "9":
                        sumCards += 9;
                        break;
                    case "8":
                        sumCards += 8;
                        break;
                    case "7":
                        sumCards += 7;
                        break;
                    case "6":
                        sumCards += 6;
                        break;
                }
            }
            Console.WriteLine($"Сумма твоих карт {sumCards}!");
            Console.ReadKey();
        }
    }
}
