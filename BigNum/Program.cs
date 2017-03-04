using System;

namespace BigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum;
            testNum = int.Parse(Console.ReadLine());

            string[] str1 = new string[testNum];
            string[] str2 = new string[testNum];
            string[] strLine = new string[testNum];

            for (int i = 0; i < testNum; i++)
            {
                strLine[i] = Console.ReadLine().ToString();
                string[] str = strLine[i].Split(' ');
                str1[i] = str[0];
                str2[i] = str[1];
            }

            for (int i = 0; i < testNum; i++)
            {
                Console.WriteLine("Case " + (i + 1) + ":");
                Console.WriteLine(str1[i] + " + " + str2[i] + " = " + BigNum.add(str1[i], str2[i]));
                if (i < testNum - 1)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        static public class BigNum
        {
            static string result;

            public static string add(string left, string right)
            {

                char[] left_num = left.ToCharArray();
                char[] right_num = right.ToCharArray();

                char[] theShort = left_num.Length > right_num.Length ? right_num : left_num;
                char[] theLong = left_num.Length < right_num.Length ? right_num : left_num;

                int maxLength = Math.Max(theShort.Length, theLong.Length);
                int minLength = Math.Min(theShort.Length, theLong.Length);

                int[] nums = new int[maxLength + 1];

                for (int i = 0; i < maxLength; i++)
                {
                    int resultnum = int.Parse(theLong[theLong.Length - 1 - i].ToString());

                    if (i < minLength)
                    {
                        resultnum += int.Parse(theShort[theShort.Length - 1 - i].ToString());
                    }
                    else  // directly copy
                    {
                        resultnum += nums[i];
                    }

                    nums[i + 1] += resultnum / 10;
                    nums[i] = resultnum % 10;

                    result = nums[i] + result;
                }

                Console.Write(left + "+" + right + "=" + result);

                return result;
            }
        }
    }
}
