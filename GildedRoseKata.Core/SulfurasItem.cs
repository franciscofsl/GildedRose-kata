namespace GildedRoseKata.Core;

public sealed class SulfurasItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }
}