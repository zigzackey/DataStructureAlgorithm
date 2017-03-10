using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int ans = new Program().euclid(m, n);
            Console.WriteLine("最大公約数 = " + "{0}", ans);
        }

        public int euclid(int m, int n)
        {
            while (true)
            {
                int r = m % n;
                if (r == 0)
                    return n;
                m = n;
                n = r;
            }
        }
    }
}
