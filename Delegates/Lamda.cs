using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//an example using lambda expression.
public class Lambda : MonoBehaviour
{
    //creates a program who takes an string and tell you the characters.
    /* simple delegate
        public delegate int CharacterLength(string text);
    */

    //Func.
    //we are goint to give a string and return an int.
    public Func<string, int> CharacterLength;
    private void Start()
    {
        /* Without delegates 
            Debug.Log(GetCharacters("jonathan"));
        */

        /* Simple delegates
        CharacterLength cl = new CharacterLength(GetCharacters);
        */
        /* Func delegates
        CharacterLength += GetCharacters;
        Debug.Log(CharacterLength("Adan"));
        */
        // L A M B D A
        //we commit GetCharacters
        CharacterLength = (name) => name.Length;  
        Debug.Log(CharacterLength("Adan"));
    }
    /*
    int GetCharacters(string name)
    {
        return name.Length;
    }
    */
}
