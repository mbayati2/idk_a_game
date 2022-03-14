using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moment : MonoBehaviour
{
    public NavMeshAgent agent;

    public float rotateMoment;
    public float rotateVelocity;

    private HeroCombat HeroCombatScript;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        HeroCombatScript = gameObject.GetComponent<HeroCombat>();
    }

    void Update()
    {
        if (HeroCombatScript.targetedEnemy != null)
        {
            if (HeroCombatScript.targetedEnemy.GetComponent<HeroCombat>() != null)
            {
                if (HeroCombatScript.targetedEnemy.GetComponent<HeroCombat>().isHeroAlive)
                {
                    HeroCombatScript.targetedEnemy = null;
                }
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;

            // Check if the raycast shot hits something that uses the navmesh system.
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
               if (hit.collider.tag == "Floor")
                {
                    // Movement
                    agent.SetDestination(hit.point);
                    HeroCombatScript.targetedEnemy = null;
                    agent.stoppingDistance = 0;

                    // Rotation
                    Quaternion rotated = Quaternion.LookRotation(hit.point - transform.position);
                    float rottaadssY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                    rotated.eulerAngles.y,
                    ref rotateVelocity,
                    rotateMoment * (Time.deltaTime * 5));

                    transform.eulerAngles = new Vector3(0, rottaadssY, 0);
                }
            }
        }
    }
}
