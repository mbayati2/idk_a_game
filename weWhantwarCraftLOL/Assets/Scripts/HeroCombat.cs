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

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<Moment>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetedEnemy != null)
        {
            if (Vector3.Distance(gameObject.transform.position, targetedEnemy.transform.position) > attackRange)
            {
                moveScript.agent.SetDestination(targetedEnemy.transform.position);
                moveScript.agent.stoppingDistance = attackRange;

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
}