using System;

namespace Challenge
{

    public class Item
    {        
		public static String name;
		public static double price;
		public static bool onSale;
		
		public static void print(){
			if(onSale)
				price = price - price * 0.2;
			
			Console.Write("{0} ({1})", name, price);
		}

        public static string itemPrice(){
            if(onSale)
				price = price - price * 0.2;
			
			return $"{name} (Rp {price})";
        }
	}

    public class ClassObject
    {
        static void Main(string[] args)
        {
            // Make this code works by create new class, method, and property.
            // Item item = new Item();
            Item.name = "Indomie Goreng";
            Item.price = 3500;
            Item.onSale = true; // If true the price will drop 20%

            Item.print(); // Output: "Indomie Goreng (Rp2800)"
        }
    }
}