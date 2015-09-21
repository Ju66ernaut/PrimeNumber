using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer");
            int input;
            do
            {                
                bool isNumeric = int.TryParse(Console.ReadLine(), out input);

                
                if (!isNumeric)
                {
                    Console.WriteLine("Error: Please input an integer");
                }
                else
                {
                    if (NumberIsPrime(input))
                    {
                        Console.WriteLine(input + " is a prime number");
                    }
                    else
                    {
                        Console.WriteLine(input + " is not a prime number");
                    }
                }
                
            } while (true);           
                        
        }

        internal static bool NumberIsPrime(int input)
        {
            double boundary = Math.Floor(Math.Sqrt(input));

            if (input == 1) return false;
            if (input == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (input % i == 0) return false;
            }

            return true;  
        }
    }
}
