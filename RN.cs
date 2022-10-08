using System;

namespace ReverseNumber
{
    internal class RN
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter Number:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Number:" + reverse);
        }
    }
}
