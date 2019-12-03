using System;

namespace FindSquareRoot {
    class Program {
        static void Main(string[] args) {
            double square_root = 0;
            try {
                Console.Write("Enter a number to square root by: ");
                bool valid = double.TryParse(Console.ReadLine(), out double num);
                if (!valid) {
                    throw new ApplicationException("You didn't enter a valid double!");
                }
                else {
                    if (num < 0) {
                        throw new ApplicationException("Number cannot be negative!");
                    }
                    else {
                        square_root = Math.Sqrt(num);
                  }
                }
            } catch (ApplicationException e) {
                Console.WriteLine("ERROR: {0}", e.Message);
            }
            Console.WriteLine("Square root is: {0}", square_root);
        }
    }
}
