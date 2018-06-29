using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入十進位數字:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("向左或向右移動<左為1，右為2>:");
            int which = int.Parse(Console.ReadLine());
            Console.WriteLine("移動幾位<以二進位的狀態下移動>:");
            int times = int.Parse(Console.ReadLine());
            int ans;
            Console.WriteLine("---------------分隔線--------------");
            Console.WriteLine("您所輸入的值為: {0}", num);
            if (which == 1)
            {
                ans = num << times;
                Console.WriteLine("您所輸入的值向左移動" + times + "位後，結果為" + ans);
            }
            else
            {
                ans = num >> times;
                Console.WriteLine("您所輸入的值向右移動" + times + "位後，結果為" + ans);
            }
            Console.Read();
        }
    }
}
