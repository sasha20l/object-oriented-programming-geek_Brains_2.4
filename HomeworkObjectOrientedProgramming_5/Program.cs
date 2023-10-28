using System;

namespace HomeworkObjectOrientedProgramming_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class RationalNumbers
    {
        public int numerator { get; set; }
        public int denominator { get; set; }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static RationalNumbers operator +(RationalNumbers first, RationalNumbers second)
        {
            var result = new RationalNumbers
            {
                numerator = first.numerator + second.numerator,
                denominator = first.denominator + second.denominator
            };
            return result;
      
        }

        public static RationalNumbers operator -(RationalNumbers first, RationalNumbers second)
        {
            var result = new RationalNumbers
            {
                numerator = first.numerator - second.numerator,
                denominator = first.denominator - second.denominator
            };
            return result;
        }

        public static bool operator ==(RationalNumbers first, RationalNumbers second)
        {
            if (first is null && second is null) return false;
            if (first.Equals(second)) return true;
            else return false;
        }

        public static bool operator !=(RationalNumbers first, RationalNumbers second)
        {
            if (first is null && second is null) return true;
            if (first.Equals(second)) return false;
            else return true;

        }

        public static bool operator <(RationalNumbers first, RationalNumbers second)
        {
            if (first < second) return true;
            else return false;
        }

        public static bool operator >(RationalNumbers first, RationalNumbers second)
        {
            if (first < second) return false;
            else return true;

        }

        public static bool operator <=(RationalNumbers first, RationalNumbers second)
        {
            if (first is null && second is null) return false;
            if (first.Equals(second) || first < second) return true;
            else return false;
        }

        public static bool operator >=(RationalNumbers first, RationalNumbers second)
        {
            if (first is null && second is null) return true;
            if (first.Equals(second) || first < second) return false;
            else return true;

        }

        public static RationalNumbers operator *(RationalNumbers first, RationalNumbers second)
        {
            var result = new RationalNumbers
            {
                numerator = first.numerator * second.numerator,
                denominator = first.denominator * second.denominator
            };
            return result;
        }

        public static RationalNumbers operator /(RationalNumbers first, RationalNumbers second)
        {
            var result = new RationalNumbers
            {
                numerator = first.numerator / second.numerator,
                denominator = first.denominator / second.denominator
            };
            return result;
        }

        public static RationalNumbers operator %(RationalNumbers first, RationalNumbers second)
        {
            var result = new RationalNumbers
            {
                numerator = first.numerator % second.numerator,
                denominator = first.denominator % second.denominator
            };
            return result;
        }

    }
}
