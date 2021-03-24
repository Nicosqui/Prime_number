using System;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Es " + number + " un número primo? " + IsPrime(number));
        }

        static bool IsPrime(int n)
        {
            return IsPrime(n, 2);
        }
        static bool IsPrime(int n, int i)
        {
            // i is supposed to start as 2.
            if (n % i == 0)
            {
                return false;
            }
            else if (i >= n / 2)
            {
                return true;
            }
            else
            {
                return IsPrime(n, i + 1);
            }
        }
    }
}
