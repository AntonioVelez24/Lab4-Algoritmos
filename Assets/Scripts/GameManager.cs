using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Diagnostics;

public class GameManager : MonoBehaviour
{
    private CustomDoubleLinkedList<Turn> TurndoubleLinkedList = new CustomDoubleLinkedList<Turn>();
    private List<Entity> entityList = new List<Entity>();

    private Entity entity1;
    private Entity entity2;
    private Entity entity3;

    void Start()
    {
        entity1 = SetEntity("Player", new Vector2(-5, 0));
        entity2 = SetEntity("Enemy1", new Vector2(5, 3));
        entity3 = SetEntity("Enemy2", new Vector2(5, -3));

        entityList.Add(entity1);
        entityList.Add(entity2);
        entityList.Add(entity3);

        AddTurn();
        ReadCurrentTurn();
    }
    [Button("Next Turn")]
    public void AddTurn()
    {
        Turn newTurn = new Turn(TurndoubleLinkedList.count + 1, entityList);
        TurndoubleLinkedList.Add(newTurn);
        print("Turno " + newTurn.CurrentTurn + " añadido");

        UpdateEntitiesPosition(newTurn.Entities);
    }

    #region Peak
    [Button("Next Turn (Peak)")]
    public void PeakNextTurn()
    {
        TurndoubleLinkedList.PeakNext();
        print("Turno: " + TurndoubleLinkedList.peak.Value.CurrentTurn);
        TurndoubleLinkedList.SetCount(TurndoubleLinkedList.peak.Value.CurrentTurn);
    }
    [Button("Previous Turn (Peak)")]
    public void PeakPrevTurn()
    {
        TurndoubleLinkedList.PeakPrev();
        print("Turno: " + TurndoubleLinkedList.peak.Value.CurrentTurn);
        TurndoubleLinkedList.SetCount(TurndoubleLinkedList.peak.Value.CurrentTurn);
    }
    #endregion

    #region Read
    [Button("Read Current Turn")]
    public void ReadCurrentTurn()
    {
        if (TurndoubleLinkedList.peak != null)
        {
            TurndoubleLinkedList.peak.Value.PrintTurn();
        }
        else
        {
            print("No hay turnos disponibles.");
        }
    }
    [Button("Read Count")]
    public void TurnCount()
    {
        print("Total de turnos: " + TurndoubleLinkedList.count);
    }
    #endregion

    #region Entitys
    public Entity SetEntity(string entityName, Vector2 position)
    {
        return new Entity(entityName,position);
    }
    public void UpdateEntitiesPosition(List<Entity> newEntities)
    {
        for (int i = 0; i < entityList.Count; i++)
        {
            entityList[i].SetPosition(newEntities[i].Position);
        }
    }
    #endregion
}
