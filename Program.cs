using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_structures
{
    struct Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            return SimplifyFraction(new Fraction(numerator, denominator));
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            return SimplifyFraction(new Fraction(numerator, denominator));
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Numerator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            return SimplifyFraction(new Fraction(numerator, denominator));
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator;
            int denominator = fraction1.Denominator * fraction2.Numerator;
            return SimplifyFraction(new Fraction(numerator, denominator));
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static Fraction SimplifyFraction(Fraction fraction)
        {
            int gcd = GetGreatestCommonDivisor(fraction.Numerator, fraction.Denominator);
            return new Fraction(fraction.Numerator / gcd, fraction.Denominator / gcd);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    class Programd
    {
        static void Main()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 2);

            Fraction addition = fraction1 + fraction2;
            Fraction subtraction = fraction1 - fraction2;
            Fraction multiplication = fraction1 * fraction2;
            Fraction division = fraction1 / fraction2;

            Console.WriteLine($"{fraction1} + {fraction2} = {addition}");
            Console.WriteLine($"{fraction1} - {fraction2} = {subtraction}");
            Console.WriteLine($"{fraction1} * {fraction2} = {multiplication}");
            Console.WriteLine($"{fraction1} / {fraction2} = {division}");
        }
    }
}
