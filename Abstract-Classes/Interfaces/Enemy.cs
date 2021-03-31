using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script is attach to our enemy prefab.

public class Enemy : MonoBehaviour, IDamageable
{
    public int Health {
        get; set; 
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
