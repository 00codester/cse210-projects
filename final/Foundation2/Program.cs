using System;

class Program
{
    static void Main(string[] args)
    { 
        Order order1 = new Order("Billy Jones", "78 Cannon St.", "Billings", "MT", "USA");
        order1.AddProduct("Watermellon", "AH64D111", 4.99, 3.0);
        order1.AddProduct("Nintendo Switch", "NINSWI2019", 150, 1);
        order1.AddProduct("Oreo's", "OR432341", 2.99, 4);
        Order order2 = new Order("Diana Becerra Delgado", "123 Chiclayo St.", "Cajamarca", "Pueblo Alto", "Peru");
        order2.AddProduct("Tire", "SNOWT54456", 39.99, 4);
        order2.AddProduct("Wiper Blades", "WIPB84848", 15.98, 1);
        order2.AddProduct("Pool Noodle", "PNOOD4444", 1.0, 5);

        string por1 = order1.PackingLabel();
        string sor1 = order1.ShippingLabel();
        double tc1 = order1.TotalCost();

        string por2 = order2.PackingLabel();
        string sor2 = order2.ShippingLabel();
        double tc2 = order2.TotalCost();

        Console.WriteLine("----------------------");
        Console.WriteLine(por1);
        Console.WriteLine(sor1);
        Console.WriteLine($"Total Cost of Order: {tc1}");
        Console.WriteLine();
        Console.WriteLine("----------------------");
        Console.WriteLine(por2);
        Console.WriteLine(sor2);
        Console.WriteLine($"Total Cost of Order: {tc2}");
        Console.WriteLine();
        Console.WriteLine("----------------------");
    }
}