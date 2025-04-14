using System.Collections.Generic;

public class CustomDoubleLinkedList<T> : DoubleLinkedList<T>
{
    //public Node<T> peak;
    //public int peakIndex;

    public override void Add(T value)
    {
        base.Add(value);
        //peak = last;
        //peakIndex = count - 1;
    } 

}
