namespace GildedRoseKata.Core;

public sealed class SulfurasItem : Item
{
    public override void UpdateQuality()
    {
        Quality = Quality.Increase();
    }
}