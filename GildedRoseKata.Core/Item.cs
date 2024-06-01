namespace GildedRoseKata.Core;

public abstract class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public Quality Quality { get; set; }

    public abstract void UpdateQuality();

    public override string ToString() => $"{Name}, {SellIn}, {Quality}";
}