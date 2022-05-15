using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void StandardItem_NotExpired_ShouldDecreaseQualityAndSellIn_ByOne()
        {
            IList<Item> Items = new List<Item> 
                { new Item { Name = "Foo", SellIn = 20, Quality = 50 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].SellIn);
            Assert.Equal(49, Items[0].Quality);
        }

        [Fact]
        public void StandardItem_Expired_ShouldDecreaseQuality_Twice()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Foo", SellIn = -1, Quality = 45 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(43, Items[0].Quality);
        }

        [Fact]
        public void Sulfuras_NeverExpireNeitherDecreaseInQuality()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 50, Quality = 80 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].SellIn);
            Assert.Equal(80, Items[0].Quality);
        }

        [Fact]
        public void ConjuredItem_NotExpired_ShouldDecreaseQualityAndSellIn_ByTwo()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Conjured", SellIn = 20, Quality = 50 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].SellIn);
            Assert.Equal(48, Items[0].Quality);
        }

        [Fact]
        public void ConjuredItem_Expired_ShouldDecreaseQuality_Twice()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Conjured", SellIn = -1, Quality = 45 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(41, Items[0].Quality);
        }

        [Fact]
        public void Quality_CannotExceedFifty()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 50 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void Quality_CannotBeLessThanZero()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Foo", SellIn = 20, Quality = 0 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void AgedBrie_IncreasesInQualityOnce_BeforeExpiry()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Aged Brie", SellIn = 20, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].SellIn);
            Assert.Equal(11, Items[0].Quality);
        }

        [Fact]
        public void AgedBrie_IncreasesInQualityTwice_AfterExpiry()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Aged Brie", SellIn = -1, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(12, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_IncreasesInQualityTwice_WithinTenDaysBeforeExpiry()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(12, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_IncreasesInQualityThrice_WithinFiveDaysBeforeExpiry()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
            Assert.Equal(13, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_QualityDropsToZero_AfterConcert()
        {
            IList<Item> Items = new List<Item>
                { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
    }
}
