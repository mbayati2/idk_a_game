using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Hero : MonoBehaviour
{
    [SerializeField] public Player_State player_state;
    [SerializeField] Transform spawnPSL;
    public event Action<int , int , int , int , int , int , int , int , int , int> PlayerState_giver;

    private void Start()
    {
        GameObject s = Instantiate(player_state.prefabe, spawnPSL.position - new Vector3(0 , 1.03f,0), transform.rotation);
        s.transform.SetParent(gameObject.transform);
        PlayerState_giver(player_state.health, player_state.Max_health , player_state.mana , player_state.Max_mana , player_state.damage , player_state.Ability , player_state.Crite, player_state.magicPen , player_state.arrmor , player_state.IceCream);
    }
}
