using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                IUpdateStrategy updateStrategy = StrategyFactory.GetUpdateStrategy(item);
                updateStrategy.UpdateState();
            }
        }
    }
}
