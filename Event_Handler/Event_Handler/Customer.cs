using DiscountChanged;
using MyShop;

class Customer
{
    public void Subscriber(Shop shop)
    {
        shop.DiscountChanged += OnDiscountChanged;
    }

    private void OnDiscountChanged(object sender, DiscountChangedEventArgs e)
    {
        System.Console.WriteLine($"The discount changed {e.OldDiscount}% to {e.NewDiscount}%");
    }
}