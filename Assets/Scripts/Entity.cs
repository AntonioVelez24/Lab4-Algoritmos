using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    #region Properties
    [SerializeField] private string entityName;
    [SerializeField] private Vector2 position;
    #endregion

    #region Getters
    public string EntityName => entityName;
    public Vector3 Position => position;
    #endregion
}
