using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int DeathCount;
    public Text DeathTxt;
    private void OnEnable()
    {
        Player.onDeath += UpdateDeathCount;
    }
    public void UpdateDeathCount()
    {
        DeathCount++;
        DeathTxt.text = "Deaths: " + DeathCount.ToString();
    }
}
