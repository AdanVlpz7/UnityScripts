using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;
    public void ButtonClick()
    {
        //turn al cubes red

        if(onClick != null)
            onClick();
    }
}
