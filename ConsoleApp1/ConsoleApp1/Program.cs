using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPrimal(12));
            Console.WriteLine(isPrimal(1));
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
    }
}
