using System;

namespace SubscriptExceptionTest {
    class Program {
        static void Main(string[] args) {
            double[] numbers = new double[20];
            try {
                int i = 0;
                while (true) {
                    int number;
                    bool valid;
                    do {
                        Console.Write("Enter Integer #{0}: ", i + 1);
                        
                        valid = int.TryParse(Console.ReadLine(), out number);
                    } while (!valid);
                    numbers[i] = number;
                    i++;
                }
            } catch (IndexOutOfRangeException e) {
                Console.WriteLine("ERROR: {0}", e.Message);
            }
        }
    }
}
