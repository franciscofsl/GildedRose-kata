using System;
using GildedRoseKata.Core;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = new ItemsCollection
        {
            new ConjuredItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = Quality.Of(20) },
            new BrieItem { Name = "Aged Brie", SellIn = 2, Quality = Quality.Min },
            new ConjuredItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = Quality.Of(7) },
            new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = Quality.Of(80) },
            new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = Quality.Of(80) },
            new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = Quality.Of(20)
            },
            new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = Quality.Of(49)
            },
            new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = Quality.Of(49)
            },
            // this conjured item does not work properly yet
            new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = Quality.Of(6) }
        };

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine(items.ToString());
            Console.WriteLine("");
            items.UpdateQuality();
        }
    }
}