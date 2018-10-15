using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOverload
{
    class Array
    {
        int[] intArray; 
        int n;
        public Array(int[] a, int b) 
        {
            intArray = a;
            n = b;
        }
        public void Razmer()
        {
            Console.Write("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
                intArray[i] = int.Parse(Console.ReadLine()); 
        }

        public void Print() 
        {
            Console.Write("Массив: ");
            int count = 0; 
            for (int i = 0; i < n; i++)
            {
                Console.Write(intArray[i] + " ");
                count++;
            }
            if (count == 0)
                Console.WriteLine("Массив пуст");
        }

        public void Sortirovka()
        {
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n - 1; j++) 
                {
                    if (intArray[j] > intArray[j + 1]) 
                    {
                        int z = intArray[j]; 
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = z; 
                    }
                }
            }
        }

        public static Array operator +(Array a, Array b)
        {
            Console.WriteLine();
            Console.WriteLine("+");

            if (a.n != b.n)
                throw new InvalidOperationException();
            var res = new Array(new int[a.n], a.n);
            for (int i = 0; i < a.n; i++)
            {
                res.intArray[i] = a.intArray[i] + b.intArray[i];
            }
            return res;  
        }

    }
}
