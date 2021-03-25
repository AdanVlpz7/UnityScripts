using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public Sprite icon;
}


public class ItemDB : MonoBehaviour
{
    public List<Item> ItemDataBase = new List<Item>();

    public void AddItem(int itemID, Player player)
    {
        //check if item matches something
        foreach(var item in ItemDataBase)
        {
            if(item.id == itemID)
            {
                Debug.Log("We have a match");
                //we should also will know if we have "space"
                //we will add the item to the player inventory
                player.inventory[0] = item;
                return;
            }
            else
            {
                Debug.Log("Item does not exist");
            }
        }
    }    
    public void RemoveItem(int itemID, Player player)
    {
        //check if item matches something
        foreach (var item in ItemDataBase)
        {
            if (item.id == itemID)
            {
                Debug.Log("We have a match");
                //we should also will know if we have "space"
                //we will add the item to the player inventory
                player.inventory[0] = null;
                return;
            }
            else
            {
                Debug.Log("Item does not exist");
            }
        }
    }
}
