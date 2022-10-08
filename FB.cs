using System;

namespace Fibonacci
{
    internal class FB
    {
        static void Main(string[] args)
        {
            int number, a = 0, b = 1, c, i;

            Console.Write("Enter The End Point Till You Want Fibonacci Sequence:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series:"+ a +" "+ b);

            for (i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" "+ c);
                a = b;
                b = c;
            }
        }
    }
}
