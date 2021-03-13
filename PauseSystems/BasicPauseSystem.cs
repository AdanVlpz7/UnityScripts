using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPauseSystem : MonoBehaviour
{
    // This script can be add to our UIManager

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Here we should call to show a simple pause menu
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }

    }
}
