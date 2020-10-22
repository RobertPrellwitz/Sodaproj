using System;
namespace SodaMachine
{
    public abstract class Can
    {
        public static double price;
        protected double cost;

        public double Cost
        {
            get
            {
                return price;
            }
            
        }
        public string name;

        public Can()
        {
        }
    }
    public class Cola : Can
    {
        public Cola()
        {
            name = "Cola";
            cost = 0.35;
            price = 0.35;
        }
    }
    public class RootBeer : Can
    {
        public RootBeer()
        {
            name = "Root Beer";
            cost = 0.60;
            price = 0.60;
        }
    }
    public class Orange : Can
    {
        public Orange()
        {
            name = "Orange";
            cost = 0.06;
            price = 0.06;
        }

    }
}
