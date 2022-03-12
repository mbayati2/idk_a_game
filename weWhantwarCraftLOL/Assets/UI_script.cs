using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_script : MonoBehaviour
{
    [SerializeField] TMP_Text Hp;
    [SerializeField] TMP_Text Damage;
    [SerializeField] TMP_Text Mana;
    [SerializeField] TMP_Text Defense;
    [SerializeField] Image Icon;
    private void Start()
    {
         Player_holder.player_Holder.Local_Hero_script.PlayerState_giver += Update_Ui;    
         Icon.sprite = Player_holder.player_Holder.Local_Hero_script.player_state.Hero_icon;
    }
    private void Update_Ui(int hp, int max_hp, int mana, int Max_mana, int damage, int Ability, int Crite, int magicPen, int arrmor, int IceCream )
    {
        Hp.text = $"{hp}/{max_hp}";
        Damage.text = $"{damage} {Ability} {Crite}";
        Mana.text = $"{mana}/{Max_mana}";
        Defense.text = $"{arrmor} {magicPen} {IceCream}";
        
    }

}
