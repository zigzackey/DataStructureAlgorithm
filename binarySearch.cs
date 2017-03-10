using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
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

            int[] AA = A.ToArray();
            bool ans = new Program().binarySearch(0, n, AA, b);
            if (ans)
                Console.WriteLine("見つかったよ");
            else
                Console.WriteLine("見つからなかったよ");
        }

        public bool binarySearch(int first, int last, int[] A, int b)
        {
            if (last - first == 0)
                return false;
            else if (A[(last - first) / 2] == b)
                return true;
            else if (A[(last - first) / 2] > b)
            {
                last = last / 2 - 1;
                return binarySearch(first, last, A, b);
            }
            else
            {
                first = last / 1 + 1;
                return binarySearch(first, last, A, b);
            }
        }
    }
}
