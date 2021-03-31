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
        Main.onClick += Teleport;
    }


    public void Teleport()
    {
        Debug.Log("Teleporting");
        transform.position = new Vector3(5, 2, 0);
    }

    private void OnDisable()
    {
        Main.onClick -= Teleport;
    }
}
