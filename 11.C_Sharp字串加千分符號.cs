using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleAppXXX
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "123";
            //string str = "1234";
            //string str = "12345";
            //string str = "123456";
            string str = "1234567";
            string str2 = "";
            // ====== 法1 正向loop(效能較好) ======
            // 第一個分隔符
            int firstIndex;
            if (str.Length <= 3)
            {
                firstIndex = 0;
                str2 = str;
            }
            else
            {
                firstIndex = (str.Length % 3 == 0) ? 3 : (str.Length % 3);
                for (int i = 0; i < str.Length; i++)
                {
                    // 第一個分隔符
                    if (i == firstIndex)
                    {
                        str2 += "," + str[i];
                    }
                    else
                    {
                        // 之後分隔符(扣掉firstIndex)
                        if ((str.Length - firstIndex > 3) && (i - firstIndex > 0) && ((i - firstIndex) % 3 == 0))
                            str2 += "," + str[i];
                        else
                            str2 += str[i];
                    }
                }
            }
            Console.WriteLine(str2);

            // ====== 法2 反向加分隔符 再轉正向(效率較差) ======
            string str3 = "";
            string str4 = "";
            int temp = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ((temp > 0) && (temp % 3 == 0))
                    str3 += "," + str[i];
                else
                    str3 += str[i];
                temp++;
            }
            for (int i = str3.Length - 1; i >= 0; i--)
            {
                str4 += str3[i];
            }
            Console.WriteLine(str4);

            Console.Read();
        }
    }
}
