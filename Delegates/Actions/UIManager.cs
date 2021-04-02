using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    public void OnEnable()
    {
        Player.onDamageReceived += UpdateHealth;
    }
    public void UpdateHealth(int Health)
    {
        Debug.Log("Current Health: " + Health);
    }
}
