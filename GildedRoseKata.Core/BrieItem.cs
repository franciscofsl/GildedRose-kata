namespace GildedRoseKata.Core;

public sealed class BrieItem : Item
{
    public override void UpdateQuality()
    {
        Quality = Quality.Increase();

        SellIn--;

        if (SellIn < 0)
        {
            Quality = Quality.Increase();
        }
    }
}