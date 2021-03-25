using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attach to our prefab
public class Enemy : MonoBehaviour
{
    private UIManager _ui;
    private void OnEnable()
    {
        SpawnManager.counter++;
        _ui = GameObject.Find("UIManager").GetComponent<UIManager>();
        _ui.UpdateEnemiesUI();
        Die();
    }
    private void OnDisable()
    {
        SpawnManager.counter--;
        _ui.UpdateEnemiesUI();
    }

    void Die()
    {
        Destroy(this.gameObject,Random.Range(2,6));
    }
}
