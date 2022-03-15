using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Ablilty_UI : MonoBehaviour
{
        [SerializeField] public event Action<bool> CoolDownReady1_A;
    [SerializeField] bool isCoolDown_Ability1;
    [SerializeField] Image image_ability1;
    [SerializeField] public Sprite sprite_ability1;
    [SerializeField] private Image Image_BackGround_1;
    [SerializeField] public GameObject INDCATER1; 
        [SerializeField] public event Action<bool> CoolDownReady2_A;
    [SerializeField] bool isCoolDown_Ability2;
    [SerializeField] Image image_ability2;
    [SerializeField] public Sprite sprite_ability2;
    [SerializeField] private Image Image_BackGround_2; 
    [SerializeField] public GameObject INDCATER2; 
        [SerializeField] public event Action<bool> CoolDownReady3_A;
    [SerializeField] bool isCoolDown_Ability3;
    [SerializeField] Image image_ability3;
    [SerializeField] public Sprite sprite_ability3;
    [SerializeField] private Image Image_BackGround_3; 
    [SerializeField] public GameObject INDCATER3; 
        [SerializeField] public event Action<bool> CoolDownReady4_A;
    [SerializeField] bool isCoolDown_Ability4;
    [SerializeField] Image image_ability4;
    [SerializeField] public Sprite sprite_ability4;
    [SerializeField] private Image Image_BackGround_4; 
    [SerializeField] public GameObject INDCATER4; 
    [SerializeField] Ability_descrpesn ability_Descrpesn1;
    [SerializeField] Ability_descrpesn ability_Descrpesn2;
    [SerializeField] Ability_descrpesn ability_Descrpesn3;
    [SerializeField] Ability_descrpesn ability_Descrpesn4;

    private float CoolDownSec_Ability1;
    private float CoolDownSec_Ability2;
    private float CoolDownSec_Ability3;
    private float CoolDownSec_Ability4;
    bool done1;
    bool done2;
    bool done3;
    bool done4;
    private void Start()
    {
        image_ability1.sprite = sprite_ability1; Image_BackGround_1.sprite = sprite_ability1;
        image_ability2.sprite = sprite_ability2; Image_BackGround_2.sprite = sprite_ability2;
        image_ability3.sprite = sprite_ability3; Image_BackGround_3.sprite = sprite_ability3;
        image_ability4.sprite = sprite_ability4; Image_BackGround_4.sprite = sprite_ability4;
        ability_Descrpesn1.INDCATER = INDCATER1; ability_Descrpesn2.INDCATER = INDCATER2;
        ability_Descrpesn3.INDCATER = INDCATER3; ability_Descrpesn4.INDCATER = INDCATER4;
    }
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();
    }
    #region Ability_cool_down_and_UI_Controle
    void Ability1()
    {
        if (isCoolDown_Ability1 == false)
        {
            image_ability1.fillAmount = 1;
        }
        if (isCoolDown_Ability1)
        {
            CoolDownReady1_A(false);
            image_ability1.fillAmount -= 1 / CoolDownSec_Ability1 * Time.deltaTime;

            if (image_ability1.fillAmount <= 0)
            {
                image_ability1.fillAmount = 0;
                isCoolDown_Ability1 = false;
                CoolDownReady1_A(true);
            }
        }
    }
    public void Ability1_use(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        isCoolDown_Ability1 = true;
        CoolDownSec_Ability1 = CoolDownSec;
        if (!done1) { Ability1_UI(CoolDownSec , Descrepen , name , Mana_Cost); done1=true; }  
    }
        void Ability2()
    {
        if (isCoolDown_Ability2 == false)
        {
            image_ability2.fillAmount = 1;
        }
        if (isCoolDown_Ability2)
        {
            CoolDownReady2_A(false);
            image_ability2.fillAmount -= 1 / CoolDownSec_Ability2 * Time.deltaTime;

            if (image_ability2.fillAmount <= 0)
            {
                image_ability2.fillAmount = 0;
                isCoolDown_Ability2 = false;
                CoolDownReady2_A(true);
            }
        }
    }
    public void Ability2_use(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        isCoolDown_Ability2 = true;
        CoolDownSec_Ability2 = CoolDownSec;
        if (!done2) { Ability2_UI(CoolDownSec , Descrepen , name , Mana_Cost); done2=true; }  
    }
        void Ability3()
    {
        if (isCoolDown_Ability3 == false)
        {
            image_ability3.fillAmount = 1;
        }
        if (isCoolDown_Ability3)
        {
            CoolDownReady3_A(false);
            image_ability3.fillAmount -= 1 / CoolDownSec_Ability3 * Time.deltaTime;

            if (image_ability3.fillAmount <= 0)
            {
                image_ability3.fillAmount = 0;
                isCoolDown_Ability3 = false;
                CoolDownReady3_A(true);
            }
        }
    }
    public void Ability3_use(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        isCoolDown_Ability3 = true;
        CoolDownSec_Ability3 = CoolDownSec;
        if (!done3) { Ability3_UI(CoolDownSec , Descrepen , name , Mana_Cost); done3=true; }  
    }
        void Ability4()
    {
        if (isCoolDown_Ability4 == false)
        {
            image_ability4.fillAmount = 1;
        }
        if (isCoolDown_Ability4)
        {
            CoolDownReady4_A(false);
            image_ability4.fillAmount -= 1 / CoolDownSec_Ability4 * Time.deltaTime;

            if (image_ability4.fillAmount <= 0)
            {
                image_ability4.fillAmount = 0;
                isCoolDown_Ability4 = false;
                CoolDownReady4_A(true);
            }
        }
    }
        public void Ability4_use(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        isCoolDown_Ability4 = true;
        CoolDownSec_Ability4 = CoolDownSec;
        if (!done4) { Ability4_UI(CoolDownSec , Descrepen , name , Mana_Cost); done4=true; }  
    }
    #endregion
        public void Ability1_UI(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        ability_Descrpesn1.cooldown = CoolDownSec;
        ability_Descrpesn1.Descrepen = Descrepen;
        ability_Descrpesn1.Namee = name;
        ability_Descrpesn1.Mana_Cost = Mana_Cost;
    }
        public void Ability2_UI(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        ability_Descrpesn2.cooldown = CoolDownSec;
        ability_Descrpesn2.Descrepen = Descrepen;
        ability_Descrpesn2.Namee = name;
        ability_Descrpesn2.Mana_Cost = Mana_Cost;
    }
        public void Ability3_UI(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        ability_Descrpesn3.cooldown = CoolDownSec;
        ability_Descrpesn3.Descrepen = Descrepen;
        ability_Descrpesn3.Namee = name;
        ability_Descrpesn3.Mana_Cost = Mana_Cost;
    }
        public void Ability4_UI(int CoolDownSec , string Descrepen , string name , int Mana_Cost)
    {
        ability_Descrpesn4.cooldown = CoolDownSec;
        ability_Descrpesn4.Descrepen = Descrepen;
        ability_Descrpesn4.Namee = name;
        ability_Descrpesn4.Mana_Cost = Mana_Cost;
    }
}
