using UnityEngine;

public class CustomDoubleLinkedList<T> : DoubleLinkedList<T>
{
    public Node<T> peak;
    public int peakIndex;

    public override void Add(T value)
    {
        if (peak != null && peak != last)
        {
            peak.SetNext(null); 
            last = peak; 
        }
        Node<T> newNode = new Node<T>(value);

        if (head == null)
        {
            head = newNode;
            last = newNode;
            peak = newNode; 
            peakIndex = 0;
            count = 1;
        }
        else
        {
            if (peak == last)
            {
                base.Add(value);
                peak = last;
            }
            else
            {
                newNode.SetPrev(peak);
                newNode.SetNext(peak.Next);

                if (peak.Next != null)
                {
                    peak.Next.SetPrev(newNode);
                }

                peak.SetPrev(newNode);
                last = newNode; 
                peak = newNode; 
                peakIndex++; 
                count++;    
            }
        }
    }
    public void PeakNext()
    {
        if (peak != null && peak.Next != null)
        {
            peak = peak.Next;
            peakIndex++;
        }
        else
        {
            Debug.Log("No quedan mas turnos.");
        }
    }
    public void PeakPrev()
    {
        if (peak != null && peak.Prev != null)
        {
            peak = peak.Prev;
            peakIndex--;
        }
        else
        {
            Debug.Log("No hay mas turnos anteriores.");
        }
    }
    public int GetPeakIndex()
    {
        return peakIndex;
    }
    public void SetCount(int count)
    {
        this.count = count;
    }
}
