using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        private static void Honoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine("Move sheet from {0} to {1}", A, C);
            }
            else
            {
                Honoi(n - 1, A, C, B);
                Console.WriteLine("Move sheet from {0} to {1}", A, C);
                Honoi(n - 1, B, A, C);
            }
        }

        static void Main(string[] args)
        {
            int n;
            char A='A',B='B',C='C';
            Console.Write("請輸入盤數：");
            n = int.Parse(Console.ReadLine());
            Honoi(n, A, B, C);
            Console.ReadLine();
        }
    }
}
