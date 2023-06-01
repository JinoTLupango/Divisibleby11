using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diviseble11
{

    class Divisibleby11
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            int place = 1;
            while (n > 0)
            {
                int digit = n % 10;
                if (place % 2 == 0)
                {
                    t -= digit;
                }
                else
                {
                    t += digit;
                }
                place++;
                n /= 10;
            }
            if (t % 11 == 0)
            {
                Console.WriteLine("The number is divisible by 11");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 11");
            }
            Console.ReadLine();
        }
    }
}
 

