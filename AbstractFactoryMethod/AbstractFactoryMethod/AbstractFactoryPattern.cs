using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    public interface IPizza // Product
    {
        string Eat();
    }

    class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Veg Pizza";
        }
    }

    class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Non-Veg Pizza";
        }
    }

    public interface IBurger // Product
    {
        string Eat();
    }

    class VegBurger : IBurger
    {
        public string Eat()
        {
            return "Eating Veg Burger";
        }
    }

    class NonVegBurger : IBurger
    {
        public string Eat()
        {
            return "Eating Non-Veg Burger";
        }
    }

    interface IChef // Factory
    {
        IPizza PreparePizza();
        IBurger PrepareBurger();
    }



    class VegChef : IChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }

        public IBurger PrepareBurger()
        {
            return new VegBurger();
        }

    }

    class NonVegChef : IChef
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }

        public IBurger PrepareBurger()
        {
            return new NonVegBurger();
        }
    }

    class Waiter // Client
    {
        private IChef foodfactory;

        public Waiter(string type)
        {
            switch (type)
            {
                case "Veg":
                    foodfactory = new VegChef();
                    break;
                case "NonVeg":
                    foodfactory = new NonVegChef();
                    break;
                default:
                    throw new Exception("Invalid Chef Type");
            };
        }

        public IPizza GetPizza() 
        {
            return foodfactory.PreparePizza();
        }
        public IBurger GetBurger() 
        { 
            return foodfactory.PrepareBurger();
        }
    }
}
