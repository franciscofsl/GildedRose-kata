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
            var items = new List<Item> {
                                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = initialQuality},

            };
            var gildedRose = new GildedRose(items);
            
            gildedRose.UpdateQuality();

            var firstItem = items.First();
            
            // Use your preferred assertion library (already included - pick one delete others)
            // xunit default
            Assert.Equal(initialQuality, firstItem.Quality);

            // fluentassertions
            firstItem.Quality.Should().Be(initialQuality);

            // shouldly
            firstItem.Quality.Should().Be(initialQuality);
        }
    }
}
