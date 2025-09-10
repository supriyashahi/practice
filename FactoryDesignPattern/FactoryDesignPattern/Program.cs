using FactoryDesignPattern;

class Program
{
    public static void Main(string[] args)
    {
        Waiter waiter = new Waiter(); // Client
        IPizza pizza = waiter.GetPizza("Veg"); // Factory Method
        Console.WriteLine(pizza.Eat()); // Product Method
        pizza = waiter.GetPizza("NonVeg");
        Console.WriteLine(pizza.Eat());
        Console.ReadLine();
    }
}