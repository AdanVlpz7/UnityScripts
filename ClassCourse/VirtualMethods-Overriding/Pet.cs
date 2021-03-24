using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string name;
    // Start is called before the first frame update
    protected virtual void Speak()
    {
        Debug.Log("Speak");
    }
    private void Start()
    {
        Speak();
        //this will print the Speak() from Dog and Duck
    }
}
