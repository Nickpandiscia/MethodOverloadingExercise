using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var a = Add(1, 4);
            var b = Add(2.3m, 3.3m);
            var c = Add(0, 1, true);
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
            Console.ReadLine();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
           return (decimal)num1 + num2;
        }
        public static string Add(int num1, int num2, bool IsTrue)
        {
            var sum = num1 + num2;

            if (IsTrue)
            {
                

                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
                                              
            }
           
            else
            {
                return $"{sum}";
                
            }                           
        }
    }
}
