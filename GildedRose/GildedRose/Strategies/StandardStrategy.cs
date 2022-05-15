using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class StandardStrategy : IUpdateStrategy
    {
        public Item Item { get; }

        public StandardStrategy(Item item)
        {
            Item = item;
        }

        public void UpdateState()
        {
            if (Item.Quality > 0)
            {
                Item.Quality--;
            }

            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                Item.Quality--;
            }
        }
    }
}
