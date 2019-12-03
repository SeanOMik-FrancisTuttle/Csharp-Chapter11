using System;

namespace OrderExceptionDemo {
    class Order {
        public Order(int item_number, int quantity, int day_ordered) {
            if ( (item_number < 100 || item_number > 999) || (quantity < 1 || quantity > 12) || (day_ordered < 1 || day_ordered > 31) ) {
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
			Order order = new Order(200, 5, 20);
			Console.WriteLine("Order #1: {0}", order.ToString());

			try {
				order = new Order(0, 5, 20);
			} catch (ArgumentException e) {
				Console.WriteLine("Threw exception: {0}", e.Message);
			}

			order = new Order(800, 10, 5);
			Console.WriteLine("Order #3: {0}", order.ToString());
		}
	}
}
