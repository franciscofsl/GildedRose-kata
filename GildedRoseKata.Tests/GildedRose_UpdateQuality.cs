using FluentAssertions;
using GildedRoseKata.Core;

namespace GildedRoseKata.Tests
{
    /// <summary>
    /// Test naming convention recommendation:
    /// https://ardalis.com/unit-test-naming-convention/
    /// </summary>
    public class GildedRose_UpdateQuality
    {
        [Fact]
        public void DoesNothingGivenSulfuras()
        {
            int initialQuality = 80;
            var items = new List<Item>
            {
                new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = initialQuality },
            };
            var gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            var firstItem = items.First();

            firstItem.Quality.Should().Be(initialQuality);
        }
    }
}