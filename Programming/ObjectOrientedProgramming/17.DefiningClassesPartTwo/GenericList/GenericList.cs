using System;
using System.Text;

class GenericList<T> where T : IComparable<T>
{
    private T[] ListOfElements {get; set;}
    private int count;
    private int capacity;

    public GenericList(int size)
    {
        this.ListOfElements = new T[size];
        this.capacity = size;
        this.count = 0;
    }
    public GenericList()
    {
        this.ListOfElements = new T[4];
        this.capacity = 4;
        this.count = 0;
    }
    public void AddElement(T element)
    {
        if (this.count == this.capacity)
        {
            this.IncreaseCapacity();
        }
        ListOfElements[this.count] = element;
        this.count++;
    }
    public T GetElement(int index)
    {
        this.validate(index);
        return this.ListOfElements[index];
    }
    public void RemoveElement(int index)
    {
        this.validate(index);
        if (index == this.count - 1)
        {
            this.ListOfElements[index] = default(T);
        }
        else
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.ListOfElements[i] = this.ListOfElements[i + 1];
            }
            this.ListOfElements[this.ListOfElements.Length - 1] = default(T);
        }
        this.count--;
    }
    private void validate(int index)
    {
        if (index < 0 || index >= this.count)
        {
            throw new IndexOutOfRangeException("Index must be within the bounds of the List.");
        }
    }
    private void validateInsert(int index)
    {
        if (index < 0 || index > this.count)
        {
            throw new IndexOutOfRangeException("Index must be within the bounds of the List.");
        }
    }
    public void InsertElement(int index, T element)
    {
        this.validateInsert(index);
        if (this.count == this.capacity)
        {
            this.IncreaseCapacity();
        }
        if (index > count)
        {
            this.ListOfElements[index] = element;
        }
        else
        {
            for (int i = count; i >= index; i--)
            {
                this.ListOfElements[i + 1] = this.ListOfElements[i];
            }
            this.ListOfElements[index] = element;
        }
        this.count++;
        
    }
    private void IncreaseCapacity()
    {
        T[] newList = new T[this.capacity * 2];
        for (int i = 0; i < this.capacity; i++)
        {
            newList[i] = this.ListOfElements[i];
        }
        this.ListOfElements = newList;
        this.capacity = this.capacity * 2;
    }
    public void ClearList()
    {
        count = 0;
    }
    public bool FindElement(T element)
    {
        foreach (var item in this.ListOfElements)
        {
            if (element.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
    public override string ToString()
    {
        StringBuilder newBuilder = new StringBuilder();
        int index = 0;
        foreach (dynamic item in this.ListOfElements)
        {
            if (item != default(T) && index < count)
            {
                newBuilder.Append(item).Append(" ");
            }
            index++;
        }
        return newBuilder.ToString();
    }
    public T Min()
    {
        T min = this.ListOfElements[0];
        foreach (dynamic item in this.ListOfElements)
        {
            if (item.CompareTo(min) < 0 && item != default(T))
            {
                min = item;
            }
        }
        return min;
    }
    public T Max()
    {
        T max = this.ListOfElements[0];
        foreach (dynamic item in this.ListOfElements)
        {
            if (item.CompareTo(max) > 0 && item != default(T))
            {
                max = item;
            }
        }
        return max;
    }
}