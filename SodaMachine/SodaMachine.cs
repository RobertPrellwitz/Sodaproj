﻿using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class SodaMachine

    {   public int colaCount;
        public int rootBeerCount;
        public int orangeCount;

        
        public List<Coin> register;
        public List<Can> inventory;
        public SodaMachine()
        {
            register = new List<Coin>();
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter());
                register.Add(new Nickel());

            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());

            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            inventory = new List<Can>();

            for (int i = 0; i < 15; i++)
            {
                inventory.Add(new Cola());
                inventory.Add(new RootBeer());
                inventory.Add(new Orange());

            }
        }

        //public void MachineChange()
        //{
        //    register = new List<Coin>();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        register.Add(new Quarter());
        //        register.Add(new Nickel());

        //    }
        //    for (int i = 0; i < 50; i++)
        //    {
        //        register.Add(new Penny());

        //    }
        //}
        //public void MachineStock()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        register.Add(new Dime());
        //    }
        //    inventory = new List<Can>();

        //    for (int i = 0; i < 15; i++)
        //    {
        //        inventory.Add(new Cola());
        //        inventory.Add(new RootBeer());
        //        inventory.Add(new Orange());

        //    }

            //}

            public void CurrentInventory()
        {
            colaCount = 0; rootBeerCount = 0; orangeCount = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name == "Cola")
                {
                    colaCount = ++colaCount;
                }
                else if (inventory[i].name == "Root Beer")
                {
                    rootBeerCount = ++rootBeerCount;
                }
                else if (inventory[i].name == "Orange")
                {
                    orangeCount = ++orangeCount;
                }

            }
            Console.WriteLine($"The machine currently holds the following:\n" +
                 $"{colaCount} colas \n{rootBeerCount} Root Beer" +
                 $"\n{orangeCount} orange sodas");

        }

    }
}
