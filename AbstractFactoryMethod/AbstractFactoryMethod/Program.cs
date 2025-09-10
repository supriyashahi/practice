using AbstractFactoryMethod;

class program
{
    public static void Main(string[] args)
    {
        Waiter waiter = new Waiter("Veg"); // Client
        IPizza pizza = waiter.GetPizza(); // Factory Method
        IBurger burger = waiter.GetBurger(); // Factory Method
        Console.WriteLine(pizza.Eat());
        Console.WriteLine(burger.Eat());
        Console.ReadLine();
    }
}