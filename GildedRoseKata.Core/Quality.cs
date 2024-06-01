namespace GildedRoseKata.Core;

public sealed record Quality
{
    public static Quality Default => new(0);

    private Quality(int value)
    {
        Value = value;
    }

    public static Quality Of(int value)
    {
        return new Quality(value);
    }

    private int Value { get; }

    internal Quality Increase()
    {
        if (CanBeIncreased())
        {
            return new Quality(Value + 1);
        }

        return this;
    }

    internal Quality Decrease()
    {
        if (CanBeDecreased())
        {
            return new Quality(Value + -1);
        }

        return this;
    }

    internal bool CanBeIncreased() => Value < 50;

    private bool CanBeDecreased() => Value > 0;
}