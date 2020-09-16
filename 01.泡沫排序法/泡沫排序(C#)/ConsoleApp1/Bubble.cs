using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bubble
    {
        public static string bubble1(int[] array1)
        {
            int temp = 0;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = 0; j < array1.Length -1 - i; j++)
                {
                    if (array1[j] > array1[j+1])
                    {
                        temp = array1[j];
                        array1[j] = array1[j+1];
                        array1[j+1] = temp;
                    }
                }
            }

            string strArray = "";
            foreach (int element in array1)
            {
                strArray += element.ToString() + " ";
            }
            return strArray;
        }

        public static string bubble2(int[] array1)
        {
            int temp = 0;
            int i = 0;
            while (i < array1.Length - 1)
            {
                for (int j = 0; j < array1.Length - 1 - i; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }
                i++;
            }

            string strArray = "";
            foreach (int element in array1)
            {
                strArray += element.ToString() + " ";
            }
            return strArray;
        }
    }
}
