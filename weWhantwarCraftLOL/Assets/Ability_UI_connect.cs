using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_UI_connect : MonoBehaviour
{
    [SerializeField] Ability_use ability_Use;
    [SerializeField] Ablilty_UI ablilty_UI;
    [SerializeField] Ability IDCOTOR1_UI;
    [SerializeField] Ability IDCOTOR2_UI;
    [SerializeField] Ability IDCOTOR3_UI;
    [SerializeField] Ability IDCOTOR4_UI;
    [SerializeField] Transform Ability_IDCOTOR4_SPAWN_UI_PEPE_POPO;
    [HideInInspector] public GameObject UI_IDC_GAMEOBJECT_1;
    [HideInInspector] public GameObject UI_IDC_GAMEOBJECT_2;
    [HideInInspector] public GameObject UI_IDC_GAMEOBJECT_3;
    [HideInInspector] public GameObject UI_IDC_GAMEOBJECT_4;
    private void Start()
    {
                ablilty_UI.sprite_ability1 = ability_Use.ability1.icon;
        ablilty_UI.CoolDownReady1_A += Ability1_bool;
        ability_Use.cooldown_ability1 += ablilty_UI.Ability1_use;

                ablilty_UI.sprite_ability2 = ability_Use.ability2.icon;
        ablilty_UI.CoolDownReady2_A += Ability2_bool;
        ability_Use.cooldown_ability2 += ablilty_UI.Ability2_use;

                ablilty_UI.sprite_ability3 = ability_Use.ability3.icon;
        ablilty_UI.CoolDownReady3_A += Ability3_bool;
        ability_Use.cooldown_ability3 += ablilty_UI.Ability3_use;

                ablilty_UI.sprite_ability4 = ability_Use.ability4.icon;
        ablilty_UI.CoolDownReady4_A += Ability4_bool;
        ability_Use.cooldown_ability4 += ablilty_UI.Ability4_use;
        if (IDCOTOR1_UI == null) { IDCOTOR1_UI = ability_Use.ability1; IDCOTOR2_UI = ability_Use.ability2; IDCOTOR3_UI = ability_Use.ability3; IDCOTOR4_UI = ability_Use.ability4; }
        if (IDCOTOR1_UI.Ability_IDCT == null) { return; }
        UI_IDC_GAMEOBJECT_1 = Instantiate(IDCOTOR1_UI.Ability_IDCT , Ability_IDCOTOR4_SPAWN_UI_PEPE_POPO);
        UI_IDC_GAMEOBJECT_2 = Instantiate(IDCOTOR2_UI.Ability_IDCT , Ability_IDCOTOR4_SPAWN_UI_PEPE_POPO);
        UI_IDC_GAMEOBJECT_3 = Instantiate(IDCOTOR3_UI.Ability_IDCT , Ability_IDCOTOR4_SPAWN_UI_PEPE_POPO);
        UI_IDC_GAMEOBJECT_4 = Instantiate(IDCOTOR4_UI.Ability_IDCT , Ability_IDCOTOR4_SPAWN_UI_PEPE_POPO);
        ablilty_UI.INDCATER1 = UI_IDC_GAMEOBJECT_1;
        ablilty_UI.INDCATER2 = UI_IDC_GAMEOBJECT_2;
        ablilty_UI.INDCATER3 = UI_IDC_GAMEOBJECT_3;
        ablilty_UI.INDCATER4 = UI_IDC_GAMEOBJECT_4;
    }
        private void Ability1_bool(bool ioi)
    {
        ability_Use.coolDown_Ability1 = ioi;
    }
        private void Ability2_bool(bool ioi)
    {
        ability_Use.coolDown_Ability2 = ioi;
    }
        private void Ability3_bool(bool ioi)
    {
        ability_Use.coolDown_Ability3 = ioi;
    }
        private void Ability4_bool(bool ioi)
    {
        ability_Use.coolDown_Ability4 = ioi;
    }
}
