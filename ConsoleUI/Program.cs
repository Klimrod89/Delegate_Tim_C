
using System.Runtime.CompilerServices;
using DemoLibrary;

PopulateCartWithDemoData();

Console.WriteLine($"The total for the cart is {cart.GenerateTotal(TellUser, CalculateSubTotal, DiscountInProcess):C2}");
Console.WriteLine($"The total for the cart is {cart.GenerateTotal(x=>Console.WriteLine($"The subtotal is {x:C2}"), (x, y) => )}");


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

static decimal CalculateSubTotal(List<ProductModel> products, decimal subTotal)

    => subTotal switch
    {
        > 100 => subTotal * 0.80M,
        > 50 => subTotal * 0.85M,
        > 10 => subTotal * 0.95M,
        _ => subTotal
    };

static void DiscountInProcess(string message) => Console.WriteLine(message);


static void TellUser(decimal price) => Console.WriteLine($"The subtotal is {price:C2}");
public partial class Program
{
    static ShoppingCartModel cart = new();
}
