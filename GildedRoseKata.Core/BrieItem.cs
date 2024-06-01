namespace GildedRoseKata.Core;

public sealed class BrieItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }

        SellIn--;

        if (SellIn < 0 && Quality < 50)
        {
            Quality++;
        }
    }
}