using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour , IDamageAble
{

    [SerializeField] private int Hp;
    private int currrent_hp;
    private bool Alive = true;

    [Header("Event")]
    [SerializeField] private Vector3Event PlayerTakeDamage;
    [SerializeField] private boolEvent PlayerDied;
    [SerializeField] private boolEvent PlayerRespawnd;
 
    private void Awake() => currrent_hp = Hp;

    public void TakeDamge(int amount , GameObject target)
    {
        
        currrent_hp -= amount;

        OnTakeDamage(new Vector3(currrent_hp , amount));

        if (currrent_hp <= 0)
            OnDIED();     
           
    }

    #region  Events

    private void OnTakeDamage(Vector3 vector3)
    {
        PlayerTakeDamage.Rasise(vector3);
    }

    private void OnDIED()
    {
        Alive = false;
        PlayerDied.Rasise(Alive);
        Debug.Log("Died");
    }
    private void OnRespawnd(Vector3 pos)
    {
        Alive = true;
        PlayerRespawnd.Rasise(Alive);
    }

    #endregion
}
