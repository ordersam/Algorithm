using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bubble
    {
        // ======== for loop ========
        public static string Bubble1(int[] array1)
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
        
        // ======== while loop ========
        public static string Bubble2(int[] array1)
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

        // ======== for loop improved ========
        #region
        public static string Bubble3(int[] array1)
        {
            for (int bubble = 0; bubble < array1.Length - 1; bubble++)
            {
                for (int i = 0; i < array1.Length - 1 - bubble; i++)
                {
                    int prev = array1[i];
                    int after = array1[i + 1];
                    if (prev > after)
                        Swap(array1, i, i + 1);
                }
            }

            return string.Join(" ", array1);
        }

        private static void Swap(int[] array1, int prev, int after)
        {
            int temp = array1[prev];
            array1[prev] = array1[after];
            array1[after] = temp;
        }
        #endregion
    }
}
