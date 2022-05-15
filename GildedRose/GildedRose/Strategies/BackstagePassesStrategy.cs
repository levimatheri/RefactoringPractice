using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackstagePassesStrategy : IUpdateStrategy
    {
        public Item Item { get; }

        public BackstagePassesStrategy(Item item)
        {
            Item = item;
        }

        public void UpdateState()
        {
            if (Item.Quality < 50)
            {
                Item.Quality++;
            }

            if (Item.SellIn < 11)
            {
                if (Item.Quality < 50)
                {
                    // 10 days or less quality increases by 2
                    Item.Quality++;
                }
            }

            if (Item.SellIn < 6)
            {
                if (Item.Quality < 50)
                {
                    // 5 days or less quality increases by 3
                    Item.Quality++;
                }
            }

            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
