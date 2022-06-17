using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hp_Entetis : MonoBehaviour
{
    public int hp;
    public int current_Hp;
    private void Awake() => current_Hp = hp;


    public virtual void TakeDamage(int amount , GameObject target)
    {
        current_Hp -= amount;


        if (current_Hp <= 0)
            OnDIED();
    }

    private void OnDIED()
    {
        Destroy(gameObject);    
    }
}
