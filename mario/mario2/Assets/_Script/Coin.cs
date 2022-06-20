using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float con;

    private void OnCollisionEnter2D(Collision2D C)
    {
        if (C.gameObject.GetComponent<PlayerHp>() == true)
        {
            CoinPickup();
            Destroy(gameObject);
        }
        else { transform.localScale = new Vector3(transform.localScale.x + 7, transform.localScale.x + 7, 1); }
    }

    public void CoinPickup()
    {
        CoinCounter.cc.AddCon(con);
    }
}
