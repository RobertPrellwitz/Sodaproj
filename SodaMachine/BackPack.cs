using System;
using System.Collections.Generic;

namespace SodaMachine
{
    public class BackPack : Customer
    {
        public List<Can> sodas;

        public BackPack()
        {
            sodas = new List<Can>();
        }

    }
}
