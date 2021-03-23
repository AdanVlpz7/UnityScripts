using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attach to an empty object that we can rename NameDatabaseController
[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public string description;

    public Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
public class ItemData : MonoBehaviour
{
    public Item[] inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
