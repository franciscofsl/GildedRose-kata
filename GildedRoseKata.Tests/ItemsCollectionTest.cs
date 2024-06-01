using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests;

public class ItemsCollectionTest
{
    [Fact]
    public void Should_Update_Items_Quality()
    {
        var originalQuality = Quality.Default;

        var item = new BrieItem { SellIn = 2, Quality = originalQuality };

        var items = new ItemsCollection
        {
            item
        };

        items.UpdateQuality();

        item.Quality.Should().NotBe(originalQuality);
    }

    [Fact]
    public void Should_Print_Items()
    {
        var items = new ItemsCollection
        {
            new BrieItem { SellIn = 2, Quality = Quality.Of(4) },
            new ConjuredItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = Quality.Of(7) },
        };

        var info = items.ToString();

        var infoByLines = info.Split(Environment.NewLine);

        infoByLines[0].Should().Be("name, sellIn, quality");
        infoByLines[1].Should().NotBeNullOrEmpty();
    }
}