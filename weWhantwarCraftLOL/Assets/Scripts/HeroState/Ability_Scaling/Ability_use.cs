using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ability_use : MonoBehaviour
{
        [SerializeField] public Ability ability1;
    [SerializeField] public bool coolDown_Ability1=true;
    [SerializeField] public event Action<float , string> cooldown_ability1;
        [SerializeField] public Ability ability2;
    [SerializeField] public bool coolDown_Ability2=true;
    [SerializeField] public event Action<float , string> cooldown_ability2;
        [SerializeField] public Ability ability3;
    [SerializeField] public bool coolDown_Ability3=true;
    [SerializeField] public event Action<float , string> cooldown_ability3;
        [SerializeField] public Ability ability4;
    [SerializeField] public bool coolDown_Ability4=true;
    [SerializeField] public event Action<float , string> cooldown_ability4;
    void Update()
    {
            if(Input.GetKeyDown(ability1.Ability_Buttom))
        {
            if(coolDown_Ability1 == false) { return; }
            Ability_use1();
        }
                if(Input.GetKeyDown(ability2.Ability_Buttom))
        {
            if(coolDown_Ability2 == false) { return; }
            Ability_use2();
        }
                if(Input.GetKeyDown(ability3.Ability_Buttom))
        {
            if(coolDown_Ability3 == false) { return; }
            Ability_use3();
        }
                if(Input.GetKeyDown(ability4.Ability_Buttom))
        {
            if(coolDown_Ability4 == false) { return; }
            Ability_use4();
        }
    }
        private void Ability_use1()
    {
        coolDown_Ability1 = false;
        cooldown_ability1(ability1.CoolDown, ability1.Descrepen);
    }
        private void Ability_use2()
    {
        coolDown_Ability2 = false;
        cooldown_ability2(ability2.CoolDown, ability2.Descrepen);
    }
        private void Ability_use3()
    {
        coolDown_Ability3 = false;
        cooldown_ability3(ability3.CoolDown, ability3.Descrepen);
    }
        private void Ability_use4()
    {
        coolDown_Ability4 = false;
        cooldown_ability4(ability4.CoolDown, ability4.Descrepen);
    }
}
