using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Dictionaries can be specially useful working with a kind of shop/market as an inventory.
public class ItemDB : MonoBehaviour
{
    // a list: 
    public List<Item> listDatabase = new List<Item>();
    // a dictionary:
    public Dictionary<int, Item> DictionaryDatabase = new Dictionary<int, Item>();

    private void Start()
    {
        Item sword = new Item();
        sword.name = "sword";
        sword.id = 0;
        
        Item cape = new Item();
        cape.name = "cape";
        cape.id = 1;

        Item bread = new Item();
        bread.name = "bread";
        bread.id = 2;


        //adding an element.
        //DictionaryDatabase.Add(0, new Item());
        DictionaryDatabase.Add(sword.id, sword);
        DictionaryDatabase.Add(bread.id, bread);
        DictionaryDatabase.Add(cape.id, cape);

        //working with the elements.
        var item1 = DictionaryDatabase[0];
        item1.name = "New Sword";

        /* looping through the dictionary
        foreach (KeyValuePair<int,Item> item in DictionaryDatabase)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Name: " + item.Value.name);
        }
        */

        /*looping through the keys.
        foreach(var keys in DictionaryDatabase.Keys)
        {
            Debug.Log("keys: " + keys);
        }
        */

        //looping through a value.
        foreach (var item in DictionaryDatabase.Values)
        {
            Debug.Log("Items names: " + item.name);
        }

        //looking for an specific key.
        int x = 0;
        if (DictionaryDatabase.ContainsKey(x))
        {
            Debug.Log("You found the key");
        }
    }
}
