using System;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public int Count
    {
        get { return items.Count; }
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return items[items.Count - 1];
    }

    public void Clear()
    {
        items.Clear();
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }
}
