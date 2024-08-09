
using System.Runtime.CompilerServices;
using DemoLibrary;

PopulateCartWithDemoData();

Console.WriteLine($"The total for the cart is {cart.GenerateTotal():C2}");

Console.WriteLine();
Console.Write("Please press any key to exit the application...");
Console.ReadKey();

static void PopulateCartWithDemoData()
{
    cart.Items.Add(new () { ItemName = "Cereal", Price = 3.63M });
    cart.Items.Add(new () { ItemName = "Milk", Price = 2.95M });
    cart.Items.Add(new () { ItemName = "Strawberries", Price = 7.51M });
    cart.Items.Add(new () { ItemName = "Blueberries", Price = 8.84M });
}

public partial class Program
{
    static ShoppingCartModel cart = new();
}
