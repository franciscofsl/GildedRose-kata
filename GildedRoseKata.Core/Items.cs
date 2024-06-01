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
        foreach (var item in _items)
        {
            item.UpdateQuality();
        }
    }
}