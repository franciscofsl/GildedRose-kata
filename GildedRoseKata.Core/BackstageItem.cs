namespace GildedRoseKata.Core;

public sealed class BackstageItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality.CanBeIncreased())
        {
            Quality = Quality.Increase();

            if (SellIn < 11)
            {
                Quality = Quality.Increase();
            }

            if (SellIn < 6)
            {
                Quality = Quality.Increase();
            }
        }

        SellIn--;

        if (SellIn < 0)
        {
            Quality = Quality.Default;
        }
    }
}