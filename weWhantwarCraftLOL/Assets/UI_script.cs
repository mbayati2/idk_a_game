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
         Player_holder.player_Holder.Local_Hero_script.Hp_Give += Update_Ui_HP_Only; 
         Player_holder.player_Holder.Local_Hero_script.Mana_Give += Update_Ui_Mana_Only; 
         Player_holder.player_Holder.Local_Hero_script.Damage_Give += Update_Ui_Damage_Only; 
         Icon.sprite = Player_holder.player_Holder.Local_Hero_script.player_state.Hero_icon;
    }
    private void Update_Ui(int hp, int max_hp, int mana, int Max_mana, int damage, int Ability, int Crite, int magicPen, int arrmor, int IceCream )
    {
        Hp.text = $"{hp}/{max_hp}";
        Damage.text = $"{damage} {Ability} %{Crite}/100";
        Mana.text = $"{mana}/{Max_mana}";
        Defense.text = $"{arrmor} {magicPen} {IceCream}";
        
    }
        private void Update_Ui_HP_Only(int HP, int Max_health)
    {
        Hp.text = $"{HP}/{Max_health}";
    }
        private void Update_Ui_Mana_Only(int Mana, int Max_mana)
    {
        this.Mana.text = $"{Mana}/{Max_mana}";
    }
        private void Update_Ui_Damage_Only(int Damage_AD, int Damage_AP, int Crite)
    {
        Damage.text = $"{Damage_AD} {Damage_AP} %{Crite}/100";
    }
}
