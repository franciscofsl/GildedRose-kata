namespace GildedRoseKata.Core;

public sealed class ConjuredItem : Item
{
    public override void UpdateQuality()
    {
        Quality = Quality.Decrease(Quality.Of(2));

        SellIn--;

        if (SellIn < 0)
        {
            Quality = Quality.Decrease(Quality.Of(2));
        }
    }
}