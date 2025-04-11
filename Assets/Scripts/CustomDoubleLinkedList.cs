using System.Collections.Generic;

public class CustomDoubleLinkedList : DoubleLinkedList<CustomNode>
{
    public Node<CustomNode> peak { get; private set; }
    public int peakIndex { get; private set; }

    public override void Add(CustomNode value)
    {
        if (peak != last && peak != null)
        {
            Node<CustomNode> temp = peak.Next;
            while (temp != null)
            {
                Node<CustomNode> next = temp.Next;
                temp = next;
            }

            last = peak;
            last.SetNext(null);
        }

        base.Add(value);
        peak = last;
        peakIndex = count - 1;
    }
}
