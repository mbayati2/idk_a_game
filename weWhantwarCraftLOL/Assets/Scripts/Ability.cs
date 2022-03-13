using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu( menuName = "power/Ability_scaling" )]
public class Ability : ScriptableObject
{
    [SerializeField] public KeyCode Ability_Buttom;
    [SerializeField] public int CoolDown;
    [SerializeField] public int Mana_Cost;
    [SerializeField] public int Ability_Scaling_Ap;
    [SerializeField] public int Ability_Scaling_Ad;
    [SerializeField] public string namee;
    [SerializeField] public string Descrepen;
    [SerializeField] public Sprite icon;
}
