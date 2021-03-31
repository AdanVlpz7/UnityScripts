using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attached to the main camera.
public class Main : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //if we do a left click.
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            //if we click in our player or enemyS
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                /* Without interfaces we would do these checkings
                 * but it can be tedius to verify if we hit an specific object.
                 * 
                //this is in case we hit the player
                if(hitInfo.collider.name == "Player")
                    hitInfo.collider.GetComponent<Player>().Damage(10);
                //this is in case we hit an enemy
                else if (hitInfo.collider.name == "Enemy")
                    hitInfo.collider.GetComponent<Enemy>().Damage(10);
                */

                //we would just need to verify if our object has an interface.
                IDamageable obj = hitInfo.collider.GetComponent<IDamageable>();
                if(obj != null)
                {
                    obj.Damage(500);
                }
            }
        }
    }
}
