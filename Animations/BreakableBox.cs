using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    public GameObject fractureCrate;
    public GameObject explosionEffect;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explosionEffect, transform.position - new Vector3(0,1,0), Quaternion.identity);
            GameObject fractureCrateObj = Instantiate(fractureCrate,transform.position,Quaternion.identity) as  GameObject;
            Destroy(this.gameObject);
            Rigidbody[] allRigidBodies = fractureCrateObj.GetComponentsInChildren<Rigidbody>();
            if (allRigidBodies.Length > 0)
            {
                foreach(var body in allRigidBodies)
                {
                    body.AddExplosionForce(500, transform.position - new Vector3(0, 1, 0), 1);
                }
            }
        }
    }
}