namespace GildedRoseKata.Core;

public sealed class BackstageItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;

            if (SellIn < 11 && Quality < 50)
            {
                Quality++;
            }

            if (SellIn < 6 && Quality < 50)
            {
                Quality++;
            }
        }

        SellIn--;

        if (SellIn < 0)
        {
            Quality = 0;
        }
    }
}