using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorSpace;

namespace _08._02._2023hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector A = new Vector(1,2,3);
            Vector B = new Vector(1,2,3);
            Console.Write($"A coord:");
            A.Print();
            Console.WriteLine("A length:{0:0.00}", A.Length);
            Console.Write($"B coord:");
            B.Print();
            Console.WriteLine("B length:{0:0.00}", B.Length);
            Console.WriteLine($"A==B:{A.IsEqual(ref B)}");
            Console.ReadKey();
        }
    }
}
