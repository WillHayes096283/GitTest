using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int usrInput = 0;
            int count = 1;

            int x = 0;
            int y = 0;

            Console.WriteLine("Please enter the range of numbers to guess.");
            Console.WriteLine("");

            Console.Write("Please enter the starting number: ");
            x = Convert.ToInt32(Console.ReadLine);

            Console.Write("Please enter the ending number: ");
            y = Convert.ToInt32(Console.ReadLine);

            Random r = new Random();
            int ran = r.Next(x, y);

            do
            {
                Console.Write("Please guess an integer between 0 and 100: ");

                usrInput = Convert.ToInt32(Console.ReadLine());

                if (usrInput > ran)
                {
                    Console.WriteLine("Little lower...");
                    count++;
                }
                else
                {
                    Console.WriteLine("Little Higher...");
                    count++;
                }
            } while (usrInput != ran);

            if(count == 1)
            {
                Console.WriteLine("Congrats you found the number on your first try!");
            }

            Console.WriteLine("Congrats you found the number, it took you: " + count + " tries!");

            //Console.WriteLine("Hello World!");

        }
    }
}
