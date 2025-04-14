using UnityEngine;

public interface IEntity
{
    string EntityName { get; }
    Vector2 Position { get; }

    void SetPosition(Vector2 newPosition);
}
public class Entity : IEntity
{
    #region Properties
    [SerializeField] private string entityName;
    [SerializeField] private Vector2 position;
    #endregion

    #region Getters
    public string EntityName => entityName;
    public Vector2 Position => position;
    #endregion

    public Entity(string entityName, Vector2 position)
    {
        this.entityName = entityName;
        this.position = position;
    }

    public void SetPosition(Vector2 newPosition)
    {
        position = newPosition;
    }
}
