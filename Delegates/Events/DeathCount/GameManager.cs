using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.onDeath += ResetPlayer;
    }
    // Start is called before the first frame update
    public void ResetPlayer()
    {
        Debug.Log("Resetting player");
    }
}
