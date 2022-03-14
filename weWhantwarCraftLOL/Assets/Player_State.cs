using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "power/state")]
public class Player_State : ScriptableObject
{
   [SerializeField] public int health;
   [SerializeField] public int Max_health;
   [SerializeField] public int mana;
   [SerializeField] public int Max_mana;
   [SerializeField] public int damage;
   [SerializeField] public int Ability;
   [SerializeField] public int Attack_speed;
   [SerializeField] public int Attack_Time;
   [SerializeField] public int arrmor;
   [SerializeField] public int magicPen;
   [SerializeField] public int Crite;
   [SerializeField] public int IceCream;
   [SerializeField] public Sprite Hero_icon;
   [SerializeField] public GameObject prefabe;
}
