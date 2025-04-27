using MyShop;

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop("My shop", 20);

        Customer customer = new Customer();

        customer.Subscriber(shop);

        shop.Discount = 10;
        shop.Discount = 1;
        shop.Discount = -1;
    }
}
