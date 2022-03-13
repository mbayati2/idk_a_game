using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ability_use : MonoBehaviour
{
    [SerializeField] Ability ability1;
    [SerializeField] public bool coolDown_Ability1=true;
    [SerializeField] public event Action<float , string> cooldown_ability1;
    void Update()
    {
        if(Input.GetKeyDown(ability1.Ability_Buttom))
        {
            if(coolDown_Ability1 == false) { return; }
            Ability_use1();
        }
    }
    private void Ability_use1()
    {
        coolDown_Ability1 = false;
        cooldown_ability1(ability1.CoolDown, ability1.Descrepen);
    }
}
