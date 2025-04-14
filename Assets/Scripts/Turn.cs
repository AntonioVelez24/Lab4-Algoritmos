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
        this.entities = new List<Entity>();

        for (int i = 0; i < entities.Count; i++)
        {
            Entity original = entities[i];
            Vector2 randomPosition = GetRandomPosition(original.Position);
            Entity newEntity = new Entity(original.EntityName, randomPosition);
            this.entities.Add(newEntity);
        }
    }
    public Vector2 GetRandomPosition(Vector2 currentPosition)
    {
        float deltaX = Random.Range(-1f, 1f);
        float deltaY = Random.Range(-1f, 1f);
        return currentPosition + new Vector2(deltaX, deltaY);
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
