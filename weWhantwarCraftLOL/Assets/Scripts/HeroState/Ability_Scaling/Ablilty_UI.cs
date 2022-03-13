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
    private float CoolDownSec_Ability1;
    private void Start()
    {
        image_ability1.sprite = sprite_ability1; Image_BackGround_1.sprite = sprite_ability1;
    }
    void Update()
    {
        Ability1();
    }
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
    public void Ability1_use(float CoolDownSec , string Descrepen)
    {
        isCoolDown_Ability1 = true;
        CoolDownSec_Ability1 = CoolDownSec;
    }
}
