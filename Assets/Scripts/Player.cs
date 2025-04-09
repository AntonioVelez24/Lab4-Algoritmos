using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string namePlayer;
    [SerializeField] private int age;

    public string NamePlayer => namePlayer;
    public int Age => age;
}
