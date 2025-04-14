using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

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
    [Button("Avanzar Turno")]
    public void AddTurn()
    {
        Turn newTurn = new Turn(TurndoubleLinkedList.count +1, entityList);
        TurndoubleLinkedList.Add(newTurn);
        print("Turno " + newTurn.CurrentTurn + " añadido");
    }

    #region Peak
    [Button("Next Turn (Peak)")]
    public void PeakNext()
    {

    }
    [Button("Previous Turn (Peak)")]
    public void PeakPrev()
    {

    }
    #endregion
    #region Read
    [Button("Read Current Turn")]
    public void ReadCurrentTurn()
    {
        TurndoubleLinkedList.last.Value.PrintTurn();
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
    #endregion

}
