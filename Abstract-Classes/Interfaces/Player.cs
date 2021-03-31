using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is attached to our player prefab.
public class Player : MonoBehaviour, IDamageable
{
    public int Health {
        get; set;
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
