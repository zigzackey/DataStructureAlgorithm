using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<int> A = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                A.Add(a);
            }

            bool ans = new Program().linearSearch(n, A, b);
            if (ans)
                Console.WriteLine("見つかったよ");
            else
                Console.WriteLine("見つからなかったよ");
        }

        public bool linearSearch(int n, List<int> A, int b)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i] == b)
                    return true;
            }
            return false;
        }
    }
}
