namespace GildedRoseKata.Core;

public sealed record Quality
{
    private Quality(int value)
    {
        Value = value;
    }

    internal Quality Of(int value)
    {
        return new Quality(value);
    }

    public int Value { get; }
}