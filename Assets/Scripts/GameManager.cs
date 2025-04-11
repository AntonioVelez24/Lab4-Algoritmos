using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    private CustomDoubleLinkedList doubleLinkedList = new CustomDoubleLinkedList();
    void Start()
    {
        
    }
    [Button("Add to List")]
    public void AddToList(CustomNode value)
    {
        doubleLinkedList.Add(value);
        print(value + " añadido a la lista");
    }
    [Button("Remove from List")]
    public void RemoveFromList(CustomNode value)
    {
        print(value + " eliminado de la lista");
        doubleLinkedList.Remove(value);
       
    }
    [Button("Read All")]
    public void ReadAll()
    {
        doubleLinkedList.ReadFromStart();

        print("Total de elementos: " + doubleLinkedList.count);
    }
}
