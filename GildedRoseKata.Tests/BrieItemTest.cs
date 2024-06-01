using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests;

public class BrieItemTest
{
    [Fact]
    public void Should_Update_Brie_Item_Quality_If_Lower_Than_50()
    {
        var brieItem = new BrieItem { Name = "Aged Brie", SellIn = 2, Quality = Quality.Default };

        brieItem.UpdateQuality();

        brieItem.Quality.Should().Be(Quality.Of(1));
    }

    [Fact]
    public void Should_Decrease_SellIn_At_Update_Quality()
    {
        var brieItem = new BrieItem { Name = "Aged Brie", SellIn = 2, Quality = Quality.Default };

        brieItem.UpdateQuality();

        brieItem.SellIn.Should().Be(1);
    }

    [Fact]
    public void Should_Increase_Quality_If_SellIn_Lower_Than_0()
    {
        var brieItem = new BrieItem { Name = "Aged Brie", SellIn = 0, Quality = Quality.Of(5) };

        brieItem.UpdateQuality();

        brieItem.Quality.Should().Be(Quality.Of(7));
    }
}