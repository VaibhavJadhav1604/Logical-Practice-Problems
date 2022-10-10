using System;

namespace PerfectNumber
{
    internal class PN
    {
        static int sum;
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;  
            while (i <= n / 2)
            {
                
                if (n % i == 0)
                { 
                    sum += i;
                } 
                i++;
            }
            if (sum == n)
            {
                Console.WriteLine(n + ":Is Perfect Number.");
            }
            else
            {  
                Console.WriteLine(n + ":Is Not Perfect Number.");
            }        
        }
    }
}
