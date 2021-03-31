using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void HClick()
    {
        if (onClick != null)
            onClick();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HClick();
        }
    }
}
