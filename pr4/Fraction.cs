using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    public class Fraction : Pair
    {
        private int whole;

        public Fraction(int whole, int numerator, int denominator) : base(numerator, denominator)
        {
            if (whole < 0)
            {
                Console.WriteLine("Error: whole number cannot be negative.");
                Environment.Exit(1);
            }

            this.whole = whole;
        }

        public Fraction(int first, int second) : base(first, second)
        {
        }

        public new void Read()
        {
            Console.Write("Введите целое число: ");
            int whole = int.Parse(Console.ReadLine());

            Console.Write("Введите числитель:");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель: ");
            int denominator = int.Parse(Console.ReadLine());

            SetValues(whole, numerator, denominator);
        }

        public new void Display()
        {
            Console.WriteLine($"Fraction: {whole} ");
        }

        public void SetValues(int whole, int numerator, int denominator)
        {
            if (whole < 0)
            {
                Console.WriteLine("значения не могут быть отрицательными");
                Environment.Exit(1);
            }

            base.SetValues(numerator, denominator);
            this.whole = whole;
        }

        public bool IsGreater(Fraction other)
        {
            if (whole > other.whole)
            {
                return true;
            }
            else if (whole == other.whole)
            {
                return base.IsGreater(other);
            }

            return false;
        }
    }
}
