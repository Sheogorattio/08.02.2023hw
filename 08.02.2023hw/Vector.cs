using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSpace
{
    public class Vector
    {
        public double ValX { get; set; }
        public double ValY { get; set; }
        public double ValZ { get; set; }
        public double Length { get => Math.Sqrt(Math.Pow(ValX, 2) + Math.Pow(ValY, 2) + Math.Pow(ValZ, 2)); }

        public Vector()
        {
            ValX = 0;
            ValY = 0;
            ValZ = 0;
        }
        public Vector(double valX, double valY, double valZ)
        {
            ValX = valX;
            ValY = valY;
            ValZ = valZ;
        }
        public Vector(ref Vector obj)
        {
            ValX = obj.ValX;
            ValY = obj.ValY;
            ValZ = obj.ValZ;
        }
        public void Init()
        {
            Console.WriteLine("Enter X:");
            ValX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            ValY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Z:");
            ValZ = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"({ValX} ; {ValY} ; {ValZ})");
        }
        public void IncreaseBy(double val)
        {
            ValX += val;
            ValY += val;
            ValZ += val;
        }
        public void DecreaseBy(double val)
        {
            ValX-= val;
            ValY-= val;
            ValZ-= val;
        }
        public Vector Sum(ref Vector obj)
        {
            return new Vector(ValX+obj.ValX, ValY+obj.ValY, ValZ+obj.ValZ);
        }

        public Vector Diff(ref Vector obj)
        {
            return new Vector(ValX-obj.ValX, ValY-obj.ValY, ValZ-obj.ValZ);
        }

        public double Prod(ref Vector obj)
        {
            return ValX*obj.ValX+ValY*obj.ValY+ValZ*obj.ValZ;
        }

        public bool IsEqual(ref Vector obj)
        {
            return (Length == obj.Length) && ((ValX % obj.ValX == 0 && ValY % obj.ValY == 0 && ValZ % obj.ValZ == 0) || (obj.ValZ % ValZ == 0 && obj.ValY % ValY == 0 && obj.ValX % ValX == 0));
        }
        public override string ToString()
        {
            return $"({ValX} ; {ValY} ; {ValZ})";
        }
    }
}
