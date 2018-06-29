using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請選擇 1> 正方形 2> 三角形");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine("請輸入要繪製的大小:");
                int times = int.Parse(Console.ReadLine());
                string ans = "";
                for(int i = 1; i <= times; ++i)
                {
                    for (int j = 1; j <= times; ++j) {
                        ans += "*";
                    }
                    ans += "\r\n";
                }
                Console.WriteLine(ans + "共使用" + times * times + "個'*'");
            }
            else if(option == 2)
            {
                Console.WriteLine("請輸入要繪製的大小:");
                int times = int.Parse(Console.ReadLine());
                string ans = "";
                int num = 0;
                for(int i  = 1; i <= times; ++i)
                {
                    for(int j = 1; j <= times-i; ++j)
                    {
                        ans += " ";
                    }
                    for(int j = 1; j <= 1 + 2*(i-1); ++j)
                    {
                        ans += i;
                        ++num;
                    }
                    ans += "\r\n";
                }
                Console.WriteLine(ans + "共使用" + times + "組數字 和" + num + "個數字");
            }
            else
            {
                Console.WriteLine("請重新執行!");
            }
            Console.Read();
        }
    }
}
