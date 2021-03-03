using System;

namespace dividedNumbers
{
    class Program
    {
        static bool CheckDividerPrime(int K)
        {
            bool isPrime = true;
            if (K < 2)
                isPrime = false;
            else
            for (int i = 2; i <= K / 2; i++)
            {
                if (K % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            string s = Console.ReadLine();
            int N = int.Parse(s);
            Console.WriteLine("Введите первый делитель: X");
            s = Console.ReadLine();
            int X = int.Parse(s);
            if (CheckDividerPrime(X) == false)
            {
                Console.WriteLine("Неверный делитель {0}", X);
                return;
            }
            Console.WriteLine("Введите второй делитель: Y");
            s = Console.ReadLine();
            int Y = int.Parse(s);
            if (CheckDividerPrime(Y) == false)
            {
                Console.WriteLine("Неверный делитель {0}", Y);
                return;
            }
            int k = 0;
            for (int i = 2; i < N; i++)
            {
                if (i % X == 0)
                    k++;
                if (i % Y == 0)
                    k++;
            }
            Console.WriteLine(k);
        }
    }
}
