﻿using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests;

public class BackstageItemTest
{
    [Fact]
    public void Should_Increase_Backstage_Item_Quality_If_Lower_Than_50()
    {
        var backstageItem = new BackstageItem { Name = "Backstage", SellIn = 5, Quality = Quality.Of(49) };

        backstageItem.UpdateQuality();

        backstageItem.Quality.Should().Be(Quality.Of(50));
    }

    [Fact]
    public void Should_Increase_Quality_When_SellIn_Lower_Than_11()
    {
        var backstageItem = new BackstageItem { Name = "Backstage", SellIn = 10, Quality = Quality.Of(20) };

        backstageItem.UpdateQuality();

        backstageItem.Quality.Should().Be(Quality.Of(22));
    }

    [Fact]
    public void Should_Increase_Quality_When_SellIn_Lower_Than_6()
    {
        var backstageItem = new BackstageItem { Name = "Backstage", SellIn = 5, Quality = Quality.Of(20) };

        backstageItem.UpdateQuality();

        backstageItem.Quality.Should().Be(Quality.Of(23));
    }

    [Fact]
    public void Should_Decrease_SellIn()
    {
        var backstageItem = new BackstageItem { Name = "Backstage", SellIn = 5, Quality = Quality.Of(20) };

        backstageItem.UpdateQuality();

        backstageItem.SellIn.Should().Be(4);
    }

    [Fact]
    public void Should_Restart_Quality_When_SellIn_Lower_Than_0()
    {
        var backstageItem = new BackstageItem { Name = "Backstage", SellIn = -1, Quality = Quality.Of(20) };

        backstageItem.UpdateQuality();

        backstageItem.Quality.Should().Be(Quality.Of(0));
    }
}