using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
    public class AgedBrieStrategy : IUpdateStrategy
    {
        public Item Item { get; }

        public AgedBrieStrategy(Item item)
        {
            Item = item;
        }

        public void UpdateState()
        {
            if (Item.Quality < 50)
            {
                // aged brie and backstage passes increases in quality
                Item.Quality++;
            }

            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                if (Item.Quality < 50)
                {
                    // aged brie increases in quality each day
                    Item.Quality++;
                }
            }
            
        }
    }
}
