using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* A delegate is a variable that holds a method.
 * 
 * 
 */
public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onChangeColor;// in this case onChangeColor is the variable.

    public delegate void OnComplete();
    public OnComplete onComplete;

    private void Start()
    {
        //we assign it like a variable.      
        onChangeColor = UpdateColor;
        onChangeColor(Color.red);

        //it would print all the task, we can also delete them.
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        if(onComplete != null)
            onComplete();
    }
    //this method should had the same parameters if we want to compare it with out delegate.
    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changin color to: " + newColor.ToString());
    }
    public void Task()
    {
        Debug.Log("Task 1 Finished");
    }
    public void Task2()
    {
        Debug.Log("Task 2 Finished");
    }
    public void Task3()
    {
        Debug.Log("Task 3 Finished");
    }
}
