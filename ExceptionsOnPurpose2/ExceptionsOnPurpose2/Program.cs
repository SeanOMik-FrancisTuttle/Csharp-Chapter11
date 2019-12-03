using System;

namespace ExceptionsOnPurpose2 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Enter an integer >> ");
                int answer = Convert.ToInt32(Console.ReadLine());
                int result = answer / 0;
            } catch (Exception e) {
                Console.WriteLine("ERROR {0}", e.Message);
            }
        }
    }
}
