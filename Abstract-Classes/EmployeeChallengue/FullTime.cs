using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//and we can add this script to our character on the inspector
public class FullTime : Employee
{
    public float salary = 7000;
    public override void CalculateMonthlySalary()
    {
        Debug.Log(salary*2);
    }
}
