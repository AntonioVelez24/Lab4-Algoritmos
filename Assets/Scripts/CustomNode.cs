using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomNode : Node<int>
{
    [SerializeField] private int currentTurn;

    [SerializeField] private List<Entity> entities;

    public int CurrentTurn => currentTurn;
    public List<Entity> Entities => entities;

    public CustomNode(int currentTurn, List<Entity> entities, int value) : base(value)
    {
        this.currentTurn = currentTurn;
        this.entities = entities; 
    }
}
