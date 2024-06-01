using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests;

public class ConjuredItemTest
{
    [Fact]
    public void Should_Decrease_Quality_If_Greater_Than_0()
    {
        var item = new ConjuredItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = Quality.Of(7) };

        item.UpdateQuality();

        item.Quality.Should().Be(Quality.Of(6));
    }

    [Fact]
    public void Should_Decrease_SellIn()
    {
        var item = new ConjuredItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = Quality.Of(7) };

        item.UpdateQuality();

        item.SellIn.Should().Be(4);
    }

    [Fact]
    public void Should_Decrease_Quality_When_SellIn_Lower_Than_0_And_Quality_Greater_Than_0()
    {
        var item = new ConjuredItem { Name = "+5 Dexterity Vest", SellIn = -1, Quality = Quality.Of(20) };

        item.UpdateQuality();

        item.Quality.Should().Be(Quality.Of(18));
    }
}