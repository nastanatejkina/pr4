using System;

namespace pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем пару чисел
            Pair p1 = new Pair(2, 5);
            Pair p2 = new Pair(3, 4);

            // выводим значения полей пар на экран
            p1.Display();
            p2.Display();

            // сравниваем пары и выводим результат сравнения на экран
            if (p1 > p2)
                Console.WriteLine("p1 > p2");
            else if (p1 < p2)
                Console.WriteLine("p1 < p2");
            else
                Console.WriteLine("p1 = p2");

            // создаем дробь
            Fraction f1 = new(3, 4);
            Fraction f2 = new Fraction(1, 2);

            // выводим значения полей дроби на экран
            f1.Display();
            f2.Display();

            // сравниваем дроби и выводим результат сравнения на экран
            if (f1 > f2)
                Console.WriteLine("f1 > f2");
            else if (f1 < f2)
                Console.WriteLine("f1 < f2");
            else
                Console.WriteLine("f1 = f2");

            Console.ReadKey();

        }
    }
}
