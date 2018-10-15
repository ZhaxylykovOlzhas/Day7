using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualityTest equalityTest1 = new EqualityTest();
            EqualityTest equalityTest2 = new EqualityTest();
            Console.WriteLine("Введите 1-имя:");
            equalityTest1.Name = Console.ReadLine();
            Console.WriteLine("Введите 2-имя:");
            equalityTest2.Name = Console.ReadLine();

            Console.WriteLine("Проверка на равенства /если равен вернеть-true, если нет то-false:  " + (equalityTest1 == equalityTest2));

            Console.ReadKey();
        }
    }
}
