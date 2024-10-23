using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 2, 3, 3, 4, 5, 7, 9, 11, 12, 15 };
            if (BinSearch(12, v, 0, v.Length-1)) Console.WriteLine("da");
            else Console.WriteLine("nu");
        }

        static bool BinSearch(int x, int[] v, int left, int right)
        {
            if (left > right) return false;

            int mid = (left + right) / 2;

            if (v[mid] == x) 
                return true;
            else if (x < v[mid]) 
                return BinSearch(x, v, 0, mid-1);
            else 
                return BinSearch(x, v, mid+1, right);
        }
    }
}