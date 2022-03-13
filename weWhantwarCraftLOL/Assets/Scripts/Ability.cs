using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu( menuName = "power/Ability_scaling" )]
public class Ability : ScriptableObject
{
    [SerializeField] public KeyCode Ability_Buttom;
    [SerializeField] public float CoolDown;
    [SerializeField] public float Ability_Scaling_Ap;
    [SerializeField] public float Ability_Scaling_Ad;
    [SerializeField] public string Descrepen;
    [SerializeField] public Sprite icon;
}
