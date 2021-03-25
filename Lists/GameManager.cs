using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> names = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        names.Add("Adan");
        names.Add("Miguel");
        names.Add("Nati");
        names.Add("Sofia");
        names.Add("Frida");
        foreach (var name in names)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            names.RemoveAt(Random.Range(0, names.Count));
            foreach(var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}
