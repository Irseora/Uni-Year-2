using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Algoritmi
{
    class Program
    {
        static void Hanoi3(int n, char A, char B, char C)
        {
            if (n == 1) Console.WriteLine(A + " -> " + C);
            else
            {
                Hanoi3(n-1, A, C, B);
                Hanoi3( 1,  A, B, C);
                Hanoi3(n-1, B, A, C);
            }
        }

        static void Hanoi4(int n, char A, char B, char C, char D)
        {
            if (n == 1) Console.WriteLine(A + " -> " + D);
            else if (n == 2)
            {
                Console.WriteLine(A + " -> " + C);
                Console.WriteLine(A + " -> " + D);
                Console.WriteLine(C + " -> " + D);
            }
            else
            {
                Hanoi4(n-2, A, C, D, B);
                Hanoi4( 1,  A, D, B, C);
                Hanoi4( 1,  A, B, C, D);
                Hanoi4( 1,  C, A, B, D);
                Hanoi4(n-2, B, A, C, D);
            }
        }

        static void Main(string[] args)
        {
            //Hanoi3(4, 'A', 'B', 'C');
            Hanoi4(5, 'A', 'B', 'C', 'D');
        }
    }
}