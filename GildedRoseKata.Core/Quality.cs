namespace GildedRoseKata.Core;

public sealed record Quality
{
    private readonly int _value;
    
    public static Quality Default => new(0);

    private Quality(int value)
    {
        _value = value;
    }

    public static Quality Of(int value)
    {
        return new Quality(value);
    }

    public override string ToString() => _value.ToString();

    internal Quality Increase()
    {
        if (CanBeIncreased())
        {
            return new Quality(_value + 1);
        }

        return this;
    }

    internal Quality Decrease()
    {
        if (CanBeDecreased())
        {
            return new Quality(_value - 1);
        }

        return this;
    }

    internal bool CanBeIncreased() => _value < 50;

    private bool CanBeDecreased() => _value > 0;
}