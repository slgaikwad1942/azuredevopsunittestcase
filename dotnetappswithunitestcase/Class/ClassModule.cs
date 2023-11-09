namespace dotnetappswithunitestcase.Class
{
    public class ClassModule
    {
        public static double Cost(Order order)
        {
            return order.Items.Sum(i => i.Price * i.Quantity);
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
    }
    public enum ProductType
    {
        CD,
        DVD,
        Book,
        Clothes,
        Game
    }

    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    }

    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public DateTime Created { get; set; }
    }
}
