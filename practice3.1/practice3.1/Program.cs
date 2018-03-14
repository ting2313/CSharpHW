using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sw,num,i,j,k;
            try
            {
                Console.WriteLine("請選擇 1)正方形 2)三角形 :");
                sw = int.Parse(Console.ReadLine());
                if (sw > 2) throw new ArgumentException();
                Console.WriteLine("請輸入需要繪製的大小:");
                num = int.Parse(Console.ReadLine());
                if (sw == 1)
                {
                    for (i = 1; i <= num; i++)
                    {
                        for (j = 1; j <= num; j++)  Console.Write("*");
                        Console.Write("\n");
                    }
                }
                else
                {
                    for (i = 1; i <= num; i++)
                    {
                        for (j = 1; j <= num - i; j++)  Console.Write(" ");
                        for (k = 1; k < i * 2; k++)  Console.Write("{0}", i);
                        Console.Write("\n");
                    }
                }
                Console.Read();
            }
            catch(ArgumentException)
            {
                Console.Write("請重新執行！\n請按任意鍵繼續...");
                Console.Read();
            }
        }
    }
}
