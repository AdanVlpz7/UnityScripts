using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

    void Start()
    {
        // **** Changing position of an object at the beginning. ****
            //we grab the actual position and we set it a new one with a vector
            transform.position = new Vector3(0, 5, 0);
    }
    private void Update()
    {
        // **** USER INPUT ****
        //we can use Input.GetKeyDown or Input.GetKeyUp to know 
        //when does the user press a button and when he/she stop doing it 
        //as GetKey to know if you are holding a key.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("you have press the key Space");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("holding Space");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("you have stop pressing the key Space");
        }

        // **** SIMPLE MOVEMENT ****
        //using GetKey to use the arrow keys to give movement to our object.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            int speed = 2;
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            int speed = 2;
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            int speed = 2;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            int speed = 2;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}