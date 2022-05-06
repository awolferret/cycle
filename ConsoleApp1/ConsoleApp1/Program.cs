using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите ваше сообщение");
            string massage = Console.ReadLine();
            Console.WriteLine("Сколько повторов?");
            int repeatNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeatNumber; i++)
            {
                Console.WriteLine(massage);
            }

        }
    }
}