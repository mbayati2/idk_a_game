using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "power/helth")]
public class Damage_Hp_Buff_Contore : PowerEffect
{
    [SerializeField] int amount;
    public override void Apply(GameObject target)
    {
        Debug.Log($"Damage{amount}");
    }
}
