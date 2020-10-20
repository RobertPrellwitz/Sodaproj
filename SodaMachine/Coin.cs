using System;
namespace SodaMachine
{
    public abstract class Coin
    {
        public string name;
        private double value;
        public double Value;
        
         

        public Coin()
        {
        }
        public abstract void SetValue();
    }
    public class Penny : Coin

    {
        public Penny()
        {
        }
            public override void SetValue()
        {
            Value = 0.01;
        }
        //public double Value
        //{
        //    get
        //    {
        //        return value;
        //    }
        //}


        
    }

    public class Nickel : Coin
    {
        public Nickel()
        {
            private double nickelValue = 0.05;

        }
    }
    public class Dime : Coin
    {
        public Dime()
        {

        }
    }
    public class Quarter : Coin
    {
        public Quarter()
        {

        }
    }
}
