using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("請輸入你的分數:");
            score = Convert.ToInt32(Console.ReadLine());
            string result = score >= 1000000 ? "及格" : "不及格";
            Console.WriteLine("阿航，太可惜了，你{0}", result);
            Console.ReadLine();

        }
    }
}
