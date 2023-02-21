using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var list = new List<string>();
            Console.WriteLine("輸入一串以逗號分隔的字串: ");
            string s = Console.ReadLine();
            string[] s1 = s.Split(',');

            foreach (string i in s1)
            {
                
                //Console.WriteLine(i);
                list.Add(i);
            }

            var list1 = list.OrderByDescending (x => list.IndexOf(x));

            string join = list1.Aggregate((x, y) => x + "," + y);
            Console.WriteLine(join);

            Console.ReadLine();
        }
    }
}
