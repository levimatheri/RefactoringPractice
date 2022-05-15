using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
    public static class StrategyFactory
    {
        public static IUpdateStrategy GetUpdateStrategy(Item item)
        {
            var itemName = item.Name;
            IUpdateStrategy updateStrategy = itemName switch
            {
                "Aged Brie" => new AgedBrieStrategy(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesStrategy(item),
                "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(item),
                "Conjured" => new ConjuredStrategy(item),
                _ => new StandardStrategy(item),
            };

            return updateStrategy;
        }
    }
}
