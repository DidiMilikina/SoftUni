using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StackOfStrings
{
    private List<string> collection;

    public void Push(string item)
    {
        this.collection.Add(item);
    }

    public string Pop()
    {
        var result = this.collection.Last();
        this.collection.RemoveAt(this.collection.Count - 1);
        return result;
    }

    public string Peek()
    {
        return this.collection.Last();
    }

    public bool IsEmpty()
    {
        return this.collection.Count == 0;
    }
}
