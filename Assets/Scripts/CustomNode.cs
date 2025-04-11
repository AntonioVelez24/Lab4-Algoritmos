using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomNode : Node<CustomNode>
{
    [SerializeField] private int currentTurn;

    [SerializeField] private List<Entity> entities;

    public int CurrentTurn => currentTurn;
    public List<Entity> Entities => entities;

    public CustomNode(int currentTurn, List<Entity> entities) : base(null)
    {
        this.currentTurn = currentTurn;
        this.entities = new List<Entity>(entities); 
    }
}
