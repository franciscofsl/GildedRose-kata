using System.Collections;

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

    public void Add(BrieItem item)
    {
        _items.Add(item);
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < _items.Count; i++)
        {
            var item = _items[i];

            item.UpdateQuality();
        }
    }
}