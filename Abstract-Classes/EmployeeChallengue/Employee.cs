using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public static string companyName = "Suntower";
    public string name;
    public abstract void CalculateMonthlySalary();
}