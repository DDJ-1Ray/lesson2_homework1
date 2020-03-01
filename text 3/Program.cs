using System;

namespace text_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數:");
            int number = Int32.Parse(Console.ReadLine());
            Print(number);
            //if (Decide(number))
            //{
            //    Console.WriteLine("是");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
        }
        static bool Decide(int n)//判斷是不是素數
        {
            for(int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Do(int n)//找出他的素數
        {
            for(int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    int a = n / i;
                    if (Decide(a))
                        Console.Write("{0},",a);
                }
            }
        }
        static void Print(int n)
        {
            if (n == 1)
                Console.WriteLine("1沒有素數因子");
            Console.Write("這個數的素數因子有:");
            Do(n);
            Console.WriteLine("");
        }
    }
}
