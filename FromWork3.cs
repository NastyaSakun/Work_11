using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11
{
    class Array:IComparable
    {
        public static int count;

        public int[] mas2 = new int[4];

        public Array(int a, int b) { mas2[1] = a; mas2[2] = b; count++; }
        public Array(int a, int b, int c) { mas2[1] = a; mas2[2] = b; mas2[3] = c; count++; }
        public Array() { mas2[1] = 9; count++; }

        public void PrintMas1()
        {

            Console.Write("Массив2: ");
            foreach (int i in mas2)
            {
                Console.Write($"{i}\0");
            }

        }

        

        public static void Method()
        {
            Console.WriteLine($"Счётчик объектов:\0{Array.count}\n");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    class Player
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        
    }
}
