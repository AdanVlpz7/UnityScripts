using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attach to an empty object
public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    //we should use static because this variable will be used across all the project.
    public static int counter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab);
        }
    }
}
