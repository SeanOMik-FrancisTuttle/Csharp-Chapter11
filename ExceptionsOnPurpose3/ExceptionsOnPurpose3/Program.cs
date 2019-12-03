using System;

namespace ExceptionsOnPurpose3 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Enter an integer >> ");
                int answer = Convert.ToInt32(Console.ReadLine());
                int result = answer / 0;
            }
            catch (FormatException e) {
                Console.WriteLine("You didn't enter an integer");
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("This is not your fault.\nYou entered the integer correctly.\nThe program divides by zero.");
            }
        }
    }
}
