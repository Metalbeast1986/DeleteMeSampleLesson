using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPrimal(12));
            Console.WriteLine(isPrimal(1));
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine( D20() );
            }
        }
        static bool isPrimal(int num)
        {
            bool result = true;
            for (int i=2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            } 
            return result;
        }

        static int D20()
        {
            Random random = new Random();
            return random.Next(0,20)+1;
        }
    }
}
