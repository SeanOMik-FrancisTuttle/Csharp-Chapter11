using System;

namespace ExceptionsOnPurpose {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the integer >> ");
            int answer = Convert.ToInt32(Console.ReadLine());
            int result = answer / 0;
            Console.WriteLine("The answer is {0}", answer);
        }
    }
}
