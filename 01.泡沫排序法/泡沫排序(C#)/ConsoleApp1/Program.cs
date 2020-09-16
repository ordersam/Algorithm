using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 12, 9, 6, 2, 4, 1, 11, 8, 3, 5, 7, 10, 13 };
            string bubble1 = Bubble.bubble1(array1);
            Console.WriteLine(bubble1);

            int[] array2 = new int[] { 11, 9, 6, 2, 4, 1, 12, 8, 3, 5, 7, 10, 13 };
            string bubble2 = Bubble.bubble1(array2);
            Console.WriteLine(bubble2);

            Console.Read();
        }
    }
}
