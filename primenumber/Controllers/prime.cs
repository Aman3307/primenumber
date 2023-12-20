using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace primenumber.Controllers
{
    public class prime
    {
        public static void  Main(String[] args)
        {
            int n;
            Console.Write("Enter a +ve integer : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Invalid Entry!!!");
                Console.ReadLine();
                
                int flag = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1; break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine("The given  number was a composite number");
                else
                    Console.WriteLine("The given  number was a Prime number");
                Console.ReadLine();
               
            }
        }

    }

}