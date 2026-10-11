public class Repository<T>
{
    private readonly List<T> _items = new();
    public void Add(T item) => _items.Add(item);
    public IEnumerable<T> All() => _items;
}