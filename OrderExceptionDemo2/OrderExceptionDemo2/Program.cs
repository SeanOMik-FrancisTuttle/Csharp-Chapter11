using System;
using System.Threading;

namespace OrderExceptionDemo2 {
    class Order {
        public Order() {
            this.item_number = 0;
            this.quantity = 0;
            this.day_ordered = 0;
        }
        public Order(int item_number, int quantity, int day_ordered) {
            if ((item_number < 100 || item_number > 999) || (quantity < 1 || quantity > 12) || (day_ordered < 1 || day_ordered > 31)) {
                throw new ArgumentException();
            }
            this.item_number = item_number;
            this.quantity = quantity;
            this.day_ordered = day_ordered;
        }
        public int item_number { get; set; }
        public int quantity { get; set; }
        public int day_ordered { get; set; }
        public override string ToString() {
            return "Item number: " + item_number + " - Quantity: " + quantity + " - Day ordered: " + day_ordered;
        }
    }
    class Program {
        static void Main(string[] args) {
            bool auto = false;
            int msWait = 0;
            Random random = new Random();

            Order[] orders = new Order[5];
            for (int i = 0; i < 5; ++i) {
                int order_number;
                bool number_valid = false;
                Console.Write("Enter Order #{0} order number: ", i + 1);
                if (auto) {
                    number_valid = true;
                    Thread.Sleep(msWait);
                    order_number = random.Next(101, 998);
                    Console.WriteLine("{0}", order_number);
                }
                else {
                    number_valid = int.TryParse(Console.ReadLine(), out order_number);
                    if (!number_valid || order_number < 100 || order_number > 999) {
                        orders[i] = new Order();
                        continue;
                    }
                }

                int amount;
                bool amount_valid;
                Console.Write("Enter Order #{0} order quantity: ", i + 1);
                if (auto) {
                    amount_valid = true;
                    Thread.Sleep(msWait);
                    amount = random.Next(1, 12);
                    Console.WriteLine("{0}", amount);
                }
                else {
                    amount_valid = int.TryParse(Console.ReadLine(), out amount);
                    if (!amount_valid || amount < 1 || amount > 12) {
                        orders[i] = new Order();
                        continue;
                    }
                }

                int day_ordered;
                bool day_valid = false;
                Console.Write("Enter Order #{0} ordered date: ", i + 1);
                if (auto) {
                    day_valid = true;
                    Thread.Sleep(msWait);
                    day_ordered = random.Next(1, 31);
                    Console.WriteLine("{0}", day_ordered);
                }
                else {
                    day_valid = int.TryParse(Console.ReadLine(), out day_ordered);
                    if (!day_valid || day_ordered < 1 || day_ordered > 31) {
                        orders[i] = new Order();
                        continue;
                    }
                }

                orders[i] = new Order(order_number, amount, day_ordered);
            }

            foreach (Order order in orders) {
                Console.WriteLine("{0}", order.ToString());
            }
        }
    }
}
