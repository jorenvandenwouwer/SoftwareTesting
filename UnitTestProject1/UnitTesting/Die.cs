using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class Die
    {
        private static readonly Random random = new Random();
        public int Roll()
        {
            return random.Next(5) + 1;
        }
    }
}
