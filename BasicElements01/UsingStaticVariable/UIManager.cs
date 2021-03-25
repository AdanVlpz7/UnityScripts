using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script is attach to an empty object
public class UIManager : MonoBehaviour
{
    public Text activeEnemiesTxt;

    public void UpdateEnemiesUI()
    {
        activeEnemiesTxt.text = "Active Enemies: " + SpawnManager.counter;
    }
}
