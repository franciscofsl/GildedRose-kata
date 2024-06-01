using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests;

public class SulfurasItemTest
{
    [Fact]
    public void Should_Increase_Quality_If_Lower_Than_50()
    {
        var item = new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = Quality.Of(10) };

        item.UpdateQuality();

        item.Quality.Should().Be(11);
    }
}