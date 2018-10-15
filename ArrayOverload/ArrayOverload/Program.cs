using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите размерность 1-массива ");
            N = int.Parse(Console.ReadLine());


          
            int[] A = new int[N];
            Array massiv = new Array(A, N); 
            massiv.Razmer();
            massiv.Print();
            Array s = new Array(A, A.Length); 
            s.Sortirovka(); 
            s.Print();


            int a = 0;
            for (int i = 0; i < A.Length; i++)
            {
                a += A[i];
            }
            Console.WriteLine("\nCумма 1-массива = " + a);



            int N1;
            Console.WriteLine("\n\nВведите размерность 2-массива ");
            N1 = int.Parse(Console.ReadLine());


            int[] A1 = new int[N1];
            Array massiv1 = new Array(A1, N1);
            massiv1.Razmer();
            massiv1.Print();
            Array s1 = new Array(A1, A1.Length);
            s1.Sortirovka();
            s1.Print();


            int a1 = 0;
            for (int i = 0; i < A1.Length; i++)
            {
                a1 += A1[i];
            }
            Console.WriteLine("\nCумма 2-массива = " + a1);

            bool lengthСheck = false;

            if (a > a1)
            {
                lengthСheck = true;
                Console.WriteLine("\n\n\n"+lengthСheck);
            }
            else
            {
                Console.WriteLine("\n\n\n" + lengthСheck);
            }

            Console.ReadLine();
        }
    }
}
