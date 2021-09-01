using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("\n\n"); //next line
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n"); //next line

            Console.Write("Enter the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
                Console.ReadLine();
            }
            else if (num2 > num3)
                Console.Write(num2);
            else
                Console.Write(num3);
            Console.ReadLine();
        }
    }
}
