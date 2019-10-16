using System.Collections;
using System.Collections.Generic;

public abstract class AbstractItem : IBag<AbstractItem>, IHasWeight
{
    public abstract float Weight { get; }

    public void Add(AbstractItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Remove(AbstractItem item)
    {
        throw new System.NotImplementedException();
    }

    public IEnumerator<AbstractItem> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
