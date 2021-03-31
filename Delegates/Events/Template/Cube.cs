using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this is more effective than calling each cube and turning them red.
        //and the camera doesnt know about the cubes and the cubes about the camera.
        //with events only the classes can subscribe over them.
        Main.onClick += TurnRed;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        Main.onClick -= TurnRed;
    }
}
