using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    //protected works like private, but allows classes who inherites Bank to use this variables
    protected string branchName;
    protected string location;
    protected int cashInVault;

    protected void checkBalance()
    {
        Debug.Log("Checking balance " + branchName);
    }
    protected void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }
    protected void Withdrawl()
    {
        Debug.Log("Withdrawl money from: " + branchName);
    }
}
