using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroCombat : MonoBehaviour
{
    public enum HeroAttackType {Melee, Ranged}
    public HeroAttackType heroAttackType;

    public GameObject targetedEnemy;
    public float attackRange;
    public float rotateSpeedForAttack;

    private Moment moveScript;

    public bool basicAtkIdle = false;
    public bool isHeroAlive;
    public bool performMeleeAttack = true;
    bool MIR_MIR_MIR;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<Moment>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetedEnemy == null) { return; }

            if (Vector3.Distance(gameObject.transform.position, targetedEnemy.transform.position) > attackRange)
            {
                moveScript.agent.SetDestination(targetedEnemy.transform.position);
                // Rotation
                Quaternion rotated = Quaternion.LookRotation(targetedEnemy.transform.position - transform.position);
                float rottaadssY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                rotated.eulerAngles.y,
                ref moveScript.rotateVelocity,
                moveScript.rotateMoment * (Time.deltaTime * 5));

                transform.eulerAngles = new Vector3(0, rottaadssY, 0);
            }
            else
            {
                moveScript.agent.stoppingDistance = attackRange;
                Debug.Log("MIR");
                if (heroAttackType == HeroAttackType.Melee)
                {
                    if (performMeleeAttack)
                    {
                        Debug.Log("Attack The Minion");
                        // Start Corotine to attack
                    }
                }
            }
    }
}
