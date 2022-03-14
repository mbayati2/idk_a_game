using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTargeting : MonoBehaviour
{

    public GameObject selectedHero;
    public bool heroPlayer;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        selectedHero = Player_holder.player_Holder.Local_player;
    }

    // Update is called once per frame
    void Update()
    {
        // Minion Targeting
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                // if the minion is targetable
                if (hit.collider.GetComponent<Targetable>() != null)
                {
                    if (hit.collider.gameObject.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion)
                    {
                        selectedHero.GetComponent<HeroCombat>().targetedEnemy = hit.collider.gameObject;
                    }
                }

                else if (hit.collider.gameObject.GetComponent<Targetable>() == null)
                {
                    selectedHero.GetComponent<HeroCombat>().targetedEnemy = null;
                }
            }
        }




    }
}
