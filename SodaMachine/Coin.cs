using System;
namespace SodaMachine
{
    public abstract class Coin
    {
        public string name;
        protected double value;
        public double Value
        {
            get
            {
                return value;
            }
        }
        public Coin()
        {
        }
    
    }
    public class Penny : Coin
    {  
        public Penny()
        {
            name = "penny";
            value = 0.01;
        }
    }

    public class Nickel : Coin
    {
        public Nickel()
        {
            name = "nickel";
            value = 0.05;

        }
    }
    public class Dime : Coin
    {
        public Dime()
        {
            name = "dime";
            value = 0.10;
        }
    }
    public class Quarter : Coin
    {
        public Quarter()
        {
            name = "quarter";
            value = 0.25;
        }
    }
}
