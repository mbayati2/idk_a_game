using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moment : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    [SerializeField] float rotateMoment;
    
    float rotateVelocity;


    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);

                Quaternion rotated = Quaternion.LookRotation(hit.point - transform.position);
                float rottaadssY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                rotated.eulerAngles.y,
                ref rotateVelocity,
                rotateMoment * (Time.deltaTime * 5));

                transform.eulerAngles = new Vector3(0 , rottaadssY, 0);
            }
        }
    }
}
