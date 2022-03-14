using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Hero : MonoBehaviour
{
    [SerializeField] public Player_State player_state;
    [SerializeField] Transform spawnPSL;
    [Header("State_Current_State")]
    [HideInInspector] public int HP;
    [HideInInspector] public int Max_health;
    [HideInInspector] public int Damage_AD;
    [HideInInspector] public int Damage_AP;
    [HideInInspector] public int Attack_speed;
    [HideInInspector] public int Attack_Time;
    [HideInInspector] public int Mana;
    [HideInInspector] public int Max_mana;

    public event Action<int , int , int , int , int , int , int , int , int , int> PlayerState_giver;
    public event Action<int , int> Hp_Give;
    public event Action<int , int> Mana_Give;
    public event Action<int , int , int> Damage_Give;

    private void Start()
    {
        GameObject s = Instantiate(player_state.prefabe, spawnPSL.position - new Vector3(0 , 1.03f,0), transform.rotation);
        s.transform.SetParent(gameObject.transform);
        Start_State();
        StartCoroutine(delay());
    }
    private void Start_State()
    {
        HP = player_state.health;
        Max_health = player_state.Max_health;
        Mana = player_state.mana;
        Max_mana = player_state.Max_mana;
        Damage_AD = player_state.damage;
        Damage_AP = player_state.Ability;
        Attack_speed = player_state.Attack_speed;
        Attack_Time = player_state.Attack_Time;
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        PlayerState_giver(player_state.health, player_state.Max_health , player_state.mana , player_state.Max_mana , player_state.damage , player_state.Ability , player_state.Crite, player_state.magicPen , player_state.arrmor , player_state.IceCream);
    }
    public void Mana_Change_Control_Center(int mna, int max_mna)
    {
        Mana += mna;
        Max_mana += max_mna;
        Mana_Give(Mana , Max_mana);
    }
    public void helth_Change_Control_Cnter(int Hp, int max_hp)
    {
        HP += Hp;
        Max_health += max_hp;
        Hp_Give(HP , Max_health);
        if (HP <= 0)
        {
            Debug.Log("died");
        }
    }
    public void Damge_Change_Control_Center(int Damage, int Ability)
    {
        Damage_AD += Damage;
        Damage_AP += Ability;
        Damage_Give(Damage , Ability , 0);
    }
    public bool Have_enough_mana(int mana_use_amount)
    {
        if(Mana >= mana_use_amount)
        {
            Mana_Change_Control_Center(-mana_use_amount , 0);
            return true;
        }
        return false;
    }
}
