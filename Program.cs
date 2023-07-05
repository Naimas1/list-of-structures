using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_structures
{
    struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real + num2.Real;
            double imaginary = num1.Imaginary + num2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real - num2.Real;
            double imaginary = num1.Imaginary - num2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real * num2.Real - num1.Imaginary * num2.Imaginary;
            double imaginary = num1.Real * num2.Imaginary + num1.Imaginary * num2.Real;
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double divisor = num2.Real * num2.Real + num2.Imaginary * num2.Imaginary;
            double real = (num1.Real * num2.Real + num1.Imaginary * num2.Imaginary) / divisor;
            double imaginary = (num1.Imaginary * num2.Real - num1.Real * num2.Imaginary) / divisor;
            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            string sign = (Imaginary >= 0) ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }

    class Programas
    {
        static void Main()
        {
            ComplexNumber num1 = new ComplexNumber(2, 3);
            ComplexNumber num2 = new ComplexNumber(4, -1);

            ComplexNumber sum = num1 + num2;
            ComplexNumber difference = num1 - num2;
            ComplexNumber product = num1 * num2;
            ComplexNumber quotient = num1 / num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {difference}");
            Console.WriteLine($"{num1} * {num2} = {product}");
            Console.WriteLine($"{num1} / {num2} = {quotient}");
        }
    }
}
