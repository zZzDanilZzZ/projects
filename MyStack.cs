using System;
using System.Collections.Generic;

public class MyStack
{
    private LinkedList<double> _items;

    public MyStack()
    {
        _items = new LinkedList<double>();
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    public void Push(double value)
    {
        _items.AddLast(value);
    }

    public double Pop()
    {
        double value = Peek();
        _items.RemoveLast();
        return value;
    }

    public double Peek()
    {
        if (IsEmpty())
        {
            throw new Exception("Stack is Empty!");
        }
        return _items.Last.Value;
    }

    public int Count()
    {
        return _items.Count;
    }

    public bool Contains(double value)
    {
        return _items.Contains(value);
    }

    public void Clear()
    {
        _items.Clear();
    }
}
