using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    public class Pair
    {
         int first;
         int second;

        public Pair(int first, int second)
        {
            if (first < 0 || second < 0)
            {
                Console.WriteLine(" значения не могут быть отрицательными");
                Environment.Exit(1);
            }

            this.first = first;
            this.second = second;
        }

        public void Read()
        {
            Console.Write("Введите первое значение:");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введите второе значение:");
            int second = int.Parse(Console.ReadLine());

            SetValues(first, second);
        }

        public void Display()
        {
            Console.WriteLine($"Pair: ({first}, {second})");
        }

        public void SetValues(int first, int second)
        {
            if (first < 0 || second < 0)
            {
                Console.WriteLine("значения не могут быть отрицательными.");
                Environment.Exit(1);
            }

            this.first = first;
            this.second = second;
        }
        

        

        public bool IsGreater(Pair other)
        {
            if (first > other.first || (first == other.first && second > other.second))
            {
                return true;
            }

            return false;
        }
       public static bool operator >(Pair a, Pair b)
{
    return (a.first > b.first) || (a.first == b.first && a.second > b.second);
}

public static bool operator <(Pair a, Pair b)
{
    return (a.first < b.first) || (a.first == b.first && a.second < b.second);
}

public static bool operator >=(Pair a, Pair b)
{
    return (a.first > b.first) || (a.first == b.first && a.second >= b.second);
}

public static bool operator <=(Pair a, Pair b)
{
    return (a.first < b.first) || (a.first == b.first && a.second <= b.second);
}

    }
}
