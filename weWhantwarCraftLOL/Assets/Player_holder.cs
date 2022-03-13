using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_holder : MonoBehaviour
{
    [SerializeField] public static Player_holder player_Holder;
    private void Awake()
    {
        player_Holder = this;
        Local_Hero_script = player_Holder.Local_player.GetComponent<Hero>();
    }

    [SerializeField] public GameObject Local_player;
    [SerializeField] public Hero Local_Hero_script;
    [SerializeField] public Ablilty_UI ablilty_UI;
}
