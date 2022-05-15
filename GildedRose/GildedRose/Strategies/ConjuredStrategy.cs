using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
    public class ConjuredStrategy : IUpdateStrategy
    {
        public Item Item { get; }

        public ConjuredStrategy(Item item)
        {
            Item = item;
        }

        public void UpdateState()
        {
            if (Item.Quality > 0)
            {
                Item.Quality -= 2;
            }

            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                Item.Quality -= 2;
            }
        }
    }
}
