using System.Collections.Generic;
using UnityEngine;

public class Turn 
{
    [SerializeField] private int currentTurn;

    [SerializeField] private List<Entity> entities;

    public int CurrentTurn => currentTurn;
    public List<Entity> Entities => entities;

    public Turn(int currentTurn, List<Entity> entities)
    {
        this.currentTurn = currentTurn;
        this.entities = new List<Entity>(entities); 
    }
    public void PrintTurn()
    {
        Debug.Log("Turno " + CurrentTurn);
        Debug.Log("Entidades en este turno: " + Entities.Count);
        foreach (var entity in Entities)
        {
            Debug.Log(entity.EntityName + " en posición " + entity.Position);
        }
    }
}
