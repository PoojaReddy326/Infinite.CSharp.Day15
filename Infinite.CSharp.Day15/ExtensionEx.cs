using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.Day15
{
    public static class ExtensionEx
    {
        public static bool Validate(this Employee emp, string mobileNo)
        {
            return mobileNo.Length == 10 ? true : false;
        }
        //Word Count
        public static int WordCount(this string str)
        {
            string[] words = str.Split(' ', ',', '-', '.');
            return words.Length;
        }

        public static bool OnlyNumbers(this string number)
        {
            bool flag = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 48 || number[i] > 58)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

    }
}
