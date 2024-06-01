namespace GildedRoseKata.Core;

public sealed class BackstageItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;

            if (SellIn < 11)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }

            if (SellIn < 6)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }
        }

        SellIn = SellIn - 1;

        if (SellIn < 0)
        {
            Quality = Quality - Quality;
        }
    }
}