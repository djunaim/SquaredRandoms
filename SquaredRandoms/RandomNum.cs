using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredRandoms
{
    class RandomNum
    {
        public List<int> RandomNumbersList = new List<int> { };
        public RandomNum()
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                RandomNumbersList.Add(rnd.Next(1, 51));
            }
        }
    }
}
