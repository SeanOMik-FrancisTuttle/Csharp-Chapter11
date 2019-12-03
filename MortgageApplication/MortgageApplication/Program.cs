using System;

namespace MortgageApplication {
    class Program {
        static bool IsEligible(int credit_score) {
            if (credit_score >= 300 && credit_score <= 850) {
                return credit_score >= 650;
            } else {
                throw new ArgumentException();
            }
        }
        static void Main(string[] args) {
            while (true) {
                int credit_score;
                bool valid = false;
                do {
                    Console.Write("Enter applicant credit score: ");
                    valid = int.TryParse(Console.ReadLine(), out credit_score);
                } while (!valid);
                try {
                    bool is_eligible = IsEligible(credit_score);
                    Console.WriteLine("The applicant is {0}", is_eligible ? "Eligible!" : "Not eligible!");
                } catch (ArgumentException e) {
                    Console.WriteLine("The applicant is not valid!");
                }
            }
        }
    }
}
