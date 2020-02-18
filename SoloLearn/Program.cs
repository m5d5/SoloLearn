using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] _)
        {
            /* string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", yourName);
            */

            /*
            int x;
            string y = "";
            for (x = 2; x <= 30; x++)
            {
                if (x % 2 == x % 4)
                    break;
                y += Convert.ToString(x);
            }
            Console.WriteLine(y);
            */

            // Console.WriteLine(32 % 2 * 2);

            /*
            int x = 15;
            x /= 7;
            x %= 1;
            Console.WriteLine(++x);
            */

            /*
            string a = "1f013h3";
            char b = a[1];
            Console.WriteLine(++b);
            */

            /*
            int l = 4;
            int x = ++l + l++;
            Console.WriteLine(x);
            Console.WriteLine(l);
            */

            /*
            bool a = true;
            bool b = false;
            bool q1 = (a && !b);
            bool q2 = (!a || b);
            bool q3 = (!b && a);
            bool q4 = q1 ? q2 : q3;
            bool x = (a && !b) ? (!a || b) : (!b && a);
            Console.WriteLine(x ? 1 : 0);
            */

            /*
            int[] a = { 1, 0, 5, 2, 8 };
            int b = 8;
            bool k = true;
            foreach(int t in a)
            {
                k = k && t < b;
            }
            Console.WriteLine(k);
            */

            /*
            int x = 10;
            do
            {
                x *= 2;
            } while (x <= 5);
            Console.WriteLine(x);
            */

        }
    }
}
