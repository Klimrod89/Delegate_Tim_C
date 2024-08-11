using System;

namespace DemoLibrary;

public class ShoppingCartModel
{
    public delegate void MentionDiscount(decimal subTotal);
    public List<ProductModel> Items { get; set; } = new();

    public decimal GenerateTotal(MentionDiscount alertUser,
        Func<List<ProductModel>, decimal, decimal> getSubTotal,
        Action<string> mentionDiscount)
    {
        decimal subTotal = Items.Sum(x => x.Price);
        alertUser(subTotal);
        mentionDiscount("We are applying the discount.");
        return getSubTotal(Items, subTotal);
    }
}
