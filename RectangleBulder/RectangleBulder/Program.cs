using System;

namespace RectangleBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = ReadParameter("width");
            int height = ReadParameter("height");
            Build(height, width);

            static void Build(int height, int width)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }
            
            static int ReadParameter(string name)
            {
                Console.Write($"Write wanted {name}: ");
                string readNumber = Console.ReadLine();

                int number;
                bool isNumber = int.TryParse(readNumber, out number);
                while (!isNumber)
                {
                    Console.WriteLine("Please, write a number: ");
                    readNumber = Console.ReadLine();
                    isNumber = int.TryParse(readNumber, out number);
                }
                return number;
            }
            Console.ReadKey();
        }
    }
}
