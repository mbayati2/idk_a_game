using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_UI_connect : MonoBehaviour
{
    [SerializeField] Ability_use ability_Use;
    [SerializeField] Ablilty_UI ablilty_UI;
    private void Start()
    {
        ablilty_UI.sprite_ability1 = ability_Use.ability1.icon;
        ablilty_UI.CoolDownReady1_A += Ability1_bool;
        ability_Use.cooldown_ability1 += ablilty_UI.Ability1_use;
    }
    private void Ability1_bool(bool ioi)
    {
        ability_Use.coolDown_Ability1 = ioi;
    }
}
