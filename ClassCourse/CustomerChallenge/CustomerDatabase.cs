﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;

    public Customer(string firstName, string lastName,int age,string gender,string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}
public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    Customer[] clientes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
