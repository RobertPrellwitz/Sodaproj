﻿using System;
using System.Collections.Generic;

namespace SodaMachine
{
    public class BackPack
    {
        public List<Can> sodas;

        public BackPack()
        {
            sodas = new List<Can>();
        }

        public void AddToBackPack()
        {
            pack.sodas.Add(selection);
        }
        public void BackPackContents()
        {
            for (int i = 0; i < sodas.Count; i++)
            {
                Console.WriteLine($"{sodas[i].name}");
            }
        }
    }
}
