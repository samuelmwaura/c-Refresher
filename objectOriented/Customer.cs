namespace fundamentals.objectOriented
{
    public class Customer
    {
        public int id;
        public string name;
        public readonly List<Order> orders = new List<Order>(); // This is assignment at initialization instead of doing that in a custom constructor. Make sure no null found
        //Adding readonly modifier makes sure that the field cannot be reassigned at any other point but can be modified   

    }
}