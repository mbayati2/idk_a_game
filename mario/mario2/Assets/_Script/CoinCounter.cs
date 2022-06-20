using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float Con;
    public static CoinCounter cc;

    public void Awake()
    {
        cc = GetComponent<CoinCounter>();
    }

    public void AddCon(float pro)
    {
        Con += pro;
        ChangeConText(Con);
    }

    public void ChangeConText(float con)
    {
        texto.text = "Cons: " + con;
    }
}
