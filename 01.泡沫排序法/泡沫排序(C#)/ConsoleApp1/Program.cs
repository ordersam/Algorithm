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
            int[] nums = new int[] { 12, 9, 6, 2, 4, 1, 11, 8, 3, 5, 7, 10, 13 };
            int[] temp = new int[nums.Length];
            // ======== for loop ========
            Array.Copy(nums, temp, nums.Length);
            Console.WriteLine(string.Join(" ", temp));
            string bubble1 = Bubble.Bubble1(temp);
            Console.WriteLine(bubble1 + "\n");

            // ======== while loop ========
            Array.Copy(nums, temp, nums.Length);
            Console.WriteLine(string.Join(" ", temp));
            string bubble2 = Bubble.Bubble2(temp);
            Console.WriteLine(bubble2 + "\n");

            // ======== for loop improved ========
            Array.Copy(nums, temp, nums.Length);
            Console.WriteLine(string.Join(" ", temp));
            string bubble3 = Bubble.Bubble3(temp);
            Console.WriteLine(bubble3);

            Console.Read();
        }
    }
}
