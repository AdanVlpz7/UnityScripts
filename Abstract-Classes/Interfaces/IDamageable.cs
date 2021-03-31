using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    int Health { set; get; }

    void Damage(int damageAmount);
}
