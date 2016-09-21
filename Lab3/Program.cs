using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your Squares and Cubes!!\n");
            string ans_cont;
            do
            {
                Console.Write("Enter an Integer:");
                string numberInput = Console.ReadLine();
                int number = int.Parse(numberInput);

                for (int count = 1; count <= number; count++)
                { Console.WriteLine(count.ToString() + " " + (count * count).ToString() + " " + (count * count * count).ToString()); }
                //hello
                Console.WriteLine("Continue?");
                Console.WriteLine("Enter yes or no");
                ans_cont = Console.ReadLine();
            } while (ans_cont == "yes");
            if (ans_cont == "no") ;
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
