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
}