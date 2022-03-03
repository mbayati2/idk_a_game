using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomaterore : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Update()
    {
        animator.SetFloat("moment", Input.GetAxis("Horizontal"));
    }
}
