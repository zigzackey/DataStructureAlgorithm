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

        public bool binarySearch(int left, int right, int[] A, int b)
        {
            if ((right - left) == 0)
                return false;
            else if (A[(left + right) / 2] == b)
                return true;
            else if (A[(left + right) / 2] > b)
            {
                right = (left + right) / 2 - 1;
                return binarySearch(left, right, A, b);
            }
            else
            {
                left = (left + right) / 2 + 1;
                return binarySearch(left, right, A, b);
            }
        }
    }
}
