using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sw = 4;
            int flag = 0;
            int n = 1;
            int by = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("請選擇動作： 1)輸入資料 2)印出資料 3)排序 0)離開 >");
                    sw = int.Parse(Console.ReadLine());
                    switch (sw)
                    {
                        case 0:
                            throw new ArgumentException();
                            break;
                        case 1:
                            flag = 1;
                            Console.Write("請輸入班級人數>");
                            n = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("尚無成績資料");
                            break;
                        case 3:
                            Console.WriteLine("尚無成績資料");
                            break;
                    }                    
                    if (flag == 1) break;
                }

                int[] num = new int[n];
                int[] chinese = new int[n];
                int[] english = new int[n];
                int[] math = new int[n];
                int[] index = new int[n];

                for (int i = 0; i < n; i++)
                {
                    num[i] = i + 1;
                    Console.WriteLine("請輸入{0}號同學的成績：", i + 1);
                    Console.Write("國文成績>");
                    chinese[i] = int.Parse(Console.ReadLine());
                    Console.Write("英文成績>");
                    english[i] = int.Parse(Console.ReadLine());
                    Console.Write("數學成績>");
                    math[i] = int.Parse(Console.ReadLine());
                }

                while (true)
                {

                    Console.Write("請選擇動作： 1)輸入資料 2)印出資料 3)排序 0)離開 >");
                    sw = int.Parse(Console.ReadLine());
                    switch (sw)
                    {
                        case 0:
                            throw new ArgumentException();
                            break;
                        case 1:
                            flag = 1;
                            Console.WriteLine("已輸入過成績。");
                            break;
                        case 2:
                            if (flag == 1)
                            {
                                Console.WriteLine("座號   國文  英文  數學");
                                Console.WriteLine("=======================================");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("{0}      {1}     {2}     {3}", num[i], chinese[i], english[i], math[i]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("尚無成績資料");
                            }
                            break;
                        case 3:
                            if (flag == 1)
                            {
                                Console.Write("請輸入排序依據；1)座號 2)國文 3)英文 4)數學 >");
                                by = int.Parse(Console.ReadLine());
                                switch (by)
                                {
                                    case 1:
                                        num.CopyTo(index, 0);
                                        Array.Sort(num, english);
                                        index.CopyTo(num, 0);
                                        Array.Sort(num, chinese);
                                        index.CopyTo(num, 0);
                                        Array.Sort(num, math);
                                        break;
                                    case 2:
                                        chinese.CopyTo(index, 0);
                                        Array.Sort(chinese, num);
                                        index.CopyTo(chinese, 0);
                                        Array.Sort(chinese, english);
                                        index.CopyTo(chinese, 0);
                                        Array.Sort(chinese, math);
                                        break;
                                    case 3:
                                        english.CopyTo(index, 0);
                                        Array.Sort(english, num);
                                        index.CopyTo(english, 0);
                                        Array.Sort(english, chinese);
                                        index.CopyTo(english, 0);
                                        Array.Sort(english, math);
                                        break;
                                    case 4:
                                        math.CopyTo(index, 0);
                                        Array.Sort(math, num);
                                        index.CopyTo(math, 0);
                                        Array.Sort(math, chinese);
                                        index.CopyTo(math, 0);
                                        Array.Sort(math, english);
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("尚無成績資料");
                            }
                            break;
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("程式結束，按任意鍵繼續...");
                Console.Read();
            }
        }
    }
}
