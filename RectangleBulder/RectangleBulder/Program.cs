using System;

namespace RectangleBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write wanted width: ");
            string readWidth = Console.ReadLine();

            Console.Write("Write wanted height: ");
            string readHeight = Console.ReadLine();

            int width = int.Parse(readWidth);
            int height = int.Parse(readHeight);

            Console.WriteLine();

            build(width, height);

            static void build(int x, int y)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }

            Console.ReadKey();
        }
    }
}
