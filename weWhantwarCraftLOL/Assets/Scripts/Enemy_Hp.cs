using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy_Hp : MonoBehaviour
{
    [SerializeField] public event Action<int , int> HP_Change_ACN;
    private int Hp_Enemy;
    [SerializeField] private int Max_health;
    private void Start()
    {
        Hp_Enemy = Max_health;
        if (HP_Change_ACN == null) { return; }
        HP_Change_ACN(Hp_Enemy , Max_health);
    }
    public void HP_Change_Controle_Center_Enemy_Verson_2V(int damage)
    {
        Hp_Enemy -= damage;
        Debug.Log($"DEALD DAMAGE TO ENEMY {damage}");
        if (Hp_Enemy <= 0)
        {
            Debug.Log("DIED");
        }
        if (HP_Change_ACN == null) { return; }
        HP_Change_ACN(damage , Max_health);
    }
}
