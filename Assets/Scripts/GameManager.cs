using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    private CustomDoubleLinkedList<string> doubleLinkedList = new CustomDoubleLinkedList<string>();
    void Start()
    {
        
    }
    [Button("Add to List")]
    public void AddToList(string value)
    {
        doubleLinkedList.Add(value);
        print(value + " añadido a la lista");
    }
    [Button("Remove from List")]
    public void RemoveFromList(string value)
    {
        print(value + " eliminado de la lista");
        doubleLinkedList.Remove(value);
       
    }
    [Button("Search Node")]
    public void SearchNode(string value)
    {
        Node<string> objective = doubleLinkedList.Seek(value);

        if (objective != null)
            print("Elemento encontrado: " + objective.Value.ToString());
        else
            print("No se encontro el elemento");
    }
    [Button("Read All")]
    public void ReadAll()
    {
        doubleLinkedList.ReadFromStart();

        print("Total de elementos: " + doubleLinkedList.count);
    }
}
