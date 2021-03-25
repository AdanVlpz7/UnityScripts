using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test
{
    Player boy = new Player();
    public Test()
    {
        // boy.Speed = 5; I can't because it's private.
        float n = boy.Speed; // but we can read it.

        string name = boy.Name;
        boy.Name = "Miguel";
    }

}
public class Player : MonoBehaviour
{
    private float _speed;
    public string _name;

    // Update is called once per frame
    public float Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    private void Start()
    {
        Speed = 10f;
        Debug.Log(Speed);
    }
    void Update()
    {

    }
}
