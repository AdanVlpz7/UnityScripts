using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item2
    //this doesn't support inheritence.
    //a V A L U E type.
    //stored on Stack.
{
    public string name;
    public int id;
    public Item2(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}
public class Item
    //this supports inheritence.
    //a R E F E R E N C E type.
    //stored on the HEAP.
{
    public string name;
    public int id;
    public Item(string name,int id)
    {
        this.name = name;
        this.id = id;
    }

}
public class Test : MonoBehaviour
{
    Item sword = new Item("sword",1);
    Item2 bread;
    private void Start()
    {
        bread.name = "bread";
        bread.id = 2;
        Debug.Log("Sword current name: " + sword.name); //print Sword
        Debug.Log("Bread current name: " + bread.name); //print Bread
        ChangeValue(sword);
        ChangeValue(bread);
        Debug.Log("Sword current name: " + sword.name); // print Master Sword

    }
    void ChangeValue(Item2 structType)
    {
        structType.name = "Dirty Bread";
        //here it creates a copy
        Debug.Log("Bread current name: " + bread.name); //print Dirty Bread
    }
    void ChangeValue(Item classType)
    {
        classType.name = "Master Sword";
    }
}
