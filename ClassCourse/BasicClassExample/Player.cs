using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public int ammo;
    public float fireRatio;

    public WeaponStats(string name, int ammo, float fireRatio)
    {
        this.name = name;
        this.ammo = ammo;
        this.fireRatio = fireRatio;
    }
}
public class Player : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform FirePos1, FirePos2;
    public int speed = 10;

    private WeaponStats blasters;
    private WeaponStats rockets;

    // Start is called before the first frame update
    void Start()
    {
        blasters = new WeaponStats("Blasters",40,4.0f);
        
        rockets = new WeaponStats("Rockets",20,25.0f);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        Shooting();
    }

    private void PlayerMovement()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hInput, vInput, 0) * speed * Time.deltaTime);

        if(transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);
        }

        if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }
    }
    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, FirePos1.position + new Vector3(0, 0.4f, 0), Quaternion.identity);
            Instantiate(missilePrefab, FirePos2.position + new Vector3(0, 0.4f, 0), Quaternion.identity);
        }
    }
}
