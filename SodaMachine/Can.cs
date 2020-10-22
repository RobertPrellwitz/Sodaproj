using System;
namespace SodaMachine
{
    public abstract class Can
    {
        public string name;
       
        protected double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
            
        }

        public Can()
        {
        }
    }
    public class Cola : Can
    {
        public static double price;
        public Cola()
        {
            name = "Cola";
            cost = 0.35;
        }
        static Cola()
        {
            price = 0.35;
        }
            
    }
    public class RootBeer : Can
    {
        public static double price;
        public RootBeer()
        {
            name = "Root Beer";
            cost = 0.60;

        }
        static RootBeer()
        {
            price = 0.6;
        }
    }
    public class Orange : Can
    {
            public static double price;
        public Orange()
        {
            name = "Orange";
            cost = 0.06;
            
        }
            static Orange()
            {
                price = 0.06;
            }

    }
}
