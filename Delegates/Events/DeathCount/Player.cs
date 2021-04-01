using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public delegate void OnDeath();
    public static event OnDeath onDeath;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }

    void Death()
    {
        /*without delegates we should do this.
        * but our player is looking out for a GameManager and UIManager.
        * GameObject.FindObjectOfType<GameManager>().ResetPlayer();
        * GameObject.FindObjectOfType<UIManager>().UpdateDeathCount();
        */
        //instead we will look if someone is listening.
        if(onDeath != null)
        {
            onDeath();
            //we will add those methods on their scripts to our onDeath()
        }
    }
}
