namespace DemoLibrary.Tests;

public class ShoppingCartModelTests
{
    [Fact]
    public void GenerateTotalWithDiscount()
    {
        // Arrange
        var sut =  CreateShoppingCartModel();
        PopulateCart(sut);
        
        decimal expected = 20.637M;

        // Act
        decimal actual = sut.GenerateTotal();

        // Assert
        Assert.Equal(actual, expected);
    }

    private void PopulateCart(ShoppingCartModel cart)
    {
        cart.Items.Add(new() { ItemName = "Cereal", Price = 3.63M });
        cart.Items.Add(new() { ItemName = "Milk", Price = 2.95M });
        cart.Items.Add(new() { ItemName = "Strawberries", Price = 7.51M });
        cart.Items.Add(new() { ItemName = "Blueberries", Price = 8.84M });
    }

    private static ShoppingCartModel CreateShoppingCartModel() => new ShoppingCartModel();
}