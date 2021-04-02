using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //needed for actions.
public class Player : MonoBehaviour
{
    //using actions

    public static Action<int> OnDamageReceived;
    
   // using delegates

    // public delegate void OnDamageReceived(int currentHealth);
    // public static event OnDamageReceived onDamageReceived;
    
    public int Health { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        //not the best option.
        // UIManager.UpdateHealth(Health);
        
        if(OnDamageReceived != null)
        {
            OnDamageReceived(Health);
        }
    }
}
