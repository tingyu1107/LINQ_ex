using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串: ");
            string s = Console.ReadLine();
            string[] s1 = s.Split(',');

            foreach (string i in s1)
            {
                int a = Convert.ToInt32(i);
                //Console.WriteLine(i);
                list.Add(a);
            }
            var order = list.OrderBy(x => x);
            var num1 = from p in order
                       where p % 2 == 1
                       select p;
            var num0 = from p in order
                       where p % 2 == 0
                        select p;

            string join1 = string.Join(", ", num1);
            Console.WriteLine("奇數: " + join1);

            string join0 = string.Join(", ", num0);
            Console.WriteLine("偶數: "+ join0);

            Console.ReadLine();
        }
    }
}
