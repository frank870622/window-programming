using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4._2
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int n;

            Console.Write("請輸入盤數:");
            n = int.Parse(Console.ReadLine()); 
            tower(n, 'A', 'B', 'C');
            Console.Read();

        }

        public static void tower(int n, char left, char middle, char right)
        {
            if (n == 1)
            {
                Console.WriteLine("Move sheet from" + left + "to" + right);
                ++count;
            }
            else {
                tower(n - 1, left, right, middle);
                Console.WriteLine("Move sheet from" + left + "to" + right);
                ++count;
                tower(n - 1, middle, left, right);
            }
        }
    }
}
