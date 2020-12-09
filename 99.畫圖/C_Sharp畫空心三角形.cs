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
            string str = "";

            int layer = 10;
            for (int i = 0; i < (layer-1); i++)
                str += " ";
            str += "*\n";

            for (int i = 0; i < (layer-1); i++)
            {
                for (int j = 0; j < (layer-1 - i - 1); j++)
                    str += " ";
                str += "*";
                for (int j = 0; j < i; j++)
                    str += " ";
                str += "*\n";
            }

            for (int i = 0; i < (layer - 2); i++)
            {
                for (int j = 0; j < (i + 1); j++)
                    str += " ";
                str += "*";
                for (int j = 0; j < ((layer - 2) - i - 1); j++)
                    str += " ";
                str += "*\n";
            }

            for (int i = 0; i < (layer - 1); i++)
                str += " ";
            str += "*";

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
