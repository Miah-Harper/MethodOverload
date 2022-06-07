using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int add1 = Add(4,6);
            double add2 = Add(4.2, 6.2);
            string add3 = Add(4, 6, true);

            Console.WriteLine(add1);
            Console.WriteLine(add2);
            Console.WriteLine(add3);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
          public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";

            }

            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }

            else
            {
                return sum.ToString();
            }
        }
    }

}

