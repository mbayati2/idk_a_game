using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Ability_descrpesn : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler

{
   [SerializeField] public string Namee;
   [SerializeField] public string Descrepen;
   [SerializeField] public int Mana_Cost;
   [SerializeField] public int cooldown;
   [SerializeField] private TMP_Text mana;
   [SerializeField] private TMP_Text namesd;
   [SerializeField] private TMP_Text dp;
   [SerializeField] private TMP_Text cods;
   [SerializeField] private Image icon;
   [SerializeField] private Image icon2;
   [SerializeField] private GameObject ga;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ga.SetActive(true);
       mana.text = $"Mana: {Mana_Cost}";
       namesd.text = Namee;
       dp.text = Descrepen;
       cods.text = $"CD: {cooldown}";
       icon2.sprite = icon.sprite; 
    }
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
         ga.SetActive(false);
    }
}
