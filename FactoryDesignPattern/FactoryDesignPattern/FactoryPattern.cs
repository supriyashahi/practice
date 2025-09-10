using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
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

    interface IPizzaChef // Factory
    {
        IPizza PreparePizza();
    }

    class VegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
    }

    class NonVegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }
    }

    class Waiter // Client
    {
        public IPizza GetPizza(string type)
        {
            IPizzaChef chef;
            switch (type)
            {
                case "Veg":
                    chef = new VegPizzaChef();
                    break;
                case "NonVeg":
                    chef = new NonVegPizzaChef();
                    break;
                default:
                    throw new Exception("Invalid Pizza Type");
            }
            return chef.PreparePizza();
        }
    }
}
