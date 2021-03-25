using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Item[] inventory = new Item[10];

    private ItemDB _itemDatabase;

    private void Start()
    {
        inventory = new Item[10];
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //request Item by Id
            _itemDatabase.AddItem(0,this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            //remove Item by Id
            _itemDatabase.RemoveItem(0,this);
        }
    }
}
