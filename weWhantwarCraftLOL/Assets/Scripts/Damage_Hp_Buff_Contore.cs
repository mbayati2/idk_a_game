using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "power/helth")]
public class Damage_Hp_Buff_Contore : PowerEffect
{
    [SerializeField] int amount;
    public override void Apply(GameObject target)
    {
        if(target.TryGetComponent<Hero>(out Hero hero))
        {
            hero.helth_Change_Control_Cnter(-amount , 0);
        }
    }
}
