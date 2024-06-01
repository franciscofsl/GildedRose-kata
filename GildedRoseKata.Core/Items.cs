using System.Collections;
using System.Text;

namespace GildedRoseKata.Core;

public class ItemsCollection : IEnumerable<Item>
{
    private readonly IList<Item> _items = new List<Item>();

    public IEnumerator<Item> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public void UpdateQuality()
    {
        Parallel.ForEach(_items, _ => _.UpdateQuality());
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine("name, sellIn, quality");

        foreach (var item in _items)
        {
            builder.AppendLine(item.ToString());
        }

        return builder.ToString();
    }
}